using Sales_Tracker.DataClasses;
using Sales_Tracker.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sales_Tracker.Rentals
{
    public partial class ReturnRental_Form : Form
    {
        private Customer? selectedCustomer;
        private List<RentalRecord> activeRentals;
        private List<CheckBox> rentalCheckBoxes;
        private MainMenu_Form mainMenuForm;

        public ReturnRental_Form(MainMenu_Form mainMenu)
        {
            InitializeComponent();
            mainMenuForm = mainMenu;
            activeRentals = new List<RentalRecord>();
            rentalCheckBoxes = new List<CheckBox>();
            LoadCustomersWithActiveRentals();

            // Apply theme and language
            ThemeManager.SetThemeForForm(this);
            LanguageManager.UpdateLanguageForControl(this);
        }

        private void LoadCustomersWithActiveRentals()
        {
            CustomerComboBox.Items.Clear();

            var customersWithRentals = Customer.Customers
                .Where(c => c.GetActiveRentals().Count > 0)
                .OrderBy(c => c.Name)
                .ToList();

            foreach (var customer in customersWithRentals)
            {
                CustomerComboBox.Items.Add($"{customer.Name} - {customer.GetActiveRentals().Count} active rental(s)");
            }

            if (CustomerComboBox.Items.Count > 0)
            {
                CustomerComboBox.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No customers with active rentals found.", "No Active Rentals",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex < 0) return;

            var customersWithRentals = Customer.Customers
                .Where(c => c.GetActiveRentals().Count > 0)
                .OrderBy(c => c.Name)
                .ToList();

            selectedCustomer = customersWithRentals[CustomerComboBox.SelectedIndex];
            LoadActiveRentals();
        }

        private void LoadActiveRentals()
        {
            if (selectedCustomer == null) return;

            // Clear previous rental checkboxes
            RentalsPanel.Controls.Clear();
            rentalCheckBoxes.Clear();
            activeRentals = selectedCustomer.GetActiveRentals();

            int yPosition = 10;

            foreach (var rental in activeRentals)
            {
                var rentalItem = RentalInventoryManager.GetRentalItem(rental.RentalItemID);
                if (rentalItem == null) continue;

                // Create checkbox for rental
                var checkBox = new CheckBox
                {
                    Location = new Point(10, yPosition),
                    Size = new Size(650, 80),
                    Font = new Font("Segoe UI", 10F),
                    AutoSize = false
                };

                // Build rental info text
                string overdueText = rental.IsOverdue ? " [OVERDUE]" : "";
                string dueText = rental.DueDate.HasValue ? $" (Due: {rental.DueDate.Value:MMM dd, yyyy})" : "";
                decimal outstanding = rental.TotalCost - rental.AmountPaid;

                checkBox.Text = $"Rental #{rental.RentalRecordID}\n" +
                    $"Product: {rental.ProductName} | Qty: {rental.Quantity} | Rate: {rental.RateType}\n" +
                    $"Start: {rental.StartDate:MMM dd, yyyy}{dueText}{overdueText}\n" +
                    $"Total: {rental.TotalCost:C} | Paid: {rental.AmountPaid:C} | Outstanding: {outstanding:C}";

                if (rental.IsOverdue)
                {
                    checkBox.ForeColor = Color.Red;
                }

                rentalCheckBoxes.Add(checkBox);
                RentalsPanel.Controls.Add(checkBox);

                yPosition += 90;
            }

            if (activeRentals.Count == 0)
            {
                var label = new Label
                {
                    Text = "No active rentals for this customer.",
                    Location = new Point(10, 10),
                    Size = new Size(650, 30),
                    Font = new Font("Segoe UI", 10F)
                };
                RentalsPanel.Controls.Add(label);
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show("Please select a customer.", "No Customer Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected rentals
            var selectedRentals = new List<RentalRecord>();
            for (int i = 0; i < rentalCheckBoxes.Count; i++)
            {
                if (rentalCheckBoxes[i].Checked)
                {
                    selectedRentals.Add(activeRentals[i]);
                }
            }

            if (selectedRentals.Count == 0)
            {
                MessageBox.Show("Please select at least one rental to return.", "No Rentals Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime returnDate = ReturnDatePicker.Value;
            string notes = NotesTextBox.Text.Trim();

            // Confirm return
            var result = MessageBox.Show(
                $"Are you sure you want to return {selectedRentals.Count} rental(s) for {selectedCustomer.Name}?\n\n" +
                $"Return Date: {returnDate:MMM dd, yyyy}",
                "Confirm Return",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            // Process returns
            ProcessReturns(selectedRentals, returnDate, notes);
        }

        private void ProcessReturns(List<RentalRecord> rentalsToReturn, DateTime returnDate, string notes)
        {
            try
            {
                foreach (var rental in rentalsToReturn)
                {
                    // 1. Mark rental record as returned
                    rental.ReturnDate = returnDate;
                    rental.IsActive = false;
                    rental.IsOverdue = false;

                    if (!string.IsNullOrWhiteSpace(notes))
                    {
                        rental.Notes = string.IsNullOrWhiteSpace(rental.Notes)
                            ? $"Return notes: {notes}"
                            : $"{rental.Notes}\nReturn notes: {notes}";
                    }

                    // 2. Update rental item inventory
                    var rentalItem = RentalInventoryManager.GetRentalItem(rental.RentalItemID);
                    if (rentalItem != null)
                    {
                        rentalItem.ReturnItem(rental.Quantity);
                    }

                    // 3. Update customer rental status
                    selectedCustomer?.ReturnRental(rental.RentalRecordID);

                    // 4. Update DataGridView row
                    UpdateDataGridViewRow(rental, returnDate);
                }

                // 5. Save all changes
                RentalInventoryManager.SaveInventory();
                Customer.SaveCustomers();

                // 6. Save rental data
                DataGridViewManager.DataGridViewRowsAdded(mainMenuForm.Rental_DataGridView, ReadOnlyVariables.Rentals_file);

                // 7. Refresh charts and UI
                mainMenuForm.LoadOrRefreshMainCharts();

                MessageBox.Show(
                    $"Successfully returned {rentalsToReturn.Count} rental(s) for {selectedCustomer?.Name}.",
                    "Return Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while processing returns: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void UpdateDataGridViewRow(RentalRecord rental, DateTime returnDate)
        {
            // Find the row in the DataGridView that matches this rental
            foreach (DataGridViewRow row in mainMenuForm.Rental_DataGridView.Rows)
            {
                if (row.Tag is TagData tagData && tagData.RentalRecordID == rental.RentalRecordID)
                {
                    // Update the tag data
                    tagData.IsReturned = true;
                    tagData.ReturnDate = returnDate;
                    row.Tag = tagData;

                    // Apply visual indicator (strikethrough and color)
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.Font = new Font(cell.Style.Font ?? row.DataGridView.DefaultCellStyle.Font, FontStyle.Strikeout);
                        cell.Style.ForeColor = Color.Gray;
                    }

                    // Add return date to notes column if exists
                    int noteColumnIndex = ReadOnlyVariables.Note_column;
                    if (noteColumnIndex >= 0 && noteColumnIndex < row.Cells.Count)
                    {
                        string currentNote = row.Cells[noteColumnIndex].Value?.ToString() ?? "";
                        string returnNote = $"[RETURNED: {returnDate:MMM dd, yyyy}]";

                        if (string.IsNullOrWhiteSpace(currentNote))
                        {
                            row.Cells[noteColumnIndex].Value = returnNote;
                        }
                        else if (!currentNote.Contains("RETURNED"))
                        {
                            row.Cells[noteColumnIndex].Value = $"{currentNote}\n{returnNote}";
                        }
                    }

                    break;
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var checkBox in rentalCheckBoxes)
            {
                checkBox.Checked = SelectAllCheckBox.Checked;
            }
        }
    }
}
