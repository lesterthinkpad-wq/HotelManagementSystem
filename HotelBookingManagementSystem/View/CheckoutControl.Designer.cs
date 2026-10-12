namespace HotelBookingManagementSystem.View
{
    partial class CheckoutControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblCheckedIn = new Label();
            lblSearch = new Label();
            dgvCheckedIn = new DataGridView();
            pnlDetails = new Panel();
            lblDetailsTitle = new Label();
            lblRefCaption = new Label();
            lblRefValue = new Label();
            lblGuestCaption = new Label();
            lblGuestValue = new Label();
            lblPhoneCaption = new Label();
            lblPhoneValue = new Label();
            lblRoomCaption = new Label();
            lblRoomValue = new Label();
            lblCheckInCaption = new Label();
            lblCheckInValue = new Label();
            lblCheckOutCaption = new Label();
            lblCheckOutValue = new Label();
            lblNightsCaption = new Label();
            lblNightsValue = new Label();
            lblGuestsCaption = new Label();
            lblGuestsValue = new Label();
            lblTotalCaption = new Label();
            lblTotalValue = new Label();
            chkPaymentReceived = new CheckBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCheckedIn).BeginInit();
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(47, 65, 86);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1718, 90);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Monotype Corsiva", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(245, 239, 235);
            lblTitle.Location = new Point(23, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(147, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Check out";
            // 
            // lblCheckedIn
            // 
            lblCheckedIn.AutoSize = true;
            lblCheckedIn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            lblCheckedIn.ForeColor = Color.DimGray;
            lblCheckedIn.Location = new Point(165, 140);
            lblCheckedIn.Name = "lblCheckedIn";
            lblCheckedIn.Size = new Size(246, 29);
            lblCheckedIn.TabIndex = 1;
            lblCheckedIn.Text = "Guests to Check out";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblSearch.ForeColor = Color.DimGray;
            lblSearch.Location = new Point(165, 200);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 20);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search";
            // 
            // dgvCheckedIn
            // 
            dgvCheckedIn.AllowUserToAddRows = false;
            dgvCheckedIn.AllowUserToDeleteRows = false;
            dgvCheckedIn.AllowUserToResizeRows = false;
            dgvCheckedIn.BackgroundColor = Color.White;
            dgvCheckedIn.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCheckedIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCheckedIn.ColumnHeadersHeight = 34;
            dgvCheckedIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCheckedIn.EnableHeadersVisualStyles = false;
            dgvCheckedIn.GridColor = Color.FromArgb(203, 217, 230);
            dgvCheckedIn.Location = new Point(165, 248);
            dgvCheckedIn.MultiSelect = false;
            dgvCheckedIn.Name = "dgvCheckedIn";
            dgvCheckedIn.ReadOnly = true;
            dgvCheckedIn.RowHeadersVisible = false;
            dgvCheckedIn.RowHeadersWidth = 51;
            dgvCheckedIn.RowTemplate.Height = 30;
            dgvCheckedIn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCheckedIn.Size = new Size(920, 477);
            dgvCheckedIn.TabIndex = 5;
            // 
            // pnlDetails
            // 
            pnlDetails.BackColor = Color.FromArgb(245, 239, 235);
            pnlDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlDetails.Controls.Add(lblDetailsTitle);
            pnlDetails.Controls.Add(lblRefCaption);
            pnlDetails.Controls.Add(lblRefValue);
            pnlDetails.Controls.Add(lblGuestCaption);
            pnlDetails.Controls.Add(lblGuestValue);
            pnlDetails.Controls.Add(lblPhoneCaption);
            pnlDetails.Controls.Add(lblPhoneValue);
            pnlDetails.Controls.Add(lblRoomCaption);
            pnlDetails.Controls.Add(lblRoomValue);
            pnlDetails.Controls.Add(lblCheckInCaption);
            pnlDetails.Controls.Add(lblCheckInValue);
            pnlDetails.Controls.Add(lblCheckOutCaption);
            pnlDetails.Controls.Add(lblCheckOutValue);
            pnlDetails.Controls.Add(lblNightsCaption);
            pnlDetails.Controls.Add(lblNightsValue);
            pnlDetails.Controls.Add(lblGuestsCaption);
            pnlDetails.Controls.Add(lblGuestsValue);
            pnlDetails.Controls.Add(lblTotalCaption);
            pnlDetails.Controls.Add(lblTotalValue);
            pnlDetails.Controls.Add(chkPaymentReceived);
            pnlDetails.Location = new Point(1111, 248);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(426, 477);
            pnlDetails.TabIndex = 6;
            // 
            // lblDetailsTitle
            // 
            lblDetailsTitle.AutoSize = true;
            lblDetailsTitle.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            lblDetailsTitle.ForeColor = Color.FromArgb(47, 65, 86);
            lblDetailsTitle.Location = new Point(18, 16);
            lblDetailsTitle.Name = "lblDetailsTitle";
            lblDetailsTitle.Size = new Size(194, 29);
            lblDetailsTitle.TabIndex = 0;
            lblDetailsTitle.Text = "Booking details";
            // 
            // lblRefCaption
            // 
            lblRefCaption.AutoSize = true;
            lblRefCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblRefCaption.ForeColor = Color.DimGray;
            lblRefCaption.Location = new Point(18, 70);
            lblRefCaption.Name = "lblRefCaption";
            lblRefCaption.Size = new Size(95, 20);
            lblRefCaption.TabIndex = 1;
            lblRefCaption.Text = "Reference";
            // 
            // lblRefValue
            // 
            lblRefValue.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblRefValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblRefValue.Location = new Point(150, 68);
            lblRefValue.Name = "lblRefValue";
            lblRefValue.Size = new Size(218, 24);
            lblRefValue.TabIndex = 2;
            lblRefValue.Text = "-";
            // 
            // lblGuestCaption
            // 
            lblGuestCaption.AutoSize = true;
            lblGuestCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblGuestCaption.ForeColor = Color.DimGray;
            lblGuestCaption.Location = new Point(18, 106);
            lblGuestCaption.Name = "lblGuestCaption";
            lblGuestCaption.Size = new Size(59, 20);
            lblGuestCaption.TabIndex = 3;
            lblGuestCaption.Text = "Guest";
            // 
            // lblGuestValue
            // 
            lblGuestValue.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblGuestValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblGuestValue.Location = new Point(150, 104);
            lblGuestValue.Name = "lblGuestValue";
            lblGuestValue.Size = new Size(218, 24);
            lblGuestValue.TabIndex = 4;
            lblGuestValue.Text = "-";
            // 
            // lblPhoneCaption
            // 
            lblPhoneCaption.AutoSize = true;
            lblPhoneCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblPhoneCaption.ForeColor = Color.DimGray;
            lblPhoneCaption.Location = new Point(18, 142);
            lblPhoneCaption.Name = "lblPhoneCaption";
            lblPhoneCaption.Size = new Size(61, 20);
            lblPhoneCaption.TabIndex = 5;
            lblPhoneCaption.Text = "Phone";
            // 
            // lblPhoneValue
            // 
            lblPhoneValue.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblPhoneValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblPhoneValue.Location = new Point(150, 140);
            lblPhoneValue.Name = "lblPhoneValue";
            lblPhoneValue.Size = new Size(218, 24);
            lblPhoneValue.TabIndex = 6;
            lblPhoneValue.Text = "-";
            // 
            // lblRoomCaption
            // 
            lblRoomCaption.AutoSize = true;
            lblRoomCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblRoomCaption.ForeColor = Color.DimGray;
            lblRoomCaption.Location = new Point(18, 178);
            lblRoomCaption.Name = "lblRoomCaption";
            lblRoomCaption.Size = new Size(57, 20);
            lblRoomCaption.TabIndex = 7;
            lblRoomCaption.Text = "Room";
            // 
            // lblRoomValue
            // 
            lblRoomValue.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblRoomValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblRoomValue.Location = new Point(150, 176);
            lblRoomValue.Name = "lblRoomValue";
            lblRoomValue.Size = new Size(218, 24);
            lblRoomValue.TabIndex = 8;
            lblRoomValue.Text = "-";
            // 
            // lblCheckInCaption
            // 
            lblCheckInCaption.AutoSize = true;
            lblCheckInCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblCheckInCaption.ForeColor = Color.DimGray;
            lblCheckInCaption.Location = new Point(18, 214);
            lblCheckInCaption.Name = "lblCheckInCaption";
            lblCheckInCaption.Size = new Size(83, 20);
            lblCheckInCaption.TabIndex = 9;
            lblCheckInCaption.Text = "Check-in";
            // 
            // lblCheckInValue
            // 
            lblCheckInValue.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblCheckInValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblCheckInValue.Location = new Point(150, 212);
            lblCheckInValue.Name = "lblCheckInValue";
            lblCheckInValue.Size = new Size(218, 24);
            lblCheckInValue.TabIndex = 10;
            lblCheckInValue.Text = "-";
            // 
            // lblCheckOutCaption
            // 
            lblCheckOutCaption.AutoSize = true;
            lblCheckOutCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblCheckOutCaption.ForeColor = Color.DimGray;
            lblCheckOutCaption.Location = new Point(18, 250);
            lblCheckOutCaption.Name = "lblCheckOutCaption";
            lblCheckOutCaption.Size = new Size(94, 20);
            lblCheckOutCaption.TabIndex = 11;
            lblCheckOutCaption.Text = "Check-out";
            // 
            // lblCheckOutValue
            // 
            lblCheckOutValue.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblCheckOutValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblCheckOutValue.Location = new Point(150, 248);
            lblCheckOutValue.Name = "lblCheckOutValue";
            lblCheckOutValue.Size = new Size(218, 24);
            lblCheckOutValue.TabIndex = 12;
            lblCheckOutValue.Text = "-";
            // 
            // lblNightsCaption
            // 
            lblNightsCaption.AutoSize = true;
            lblNightsCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblNightsCaption.ForeColor = Color.DimGray;
            lblNightsCaption.Location = new Point(18, 286);
            lblNightsCaption.Name = "lblNightsCaption";
            lblNightsCaption.Size = new Size(63, 20);
            lblNightsCaption.TabIndex = 13;
            lblNightsCaption.Text = "Nights";
            // 
            // lblNightsValue
            // 
            lblNightsValue.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblNightsValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblNightsValue.Location = new Point(150, 284);
            lblNightsValue.Name = "lblNightsValue";
            lblNightsValue.Size = new Size(218, 24);
            lblNightsValue.TabIndex = 14;
            lblNightsValue.Text = "-";
            // 
            // lblGuestsCaption
            // 
            lblGuestsCaption.AutoSize = true;
            lblGuestsCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblGuestsCaption.ForeColor = Color.DimGray;
            lblGuestsCaption.Location = new Point(18, 322);
            lblGuestsCaption.Name = "lblGuestsCaption";
            lblGuestsCaption.Size = new Size(121, 20);
            lblGuestsCaption.TabIndex = 15;
            lblGuestsCaption.Text = "No. of guests";
            // 
            // lblGuestsValue
            // 
            lblGuestsValue.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblGuestsValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblGuestsValue.Location = new Point(150, 320);
            lblGuestsValue.Name = "lblGuestsValue";
            lblGuestsValue.Size = new Size(218, 24);
            lblGuestsValue.TabIndex = 16;
            lblGuestsValue.Text = "-";
            // 
            // lblTotalCaption
            // 
            lblTotalCaption.AutoSize = true;
            lblTotalCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblTotalCaption.ForeColor = Color.DimGray;
            lblTotalCaption.Location = new Point(18, 358);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(118, 20);
            lblTotalCaption.TabIndex = 17;
            lblTotalCaption.Text = "Total amount";
            // 
            // lblTotalValue
            // 
            lblTotalValue.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblTotalValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblTotalValue.Location = new Point(150, 356);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(218, 24);
            lblTotalValue.TabIndex = 18;
            lblTotalValue.Text = "-";
            // 
            // chkPaymentReceived
            // 
            chkPaymentReceived.AutoSize = true;
            chkPaymentReceived.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            chkPaymentReceived.ForeColor = Color.FromArgb(47, 65, 86);
            chkPaymentReceived.Location = new Point(18, 416);
            chkPaymentReceived.Name = "chkPaymentReceived";
            chkPaymentReceived.Size = new Size(191, 26);
            chkPaymentReceived.TabIndex = 19;
            chkPaymentReceived.Text = "Payment received";
            chkPaymentReceived.UseVisualStyleBackColor = true;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 15;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(47, 65, 86);
            guna2Button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(1111, 737);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(210, 56);
            guna2Button1.TabIndex = 9;
            guna2Button1.Text = "Confirm check out";
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 15;
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(245, 239, 235);
            guna2Button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Location = new Point(1327, 737);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(210, 56);
            guna2Button2.TabIndex = 10;
            guna2Button2.Text = "Clear";
            // 
            // guna2Button3
            // 
            guna2Button3.BorderRadius = 15;
            guna2Button3.CustomizableEdges = customizableEdges5;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.FromArgb(245, 239, 235);
            guna2Button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            guna2Button3.ForeColor = Color.Black;
            guna2Button3.Location = new Point(573, 192);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button3.Size = new Size(111, 37);
            guna2Button3.TabIndex = 11;
            guna2Button3.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.BorderRadius = 10;
            txtSearch.CustomizableEdges = customizableEdges7;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F);
            txtSearch.ForeColor = Color.Black;
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(239, 188);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderForeColor = Color.Gray;
            txtSearch.PlaceholderText = "Guest name or booking reference";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSearch.Size = new Size(320, 45);
            txtSearch.TabIndex = 12;
            // 
            // CheckoutControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 217, 230);
            Controls.Add(txtSearch);
            Controls.Add(guna2Button3);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(pnlDetails);
            Controls.Add(dgvCheckedIn);
            Controls.Add(lblSearch);
            Controls.Add(lblCheckedIn);
            Controls.Add(pnlHeader);
            Name = "CheckoutControl";
            Size = new Size(1718, 915);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCheckedIn).EndInit();
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblCheckedIn;
        private Label lblSearch;
        private DataGridView dgvCheckedIn;
        private Panel pnlDetails;
        private Label lblDetailsTitle;
        private Label lblRefCaption;
        private Label lblRefValue;
        private Label lblGuestCaption;
        private Label lblGuestValue;
        private Label lblPhoneCaption;
        private Label lblPhoneValue;
        private Label lblRoomCaption;
        private Label lblRoomValue;
        private Label lblCheckInCaption;
        private Label lblCheckInValue;
        private Label lblCheckOutCaption;
        private Label lblCheckOutValue;
        private Label lblNightsCaption;
        private Label lblNightsValue;
        private Label lblGuestsCaption;
        private Label lblGuestsValue;
        private Label lblTotalCaption;
        private Label lblTotalValue;
        private CheckBox chkPaymentReceived;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}
