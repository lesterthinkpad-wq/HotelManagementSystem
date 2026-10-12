namespace HotelBookingManagementSystem.View
{
    partial class frmMain
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
            btnLogout = new Button();
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
            tbcMain = new Guna.UI2.WinForms.Guna2TabControl();
            tabDashboard = new TabPage();
            tabBookings = new TabPage();
            tabGuests = new TabPage();
            tabCheckout = new TabPage();
            tabReports = new TabPage();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookingsAccounts).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tbcMain.SuspendLayout();
            tabDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(47, 65, 86);
            btnLogout.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(245, 239, 235);
            btnLogout.Location = new Point(1329, 613);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(294, 54);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(47, 65, 86);
            panel2.Controls.Add(lblCurrentUser);
            panel2.Controls.Add(splitter1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1906, 113);
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
            dgvBookingsAccounts.Location = new Point(173, 395);
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
            lblRecentBookings.Location = new Point(173, 367);
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
            panel1.Location = new Point(175, 73);
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
            panel3.Location = new Point(636, 73);
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
            panel4.Location = new Point(1097, 73);
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
            // tbcMain
            // 
            tbcMain.Alignment = TabAlignment.Left;
            tbcMain.Controls.Add(tabDashboard);
            tbcMain.Controls.Add(tabBookings);
            tbcMain.Controls.Add(tabGuests);
            tbcMain.Controls.Add(tabCheckout);
            tbcMain.Controls.Add(tabReports);
            tbcMain.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbcMain.ItemSize = new Size(180, 50);
            tbcMain.Location = new Point(0, 114);
            tbcMain.Name = "tbcMain";
            tbcMain.SelectedIndex = 0;
            tbcMain.Size = new Size(1906, 923);
            tbcMain.TabButtonHoverState.BorderColor = Color.Empty;
            tbcMain.TabButtonHoverState.FillColor = Color.FromArgb(82, 107, 144);
            tbcMain.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            tbcMain.TabButtonHoverState.ForeColor = Color.White;
            tbcMain.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            tbcMain.TabButtonIdleState.BorderColor = Color.Empty;
            tbcMain.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            tbcMain.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            tbcMain.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            tbcMain.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            tbcMain.TabButtonSelectedState.BorderColor = Color.Empty;
            tbcMain.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            tbcMain.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            tbcMain.TabButtonSelectedState.ForeColor = Color.White;
            tbcMain.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            tbcMain.TabButtonSize = new Size(180, 50);
            tbcMain.TabIndex = 9;
            tbcMain.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            tbcMain.SelectedIndexChanged += tbcMain_SelectedIndexChanged;
            // 
            // tabDashboard
            // 
            tabDashboard.BackColor = Color.FromArgb(203, 217, 230);
            tabDashboard.Controls.Add(panel3);
            tabDashboard.Controls.Add(btnLogout);
            tabDashboard.Controls.Add(panel4);
            tabDashboard.Controls.Add(dgvBookingsAccounts);
            tabDashboard.Controls.Add(lblRecentBookings);
            tabDashboard.Controls.Add(panel1);
            tabDashboard.Location = new Point(184, 4);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(3);
            tabDashboard.Size = new Size(1718, 915);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            // 
            // tabBookings
            // 
            tabBookings.BackColor = Color.FromArgb(203, 217, 230);
            tabBookings.Location = new Point(184, 4);
            tabBookings.Name = "tabBookings";
            tabBookings.Padding = new Padding(3);
            tabBookings.Size = new Size(1718, 915);
            tabBookings.TabIndex = 1;
            tabBookings.Text = "Bookings";
            // 
            // tabGuests
            // 
            tabGuests.BackColor = Color.FromArgb(203, 217, 230);
            tabGuests.Location = new Point(184, 4);
            tabGuests.Name = "tabGuests";
            tabGuests.Size = new Size(1718, 915);
            tabGuests.TabIndex = 2;
            tabGuests.Text = "Guests";
            // 
            // tabCheckout
            // 
            tabCheckout.Location = new Point(184, 4);
            tabCheckout.Name = "tabCheckout";
            tabCheckout.Size = new Size(1718, 915);
            tabCheckout.TabIndex = 4;
            tabCheckout.Text = "Check out";
            tabCheckout.UseVisualStyleBackColor = true;
            // 
            // tabReports
            // 
            tabReports.Location = new Point(184, 4);
            tabReports.Name = "tabReports";
            tabReports.Size = new Size(1718, 915);
            tabReports.TabIndex = 3;
            tabReports.Text = "Reports";
            tabReports.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 217, 230);
            ClientSize = new Size(1906, 1037);
            Controls.Add(tbcMain);
            Controls.Add(panel2);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmMain_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookingsAccounts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tbcMain.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            tabDashboard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Splitter splitter1;
        private Label lblCurrentUser;
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
        private Guna.UI2.WinForms.Guna2TabControl tbcMain;
        private TabPage tabDashboard;
        private TabPage tabBookings;
        private TabPage tabGuests;
        private TabPage tabCheckout;
        private TabPage tabReports;
    }
}