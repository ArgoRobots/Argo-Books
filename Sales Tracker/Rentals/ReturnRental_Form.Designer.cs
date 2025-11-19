using Guna.UI2.WinForms;

namespace Sales_Tracker.Rentals
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
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.MainPanel = new Guna2Panel();
            this.NotesTextBox = new Guna2TextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.SelectAllCheckBox = new System.Windows.Forms.CheckBox();
            this.CancelButton = new Guna2Button();
            this.ReturnButton = new Guna2Button();
            this.ReturnDatePicker = new Guna2DateTimePicker();
            this.ReturnDateLabel = new System.Windows.Forms.Label();
            this.RentalsPanel = new System.Windows.Forms.Panel();
            this.ActiveRentalsLabel = new System.Windows.Forms.Label();
            this.CustomerComboBox = new Guna2ComboBox();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // MainPanel
            //
            this.MainPanel.Controls.Add(this.NotesTextBox);
            this.MainPanel.Controls.Add(this.NotesLabel);
            this.MainPanel.Controls.Add(this.SelectAllCheckBox);
            this.MainPanel.Controls.Add(this.CancelButton);
            this.MainPanel.Controls.Add(this.ReturnButton);
            this.MainPanel.Controls.Add(this.ReturnDatePicker);
            this.MainPanel.Controls.Add(this.ReturnDateLabel);
            this.MainPanel.Controls.Add(this.RentalsPanel);
            this.MainPanel.Controls.Add(this.ActiveRentalsLabel);
            this.MainPanel.Controls.Add(this.CustomerComboBox);
            this.MainPanel.Controls.Add(this.CustomerLabel);
            this.MainPanel.Controls.Add(this.TitleLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 700);
            this.MainPanel.TabIndex = 0;
            //
            // NotesTextBox
            //
            this.NotesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NotesTextBox.DefaultText = "";
            this.NotesTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NotesTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NotesTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NotesTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NotesTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NotesTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NotesTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NotesTextBox.Location = new System.Drawing.Point(30, 543);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.PasswordChar = '\0';
            this.NotesTextBox.PlaceholderText = "Optional return notes...";
            this.NotesTextBox.SelectedText = "";
            this.NotesTextBox.Size = new System.Drawing.Size(740, 80);
            this.NotesTextBox.TabIndex = 11;
            //
            // NotesLabel
            //
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.NotesLabel.Location = new System.Drawing.Point(30, 520);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(97, 19);
            this.NotesLabel.TabIndex = 10;
            this.NotesLabel.Text = "Return Notes:";
            //
            // SelectAllCheckBox
            //
            this.SelectAllCheckBox.AutoSize = true;
            this.SelectAllCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SelectAllCheckBox.Location = new System.Drawing.Point(30, 135);
            this.SelectAllCheckBox.Name = "SelectAllCheckBox";
            this.SelectAllCheckBox.Size = new System.Drawing.Size(76, 19);
            this.SelectAllCheckBox.TabIndex = 9;
            this.SelectAllCheckBox.Text = "Select All";
            this.SelectAllCheckBox.UseVisualStyleBackColor = true;
            this.SelectAllCheckBox.CheckedChanged += new System.EventHandler(this.SelectAllCheckBox_CheckedChanged);
            //
            // CancelButton
            //
            this.CancelButton.BorderRadius = 5;
            this.CancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(420, 640);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(170, 45);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            //
            // ReturnButton
            //
            this.ReturnButton.BorderRadius = 5;
            this.ReturnButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReturnButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReturnButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReturnButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReturnButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.ReturnButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ReturnButton.ForeColor = System.Drawing.Color.White;
            this.ReturnButton.Location = new System.Drawing.Point(600, 640);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(170, 45);
            this.ReturnButton.TabIndex = 7;
            this.ReturnButton.Text = "Process Return";
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            //
            // ReturnDatePicker
            //
            this.ReturnDatePicker.Checked = true;
            this.ReturnDatePicker.FillColor = System.Drawing.Color.White;
            this.ReturnDatePicker.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ReturnDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDatePicker.Location = new System.Drawing.Point(30, 480);
            this.ReturnDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ReturnDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ReturnDatePicker.Name = "ReturnDatePicker";
            this.ReturnDatePicker.Size = new System.Drawing.Size(300, 36);
            this.ReturnDatePicker.TabIndex = 6;
            this.ReturnDatePicker.Value = new System.DateTime(2025, 11, 19, 0, 0, 0, 0);
            //
            // ReturnDateLabel
            //
            this.ReturnDateLabel.AutoSize = true;
            this.ReturnDateLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ReturnDateLabel.Location = new System.Drawing.Point(30, 457);
            this.ReturnDateLabel.Name = "ReturnDateLabel";
            this.ReturnDateLabel.Size = new System.Drawing.Size(95, 19);
            this.ReturnDateLabel.TabIndex = 5;
            this.ReturnDateLabel.Text = "Return Date:";
            //
            // RentalsPanel
            //
            this.RentalsPanel.AutoScroll = true;
            this.RentalsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RentalsPanel.Location = new System.Drawing.Point(30, 160);
            this.RentalsPanel.Name = "RentalsPanel";
            this.RentalsPanel.Size = new System.Drawing.Size(740, 285);
            this.RentalsPanel.TabIndex = 4;
            //
            // ActiveRentalsLabel
            //
            this.ActiveRentalsLabel.AutoSize = true;
            this.ActiveRentalsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ActiveRentalsLabel.Location = new System.Drawing.Point(30, 113);
            this.ActiveRentalsLabel.Name = "ActiveRentalsLabel";
            this.ActiveRentalsLabel.Size = new System.Drawing.Size(109, 19);
            this.ActiveRentalsLabel.TabIndex = 3;
            this.ActiveRentalsLabel.Text = "Active Rentals:";
            //
            // CustomerComboBox
            //
            this.CustomerComboBox.BackColor = System.Drawing.Color.Transparent;
            this.CustomerComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CustomerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CustomerComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CustomerComboBox.ItemHeight = 30;
            this.CustomerComboBox.Location = new System.Drawing.Point(30, 70);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(740, 36);
            this.CustomerComboBox.TabIndex = 2;
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            //
            // CustomerLabel
            //
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CustomerLabel.Location = new System.Drawing.Point(30, 47);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(78, 19);
            this.CustomerLabel.TabIndex = 1;
            this.CustomerLabel.Text = "Customer:";
            //
            // TitleLabel
            //
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(290, 15);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(220, 25);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Return Rental Item(s)";
            //
            // ReturnRental_Form
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnRental_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Return Rental";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna2Panel MainPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CustomerLabel;
        private Guna2ComboBox CustomerComboBox;
        private System.Windows.Forms.Label ActiveRentalsLabel;
        private System.Windows.Forms.Panel RentalsPanel;
        private System.Windows.Forms.Label ReturnDateLabel;
        private Guna2DateTimePicker ReturnDatePicker;
        private Guna2Button ReturnButton;
        private Guna2Button CancelButton;
        private System.Windows.Forms.CheckBox SelectAllCheckBox;
        private System.Windows.Forms.Label NotesLabel;
        private Guna2TextBox NotesTextBox;
    }
}
