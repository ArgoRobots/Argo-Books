namespace Sales_Tracker.Rentals
{
    partial class CurrentRentals_Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Title_Label = new Label();
            FilterOverdue_Button = new Guna.UI2.WinForms.Guna2Button();
            Search_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            ShowingResultsFor_Label = new Label();
            Total_Label = new Label();
            SuspendLayout();
            //
            // Title_Label
            //
            Title_Label.AutoSize = true;
            Title_Label.Font = new Font("Segoe UI", 15.75F);
            Title_Label.Location = new Point(29, 33);
            Title_Label.Margin = new Padding(4, 0, 4, 0);
            Title_Label.Name = "Title_Label";
            Title_Label.Size = new Size(218, 45);
            Title_Label.TabIndex = 0;
            Title_Label.Text = "Current Rentals";
            //
            // FilterOverdue_Button
            //
            FilterOverdue_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FilterOverdue_Button.BorderRadius = 4;
            FilterOverdue_Button.CustomizableEdges = customizableEdges1;
            FilterOverdue_Button.Font = new Font("Segoe UI", 10F);
            FilterOverdue_Button.ForeColor = Color.White;
            FilterOverdue_Button.Location = new Point(873, 33);
            FilterOverdue_Button.Margin = new Padding(4, 5, 4, 5);
            FilterOverdue_Button.Name = "FilterOverdue_Button";
            FilterOverdue_Button.ShadowDecoration.CustomizableEdges = customizableEdges2;
            FilterOverdue_Button.Size = new Size(250, 50);
            FilterOverdue_Button.TabIndex = 1;
            FilterOverdue_Button.Text = "Show Overdue Only";
            FilterOverdue_Button.Click += FilterOverdue_Button_Click;
            //
            // Search_TextBox
            //
            Search_TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Search_TextBox.CustomizableEdges = customizableEdges3;
            Search_TextBox.DefaultText = "";
            Search_TextBox.Font = new Font("Segoe UI", 9F);
            Search_TextBox.IconRight = Properties.Resources.CloseGray;
            Search_TextBox.IconRightOffset = new Point(5, 0);
            Search_TextBox.IconRightSize = new Size(22, 22);
            Search_TextBox.Location = new Point(1133, 33);
            Search_TextBox.Margin = new Padding(6, 8, 6, 8);
            Search_TextBox.MaxLength = 100;
            Search_TextBox.Name = "Search_TextBox";
            Search_TextBox.PlaceholderText = "Search current rentals";
            Search_TextBox.SelectedText = "";
            Search_TextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Search_TextBox.Size = new Size(300, 50);
            Search_TextBox.TabIndex = 2;
            Search_TextBox.IconRightClick += Search_TextBox_IconRightClick;
            Search_TextBox.TextChanged += Search_TextBox_TextChanged;
            //
            // ShowingResultsFor_Label
            //
            ShowingResultsFor_Label.Anchor = AnchorStyles.Top;
            ShowingResultsFor_Label.AutoSize = true;
            ShowingResultsFor_Label.Font = new Font("Segoe UI", 11.25F);
            ShowingResultsFor_Label.Location = new Point(633, 108);
            ShowingResultsFor_Label.Margin = new Padding(4, 0, 4, 0);
            ShowingResultsFor_Label.Name = "ShowingResultsFor_Label";
            ShowingResultsFor_Label.Size = new Size(209, 31);
            ShowingResultsFor_Label.TabIndex = 3;
            ShowingResultsFor_Label.Text = "Showing results for";
            ShowingResultsFor_Label.TextAlign = ContentAlignment.MiddleCenter;
            ShowingResultsFor_Label.Visible = false;
            //
            // Total_Label
            //
            Total_Label.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Total_Label.AutoSize = true;
            Total_Label.Font = new Font("Segoe UI", 11F);
            Total_Label.Location = new Point(1369, 705);
            Total_Label.Margin = new Padding(4, 0, 4, 0);
            Total_Label.Name = "Total_Label";
            Total_Label.Size = new Size(64, 30);
            Total_Label.TabIndex = 4;
            Total_Label.Text = "Total:";
            //
            // CurrentRentals_Form
            //
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1448, 744);
            Controls.Add(Total_Label);
            Controls.Add(ShowingResultsFor_Label);
            Controls.Add(Search_TextBox);
            Controls.Add(FilterOverdue_Button);
            Controls.Add(Title_Label);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1470, 600);
            Name = "CurrentRentals_Form";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += CurrentRentals_Form_FormClosed;
            Shown += CurrentRentals_Form_Shown;
            Resize += CurrentRentals_Form_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title_Label;
        private Guna.UI2.WinForms.Guna2Button FilterOverdue_Button;
        private Guna.UI2.WinForms.Guna2TextBox Search_TextBox;
        private Label ShowingResultsFor_Label;
        private Label Total_Label;
    }
}
