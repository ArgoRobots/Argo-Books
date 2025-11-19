using System.Windows.Forms;

namespace Sales_Tracker
{
    partial class ReturnRental_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Title_Label = new Label();
            SelectCustomer_Label = new Label();
            CustomerComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            NoActiveRentals_Label = new Label();
            ActiveRentals_Label = new Label();
            SelectAllCheckBox = new CheckBox();
            RentalsPanel = new Panel();
            ReturnDate_Label = new Label();
            ReturnDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            Notes_Label = new Label();
            NotesTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            Return_Button = new Guna.UI2.WinForms.Guna2Button();
            Cancel_Button = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            //
            // Title_Label
            //
            Title_Label.AutoSize = true;
            Title_Label.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Title_Label.Location = new Point(38, 31);
            Title_Label.Margin = new Padding(4, 0, 4, 0);
            Title_Label.Name = "Title_Label";
            Title_Label.Size = new Size(285, 45);
            Title_Label.TabIndex = 0;
            Title_Label.Text = "Return Rental(s)";
            //
            // SelectCustomer_Label
            //
            SelectCustomer_Label.AutoSize = true;
            SelectCustomer_Label.Font = new Font("Segoe UI", 11F);
            SelectCustomer_Label.Location = new Point(38, 100);
            SelectCustomer_Label.Margin = new Padding(4, 0, 4, 0);
            SelectCustomer_Label.Name = "SelectCustomer_Label";
            SelectCustomer_Label.Size = new Size(171, 30);
            SelectCustomer_Label.TabIndex = 1;
            SelectCustomer_Label.Text = "Select Customer";
            //
            // CustomerComboBox
            //
            CustomerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerComboBox.BackColor = Color.Transparent;
            CustomerComboBox.CustomizableEdges = customizableEdges1;
            CustomerComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            CustomerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerComboBox.FocusedColor = Color.Empty;
            CustomerComboBox.Font = new Font("Segoe UI", 10F);
            CustomerComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            CustomerComboBox.ItemHeight = 44;
            CustomerComboBox.Location = new Point(38, 138);
            CustomerComboBox.Margin = new Padding(4, 5, 4, 5);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CustomerComboBox.Size = new Size(672, 50);
            CustomerComboBox.TabIndex = 2;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            //
            // NoActiveRentals_Label
            //
            NoActiveRentals_Label.AutoSize = true;
            NoActiveRentals_Label.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            NoActiveRentals_Label.ForeColor = Color.Red;
            NoActiveRentals_Label.Location = new Point(38, 193);
            NoActiveRentals_Label.Margin = new Padding(4, 0, 4, 0);
            NoActiveRentals_Label.Name = "NoActiveRentals_Label";
            NoActiveRentals_Label.Size = new Size(449, 25);
            NoActiveRentals_Label.TabIndex = 3;
            NoActiveRentals_Label.Text = "No active rentals found. No customers have active rentals.";
            NoActiveRentals_Label.Visible = false;
            //
            // ActiveRentals_Label
            //
            ActiveRentals_Label.AutoSize = true;
            ActiveRentals_Label.Font = new Font("Segoe UI", 11F);
            ActiveRentals_Label.Location = new Point(38, 238);
            ActiveRentals_Label.Margin = new Padding(4, 0, 4, 0);
            ActiveRentals_Label.Name = "ActiveRentals_Label";
            ActiveRentals_Label.Size = new Size(346, 30);
            ActiveRentals_Label.TabIndex = 4;
            ActiveRentals_Label.Text = "Active Rentals (select to return)";
            //
            // SelectAllCheckBox
            //
            SelectAllCheckBox.AutoSize = true;
            SelectAllCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SelectAllCheckBox.Location = new Point(58, 278);
            SelectAllCheckBox.Margin = new Padding(4, 5, 4, 5);
            SelectAllCheckBox.Name = "SelectAllCheckBox";
            SelectAllCheckBox.Size = new Size(108, 29);
            SelectAllCheckBox.TabIndex = 5;
            SelectAllCheckBox.Text = "Select All";
            SelectAllCheckBox.UseVisualStyleBackColor = true;
            SelectAllCheckBox.CheckedChanged += SelectAllCheckBox_CheckedChanged;
            //
            // RentalsPanel
            //
            RentalsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RentalsPanel.AutoScroll = true;
            RentalsPanel.BorderStyle = BorderStyle.FixedSingle;
            RentalsPanel.Location = new Point(38, 313);
            RentalsPanel.Margin = new Padding(4, 5, 4, 5);
            RentalsPanel.Name = "RentalsPanel";
            RentalsPanel.Size = new Size(673, 356);
            RentalsPanel.TabIndex = 6;
            //
            // ReturnDate_Label
            //
            ReturnDate_Label.AutoSize = true;
            ReturnDate_Label.Font = new Font("Segoe UI", 11F);
            ReturnDate_Label.Location = new Point(38, 694);
            ReturnDate_Label.Margin = new Padding(4, 0, 4, 0);
            ReturnDate_Label.Name = "ReturnDate_Label";
            ReturnDate_Label.Size = new Size(124, 30);
            ReturnDate_Label.TabIndex = 7;
            ReturnDate_Label.Text = "Return Date";
            //
            // ReturnDatePicker
            //
            ReturnDatePicker.BackColor = Color.Transparent;
            ReturnDatePicker.Checked = true;
            ReturnDatePicker.CustomizableEdges = customizableEdges3;
            ReturnDatePicker.FillColor = Color.White;
            ReturnDatePicker.Font = new Font("Segoe UI", 10F);
            ReturnDatePicker.Format = DateTimePickerFormat.Short;
            ReturnDatePicker.Location = new Point(38, 732);
            ReturnDatePicker.Margin = new Padding(4, 5, 4, 5);
            ReturnDatePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            ReturnDatePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            ReturnDatePicker.Name = "ReturnDatePicker";
            ReturnDatePicker.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ReturnDatePicker.Size = new Size(300, 56);
            ReturnDatePicker.TabIndex = 8;
            ReturnDatePicker.Value = new DateTime(2025, 11, 19, 0, 0, 0, 0);
            //
            // Notes_Label
            //
            Notes_Label.AutoSize = true;
            Notes_Label.Font = new Font("Segoe UI", 11F);
            Notes_Label.Location = new Point(38, 818);
            Notes_Label.Margin = new Padding(4, 0, 4, 0);
            Notes_Label.Name = "Notes_Label";
            Notes_Label.Size = new Size(232, 30);
            Notes_Label.TabIndex = 9;
            Notes_Label.Text = "Return Notes (optional)";
            //
            // NotesTextBox
            //
            NotesTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NotesTextBox.Cursor = Cursors.IBeam;
            NotesTextBox.CustomizableEdges = customizableEdges5;
            NotesTextBox.DefaultText = "";
            NotesTextBox.Font = new Font("Segoe UI", 10F);
            NotesTextBox.Location = new Point(38, 856);
            NotesTextBox.Margin = new Padding(5, 8, 5, 8);
            NotesTextBox.Multiline = true;
            NotesTextBox.Name = "NotesTextBox";
            NotesTextBox.PlaceholderText = "Enter any additional notes about the return...";
            NotesTextBox.SelectedText = "";
            NotesTextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            NotesTextBox.Size = new Size(673, 100);
            NotesTextBox.TabIndex = 10;
            //
            // Return_Button
            //
            Return_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Return_Button.CustomizableEdges = customizableEdges7;
            Return_Button.Font = new Font("Segoe UI", 11F);
            Return_Button.ForeColor = Color.White;
            Return_Button.Location = new Point(510, 991);
            Return_Button.Margin = new Padding(4, 5, 4, 5);
            Return_Button.Name = "Return_Button";
            Return_Button.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Return_Button.Size = new Size(200, 50);
            Return_Button.TabIndex = 11;
            Return_Button.Text = "Process Return";
            Return_Button.Click += Return_Button_Click;
            //
            // Cancel_Button
            //
            Cancel_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Cancel_Button.CustomizableEdges = customizableEdges9;
            Cancel_Button.Font = new Font("Segoe UI", 11F);
            Cancel_Button.ForeColor = Color.White;
            Cancel_Button.Location = new Point(302, 991);
            Cancel_Button.Margin = new Padding(4, 5, 4, 5);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.ShadowDecoration.CustomizableEdges = customizableEdges10;
            Cancel_Button.Size = new Size(200, 50);
            Cancel_Button.TabIndex = 12;
            Cancel_Button.Text = "Cancel";
            Cancel_Button.Click += Cancel_Button_Click;
            //
            // ReturnRental_Form
            //
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 1069);
            Controls.Add(Title_Label);
            Controls.Add(SelectCustomer_Label);
            Controls.Add(CustomerComboBox);
            Controls.Add(NoActiveRentals_Label);
            Controls.Add(ActiveRentals_Label);
            Controls.Add(SelectAllCheckBox);
            Controls.Add(RentalsPanel);
            Controls.Add(ReturnDate_Label);
            Controls.Add(ReturnDatePicker);
            Controls.Add(Notes_Label);
            Controls.Add(NotesTextBox);
            Controls.Add(Return_Button);
            Controls.Add(Cancel_Button);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(770, 1125);
            Name = "ReturnRental_Form";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Return Rental";
            Shown += ReturnRental_Form_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title_Label;
        private Label SelectCustomer_Label;
        private Guna.UI2.WinForms.Guna2ComboBox CustomerComboBox;
        private Label NoActiveRentals_Label;
        private Label ActiveRentals_Label;
        private CheckBox SelectAllCheckBox;
        private Panel RentalsPanel;
        private Label ReturnDate_Label;
        private Guna.UI2.WinForms.Guna2DateTimePicker ReturnDatePicker;
        private Label Notes_Label;
        private Guna.UI2.WinForms.Guna2TextBox NotesTextBox;
        private Guna.UI2.WinForms.Guna2Button Return_Button;
        private Guna.UI2.WinForms.Guna2Button Cancel_Button;
    }
}
