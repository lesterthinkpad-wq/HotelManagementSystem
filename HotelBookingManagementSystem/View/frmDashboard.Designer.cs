namespace HotelBookingManagementSystem.View
{
    partial class frmDashboard
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
            pnlSide = new Panel();
            btnLogout = new Button();
            btnReports = new Button();
            btnStaffAccount = new Button();
            btnRooms = new Button();
            btnGuests = new Button();
            btnBookings = new Button();
            lblDashboard = new Label();
            lblTitle = new Label();
            panel2 = new Panel();
            lblCurrentUser = new Label();
            splitter1 = new Splitter();
            dgvBookingsAccounts = new DataGridView();
            lblRecentBookings = new Label();
            panel1 = new Panel();
            lblBookingNum = new Label();
            lblTotalBookings = new Label();
            panel3 = new Panel();
            lblPendingCheckins = new Label();
            lblPendings = new Label();
            panel4 = new Panel();
            lblAvailableRooms = new Label();
            label4 = new Label();
            pnlSide.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookingsAccounts).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSide
            // 
            pnlSide.BackColor = Color.FromArgb(47, 65, 86);
            pnlSide.Controls.Add(btnLogout);
            pnlSide.Controls.Add(btnReports);
            pnlSide.Controls.Add(btnStaffAccount);
            pnlSide.Controls.Add(btnRooms);
            pnlSide.Controls.Add(btnGuests);
            pnlSide.Controls.Add(btnBookings);
            pnlSide.Controls.Add(lblDashboard);
            pnlSide.Controls.Add(lblTitle);
            pnlSide.Dock = DockStyle.Left;
            pnlSide.Location = new Point(0, 0);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(378, 1037);
            pnlSide.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(47, 65, 86);
            btnLogout.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(245, 239, 235);
            btnLogout.Location = new Point(38, 946);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(294, 54);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(245, 239, 235);
            btnReports.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnReports.Location = new Point(38, 494);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(294, 54);
            btnReports.TabIndex = 7;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnStaffAccount
            // 
            btnStaffAccount.BackColor = Color.FromArgb(245, 239, 235);
            btnStaffAccount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnStaffAccount.Location = new Point(38, 415);
            btnStaffAccount.Name = "btnStaffAccount";
            btnStaffAccount.Size = new Size(294, 54);
            btnStaffAccount.TabIndex = 6;
            btnStaffAccount.Text = "Staff Accounts";
            btnStaffAccount.UseVisualStyleBackColor = false;
            // 
            // btnRooms
            // 
            btnRooms.BackColor = Color.FromArgb(245, 239, 235);
            btnRooms.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnRooms.Location = new Point(38, 341);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(294, 54);
            btnRooms.TabIndex = 5;
            btnRooms.Text = "Rooms";
            btnRooms.UseVisualStyleBackColor = false;
            // 
            // btnGuests
            // 
            btnGuests.BackColor = Color.FromArgb(245, 239, 235);
            btnGuests.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnGuests.Location = new Point(38, 263);
            btnGuests.Name = "btnGuests";
            btnGuests.Size = new Size(294, 54);
            btnGuests.TabIndex = 4;
            btnGuests.Text = "Guests";
            btnGuests.UseVisualStyleBackColor = false;
            // 
            // btnBookings
            // 
            btnBookings.BackColor = Color.FromArgb(245, 239, 235);
            btnBookings.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnBookings.Location = new Point(38, 189);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(294, 54);
            btnBookings.TabIndex = 3;
            btnBookings.Text = "Bookings";
            btnBookings.UseVisualStyleBackColor = false;
            btnBookings.Click += btnBookings_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Monotype Corsiva", 16.2F, FontStyle.Bold | FontStyle.Italic);
            lblDashboard.ForeColor = Color.FromArgb(245, 239, 235);
            lblDashboard.Location = new Point(83, 79);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(132, 34);
            lblDashboard.TabIndex = 2;
            lblDashboard.Text = "Dashboard";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Monotype Corsiva", 25.8000011F, FontStyle.Bold | FontStyle.Italic);
            lblTitle.ForeColor = Color.FromArgb(245, 239, 235);
            lblTitle.Location = new Point(38, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(294, 53);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Hotel California";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(47, 65, 86);
            panel2.Controls.Add(lblCurrentUser);
            panel2.Controls.Add(splitter1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(378, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1528, 113);
            panel2.TabIndex = 1;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Font = new Font("Monotype Corsiva", 16.2F, FontStyle.Bold | FontStyle.Italic);
            lblCurrentUser.ForeColor = Color.FromArgb(245, 239, 235);
            lblCurrentUser.Location = new Point(32, 40);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(159, 34);
            lblCurrentUser.TabIndex = 3;
            lblCurrentUser.Text = "Logged in as:";
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.FromArgb(203, 217, 230);
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1, 113);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // dgvBookingsAccounts
            // 
            dgvBookingsAccounts.AllowUserToAddRows = false;
            dgvBookingsAccounts.AllowUserToDeleteRows = false;
            dgvBookingsAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookingsAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookingsAccounts.Location = new Point(488, 562);
            dgvBookingsAccounts.Name = "dgvBookingsAccounts";
            dgvBookingsAccounts.ReadOnly = true;
            dgvBookingsAccounts.RowHeadersWidth = 51;
            dgvBookingsAccounts.Size = new Size(975, 398);
            dgvBookingsAccounts.TabIndex = 2;
            // 
            // lblRecentBookings
            // 
            lblRecentBookings.AutoSize = true;
            lblRecentBookings.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblRecentBookings.ForeColor = Color.DimGray;
            lblRecentBookings.Location = new Point(488, 534);
            lblRecentBookings.Name = "lblRecentBookings";
            lblRecentBookings.Size = new Size(146, 22);
            lblRecentBookings.TabIndex = 3;
            lblRecentBookings.Text = "Recent Bookings";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(86, 124, 141);
            panel1.Controls.Add(lblBookingNum);
            panel1.Controls.Add(lblTotalBookings);
            panel1.Location = new Point(488, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 203);
            panel1.TabIndex = 4;
            // 
            // lblBookingNum
            // 
            lblBookingNum.AutoSize = true;
            lblBookingNum.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            lblBookingNum.ForeColor = Color.FromArgb(245, 239, 235);
            lblBookingNum.Location = new Point(17, 90);
            lblBookingNum.Name = "lblBookingNum";
            lblBookingNum.Size = new Size(64, 69);
            lblBookingNum.TabIndex = 1;
            lblBookingNum.Text = "0";
            // 
            // lblTotalBookings
            // 
            lblTotalBookings.AutoSize = true;
            lblTotalBookings.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblTotalBookings.ForeColor = Color.FromArgb(245, 239, 235);
            lblTotalBookings.Location = new Point(12, 14);
            lblTotalBookings.Name = "lblTotalBookings";
            lblTotalBookings.Size = new Size(156, 25);
            lblTotalBookings.TabIndex = 0;
            lblTotalBookings.Text = "Total Bookings";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(86, 124, 141);
            panel3.Controls.Add(lblPendingCheckins);
            panel3.Controls.Add(lblPendings);
            panel3.Location = new Point(949, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 203);
            panel3.TabIndex = 5;
            // 
            // lblPendingCheckins
            // 
            lblPendingCheckins.AutoSize = true;
            lblPendingCheckins.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            lblPendingCheckins.ForeColor = Color.FromArgb(245, 239, 235);
            lblPendingCheckins.Location = new Point(17, 90);
            lblPendingCheckins.Name = "lblPendingCheckins";
            lblPendingCheckins.Size = new Size(64, 69);
            lblPendingCheckins.TabIndex = 1;
            lblPendingCheckins.Text = "0";
            // 
            // lblPendings
            // 
            lblPendings.AutoSize = true;
            lblPendings.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblPendings.ForeColor = Color.FromArgb(245, 239, 235);
            lblPendings.Location = new Point(12, 14);
            lblPendings.Name = "lblPendings";
            lblPendings.Size = new Size(187, 25);
            lblPendings.TabIndex = 0;
            lblPendings.Text = "Pending Checkins";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(86, 124, 141);
            panel4.Controls.Add(lblAvailableRooms);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(1410, 190);
            panel4.Name = "panel4";
            panel4.Size = new Size(267, 203);
            panel4.TabIndex = 6;
            // 
            // lblAvailableRooms
            // 
            lblAvailableRooms.AutoSize = true;
            lblAvailableRooms.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            lblAvailableRooms.ForeColor = Color.FromArgb(245, 239, 235);
            lblAvailableRooms.Location = new Point(17, 90);
            lblAvailableRooms.Name = "lblAvailableRooms";
            lblAvailableRooms.Size = new Size(64, 69);
            lblAvailableRooms.TabIndex = 1;
            lblAvailableRooms.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(245, 239, 235);
            label4.Location = new Point(12, 14);
            label4.Name = "label4";
            label4.Size = new Size(173, 25);
            label4.TabIndex = 0;
            label4.Text = "Available Rooms";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 217, 230);
            ClientSize = new Size(1906, 1037);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(lblRecentBookings);
            Controls.Add(dgvBookingsAccounts);
            Controls.Add(panel2);
            Controls.Add(pnlSide);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDashboard";
            Load += frmDashboard_Load;
            pnlSide.ResumeLayout(false);
            pnlSide.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookingsAccounts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSide;
        private Panel panel2;
        private Splitter splitter1;
        private Label lblTitle;
        private Label lblDashboard;
        private Label lblCurrentUser;
        private Button btnBookings;
        private Button btnReports;
        private Button btnStaffAccount;
        private Button btnRooms;
        private Button btnGuests;
        private Button btnLogout;
        private DataGridView dgvBookingsAccounts;
        private Label lblRecentBookings;
        private Panel panel1;
        private Label lblTotalBookings;
        private Label lblBookingNum;
        private Panel panel3;
        private Label lblPendingCheckins;
        private Label lblPendings;
        private Panel panel4;
        private Label lblAvailableRooms;
        private Label label4;
    }
}