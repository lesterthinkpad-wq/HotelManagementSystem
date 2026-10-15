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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            lblAppTitle = new Label();
            lblCurrentUser = new Label();
            btnLogout = new Button();
            tbcMain = new Guna.UI2.WinForms.Guna2TabControl();
            tabDashboard = new TabPage();
            dgvBookingsAccounts = new DataGridView();
            lblRecentBookings = new Label();
            tlpCards = new TableLayoutPanel();
            panel1 = new Panel();
            lblBookingNum = new Label();
            lblTotalBookings = new Label();
            panel3 = new Panel();
            lblPendingCheckins = new Label();
            lblPendings = new Label();
            panel4 = new Panel();
            lblAvailableRooms = new Label();
            label4 = new Label();
            tabBookings = new TabPage();
            tabGuests = new TabPage();
            tabCheckout = new TabPage();
            tabReports = new TabPage();
            panel2.SuspendLayout();
            tbcMain.SuspendLayout();
            tabDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookingsAccounts).BeginInit();
            tlpCards.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(47, 65, 86);
            panel2.Controls.Add(lblAppTitle);
            panel2.Controls.Add(lblCurrentUser);
            panel2.Controls.Add(btnLogout);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1280, 80);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.FromArgb(245, 239, 235);
            lblAppTitle.Location = new Point(24, 10);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(305, 30);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "Hotel Booking Management";
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblCurrentUser.ForeColor = Color.FromArgb(203, 217, 230);
            lblCurrentUser.Location = new Point(26, 46);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(91, 19);
            lblCurrentUser.TabIndex = 3;
            lblCurrentUser.Text = "Logged in as:";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.FromArgb(86, 124, 141);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(245, 239, 235);
            btnLogout.Location = new Point(1136, 20);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(120, 40);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // tbcMain
            // 
            tbcMain.Alignment = TabAlignment.Left;
            tbcMain.Controls.Add(tabDashboard);
            tbcMain.Controls.Add(tabBookings);
            tbcMain.Controls.Add(tabGuests);
            tbcMain.Controls.Add(tabCheckout);
            tbcMain.Controls.Add(tabReports);
            tbcMain.Dock = DockStyle.Fill;
            tbcMain.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbcMain.ItemSize = new Size(180, 50);
            tbcMain.Location = new Point(0, 80);
            tbcMain.Name = "tbcMain";
            tbcMain.SelectedIndex = 0;
            tbcMain.Size = new Size(1280, 669);
            tbcMain.TabButtonHoverState.BorderColor = Color.Empty;
            tbcMain.TabButtonHoverState.FillColor = Color.FromArgb(82, 107, 144);
            tbcMain.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10.5F);
            tbcMain.TabButtonHoverState.ForeColor = Color.White;
            tbcMain.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            tbcMain.TabButtonIdleState.BorderColor = Color.Empty;
            tbcMain.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            tbcMain.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10.5F);
            tbcMain.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            tbcMain.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            tbcMain.TabButtonSelectedState.BorderColor = Color.Empty;
            tbcMain.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            tbcMain.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10.5F);
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
            tabDashboard.Controls.Add(dgvBookingsAccounts);
            tabDashboard.Controls.Add(lblRecentBookings);
            tabDashboard.Controls.Add(tlpCards);
            tabDashboard.Location = new Point(184, 4);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(24);
            tabDashboard.Size = new Size(1092, 661);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            // 
            // dgvBookingsAccounts
            // 
            dgvBookingsAccounts.AllowUserToAddRows = false;
            dgvBookingsAccounts.AllowUserToDeleteRows = false;
            dgvBookingsAccounts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(232, 238, 244);
            dgvBookingsAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBookingsAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookingsAccounts.BackgroundColor = Color.White;
            dgvBookingsAccounts.BorderStyle = BorderStyle.None;
            dgvBookingsAccounts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBookingsAccounts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(47, 65, 86);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(245, 239, 235);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 65, 86);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(245, 239, 235);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBookingsAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBookingsAccounts.ColumnHeadersHeight = 42;
            dgvBookingsAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(47, 65, 86);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(86, 124, 141);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(245, 239, 235);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBookingsAccounts.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBookingsAccounts.Dock = DockStyle.Fill;
            dgvBookingsAccounts.EnableHeadersVisualStyles = false;
            dgvBookingsAccounts.GridColor = Color.FromArgb(203, 217, 230);
            dgvBookingsAccounts.Location = new Point(24, 214);
            dgvBookingsAccounts.MultiSelect = false;
            dgvBookingsAccounts.Name = "dgvBookingsAccounts";
            dgvBookingsAccounts.ReadOnly = true;
            dgvBookingsAccounts.RowHeadersVisible = false;
            dgvBookingsAccounts.RowHeadersWidth = 51;
            dgvBookingsAccounts.RowTemplate.Height = 36;
            dgvBookingsAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookingsAccounts.Size = new Size(1044, 423);
            dgvBookingsAccounts.TabIndex = 2;
            // 
            // lblRecentBookings
            // 
            lblRecentBookings.Dock = DockStyle.Top;
            lblRecentBookings.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRecentBookings.ForeColor = Color.FromArgb(47, 65, 86);
            lblRecentBookings.Location = new Point(24, 174);
            lblRecentBookings.Name = "lblRecentBookings";
            lblRecentBookings.Size = new Size(1044, 40);
            lblRecentBookings.TabIndex = 3;
            lblRecentBookings.Text = "Recent Bookings";
            lblRecentBookings.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpCards
            // 
            tlpCards.BackColor = Color.Transparent;
            tlpCards.ColumnCount = 3;
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpCards.Controls.Add(panel1, 0, 0);
            tlpCards.Controls.Add(panel3, 1, 0);
            tlpCards.Controls.Add(panel4, 2, 0);
            tlpCards.Dock = DockStyle.Top;
            tlpCards.Location = new Point(24, 24);
            tlpCards.Margin = new Padding(0);
            tlpCards.Name = "tlpCards";
            tlpCards.Padding = new Padding(0, 0, 0, 16);
            tlpCards.RowCount = 1;
            tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCards.Size = new Size(1044, 150);
            tlpCards.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(86, 124, 141);
            panel1.Controls.Add(lblBookingNum);
            panel1.Controls.Add(lblTotalBookings);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0, 0, 16, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 134);
            panel1.TabIndex = 4;
            // 
            // lblBookingNum
            // 
            lblBookingNum.AutoSize = true;
            lblBookingNum.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblBookingNum.ForeColor = Color.FromArgb(245, 239, 235);
            lblBookingNum.Location = new Point(18, 48);
            lblBookingNum.Name = "lblBookingNum";
            lblBookingNum.Size = new Size(56, 65);
            lblBookingNum.TabIndex = 1;
            lblBookingNum.Text = "0";
            // 
            // lblTotalBookings
            // 
            lblTotalBookings.AutoSize = true;
            lblTotalBookings.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTotalBookings.ForeColor = Color.FromArgb(203, 217, 230);
            lblTotalBookings.Location = new Point(20, 16);
            lblTotalBookings.Name = "lblTotalBookings";
            lblTotalBookings.Size = new Size(109, 20);
            lblTotalBookings.TabIndex = 0;
            lblTotalBookings.Text = "Total Bookings";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(86, 124, 141);
            panel3.Controls.Add(lblPendingCheckins);
            panel3.Controls.Add(lblPendings);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(348, 0);
            panel3.Margin = new Padding(0, 0, 16, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(332, 134);
            panel3.TabIndex = 5;
            // 
            // lblPendingCheckins
            // 
            lblPendingCheckins.AutoSize = true;
            lblPendingCheckins.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblPendingCheckins.ForeColor = Color.FromArgb(245, 239, 235);
            lblPendingCheckins.Location = new Point(18, 48);
            lblPendingCheckins.Name = "lblPendingCheckins";
            lblPendingCheckins.Size = new Size(56, 65);
            lblPendingCheckins.TabIndex = 1;
            lblPendingCheckins.Text = "0";
            // 
            // lblPendings
            // 
            lblPendings.AutoSize = true;
            lblPendings.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPendings.ForeColor = Color.FromArgb(203, 217, 230);
            lblPendings.Location = new Point(20, 16);
            lblPendings.Name = "lblPendings";
            lblPendings.Size = new Size(129, 20);
            lblPendings.TabIndex = 0;
            lblPendings.Text = "Pending Checkins";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(86, 124, 141);
            panel4.Controls.Add(lblAvailableRooms);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(696, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(348, 134);
            panel4.TabIndex = 6;
            // 
            // lblAvailableRooms
            // 
            lblAvailableRooms.AutoSize = true;
            lblAvailableRooms.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblAvailableRooms.ForeColor = Color.FromArgb(245, 239, 235);
            lblAvailableRooms.Location = new Point(18, 48);
            lblAvailableRooms.Name = "lblAvailableRooms";
            lblAvailableRooms.Size = new Size(56, 65);
            lblAvailableRooms.TabIndex = 1;
            lblAvailableRooms.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(203, 217, 230);
            label4.Location = new Point(20, 16);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 0;
            label4.Text = "Available Rooms";
            // 
            // tabBookings
            // 
            tabBookings.BackColor = Color.FromArgb(203, 217, 230);
            tabBookings.Location = new Point(184, 4);
            tabBookings.Name = "tabBookings";
            tabBookings.Padding = new Padding(3);
            tabBookings.Size = new Size(1092, 672);
            tabBookings.TabIndex = 1;
            tabBookings.Text = "Bookings";
            // 
            // tabGuests
            // 
            tabGuests.BackColor = Color.FromArgb(203, 217, 230);
            tabGuests.Location = new Point(184, 4);
            tabGuests.Name = "tabGuests";
            tabGuests.Size = new Size(1092, 661);
            tabGuests.TabIndex = 2;
            tabGuests.Text = "Guests";
            // 
            // tabCheckout
            // 
            tabCheckout.BackColor = Color.FromArgb(203, 217, 230);
            tabCheckout.Location = new Point(184, 4);
            tabCheckout.Name = "tabCheckout";
            tabCheckout.Size = new Size(1092, 672);
            tabCheckout.TabIndex = 4;
            tabCheckout.Text = "Check out";
            // 
            // tabReports
            // 
            tabReports.BackColor = Color.FromArgb(203, 217, 230);
            tabReports.Location = new Point(184, 4);
            tabReports.Name = "tabReports";
            tabReports.Size = new Size(1092, 672);
            tabReports.TabIndex = 3;
            tabReports.Text = "Reports";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 217, 230);
            ClientSize = new Size(1280, 749);
            Controls.Add(tbcMain);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1100, 680);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Booking Management System";
            Load += frmMain_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tbcMain.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBookingsAccounts).EndInit();
            tlpCards.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label lblAppTitle;
        private Label lblCurrentUser;
        private Button btnLogout;
        private DataGridView dgvBookingsAccounts;
        private Label lblRecentBookings;
        private TableLayoutPanel tlpCards;
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