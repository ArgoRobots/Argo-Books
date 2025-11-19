using Sales_Tracker.UI;
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Title_Label = new Label();
            SelectCustomer_Label = new Label();
            Customer_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            NoActiveRentals_Label = new Label();
            ActiveRentals_Label = new Label();
            SelectAll_CheckBox = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            SelectAll_Label = new Label();
            ReturnDate_Label = new Label();
            ReturnDate_Picker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            Notes_Label = new Label();
            Notes_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
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
            // Customer_ComboBox
            //
            Customer_ComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Customer_ComboBox.BackColor = Color.Transparent;
            Customer_ComboBox.CustomizableEdges = customizableEdges1;
            Customer_ComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            Customer_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Customer_ComboBox.FocusedColor = Color.Empty;
            Customer_ComboBox.Font = new Font("Segoe UI", 10F);
            Customer_ComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            Customer_ComboBox.ItemHeight = 44;
            Customer_ComboBox.Location = new Point(38, 138);
            Customer_ComboBox.Margin = new Padding(4, 5, 4, 5);
            Customer_ComboBox.Name = "Customer_ComboBox";
            Customer_ComboBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Customer_ComboBox.Size = new Size(672, 50);
            Customer_ComboBox.TabIndex = 2;
            Customer_ComboBox.SelectedIndexChanged += Customer_ComboBox_SelectedIndexChanged;
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
            // SelectAll_CheckBox
            //
            SelectAll_CheckBox.Animated = true;
            SelectAll_CheckBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            SelectAll_CheckBox.CheckedState.BorderRadius = 2;
            SelectAll_CheckBox.CheckedState.BorderThickness = 0;
            SelectAll_CheckBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            SelectAll_CheckBox.CustomizableEdges = customizableEdges11;
            SelectAll_CheckBox.Location = new Point(58, 280);
            SelectAll_CheckBox.Margin = new Padding(4, 5, 4, 5);
            SelectAll_CheckBox.Name = "SelectAll_CheckBox";
            SelectAll_CheckBox.ShadowDecoration.CustomizableEdges = customizableEdges12;
            SelectAll_CheckBox.Size = new Size(20, 20);
            SelectAll_CheckBox.TabIndex = 5;
            SelectAll_CheckBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            SelectAll_CheckBox.UncheckedState.BorderRadius = 2;
            SelectAll_CheckBox.UncheckedState.BorderThickness = 0;
            SelectAll_CheckBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            SelectAll_CheckBox.CheckedChanged += SelectAll_CheckBox_CheckedChanged;
            //
            // SelectAll_Label
            //
            SelectAll_Label.AutoSize = true;
            SelectAll_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SelectAll_Label.Location = new Point(83, 275);
            SelectAll_Label.Margin = new Padding(4, 0, 4, 0);
            SelectAll_Label.Name = "SelectAll_Label";
            SelectAll_Label.Padding = new Padding(5);
            SelectAll_Label.Size = new Size(98, 35);
            SelectAll_Label.TabIndex = 13;
            SelectAll_Label.Text = "Select All";
            SelectAll_Label.Click += SelectAll_Label_Click;
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
            // ReturnDate_Picker
            //
            ReturnDate_Picker.BackColor = Color.Transparent;
            ReturnDate_Picker.Checked = true;
            ReturnDate_Picker.CustomizableEdges = customizableEdges3;
            ReturnDate_Picker.FillColor = Color.White;
            ReturnDate_Picker.Font = new Font("Segoe UI", 10F);
            ReturnDate_Picker.Format = DateTimePickerFormat.Short;
            ReturnDate_Picker.Location = new Point(38, 732);
            ReturnDate_Picker.Margin = new Padding(4, 5, 4, 5);
            ReturnDate_Picker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            ReturnDate_Picker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            ReturnDate_Picker.Name = "ReturnDate_Picker";
            ReturnDate_Picker.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ReturnDate_Picker.Size = new Size(300, 56);
            ReturnDate_Picker.TabIndex = 8;
            ReturnDate_Picker.Value = new DateTime(2025, 11, 19, 0, 0, 0, 0);
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
            // Notes_TextBox
            //
            Notes_TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Notes_TextBox.Cursor = Cursors.IBeam;
            Notes_TextBox.CustomizableEdges = customizableEdges5;
            Notes_TextBox.DefaultText = "";
            Notes_TextBox.Font = new Font("Segoe UI", 10F);
            Notes_TextBox.Location = new Point(38, 856);
            Notes_TextBox.Margin = new Padding(5, 8, 5, 8);
            Notes_TextBox.Multiline = true;
            Notes_TextBox.Name = "Notes_TextBox";
            Notes_TextBox.PlaceholderText = "Enter any additional notes about the return...";
            Notes_TextBox.SelectedText = "";
            Notes_TextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Notes_TextBox.Size = new Size(673, 100);
            Notes_TextBox.TabIndex = 10;
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
            Controls.Add(Customer_ComboBox);
            Controls.Add(NoActiveRentals_Label);
            Controls.Add(ActiveRentals_Label);
            Controls.Add(SelectAll_CheckBox);
            Controls.Add(SelectAll_Label);
            Controls.Add(ReturnDate_Label);
            Controls.Add(ReturnDate_Picker);
            Controls.Add(Notes_Label);
            Controls.Add(Notes_TextBox);
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
        private Guna.UI2.WinForms.Guna2ComboBox Customer_ComboBox;
        private Label NoActiveRentals_Label;
        private Label ActiveRentals_Label;
        private Guna.UI2.WinForms.Guna2CustomCheckBox SelectAll_CheckBox;
        private Label SelectAll_Label;
        private Label ReturnDate_Label;
        private Guna.UI2.WinForms.Guna2DateTimePicker ReturnDate_Picker;
        private Label Notes_Label;
        private Guna.UI2.WinForms.Guna2TextBox Notes_TextBox;
        private Guna.UI2.WinForms.Guna2Button Return_Button;
        private Guna.UI2.WinForms.Guna2Button Cancel_Button;
    }
}
