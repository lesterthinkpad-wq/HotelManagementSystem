namespace HotelBookingManagementSystem.View
{
    partial class BookingsControl
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

        #region Component Designer generated code

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel2 = new Panel();
            lblSubtitle = new Label();
            lblCurrentUser = new Label();
            panel1 = new Panel();
            btnCancel = new Button();
            btnConfirmBooking = new Guna.UI2.WinForms.Guna2Button();
            lblTotalAmount = new Label();
            label9 = new Label();
            label8 = new Label();
            tblContent = new TableLayoutPanel();
            pnlGuestCard = new Panel();
            txtGuestID = new TextBox();
            tblGuest = new TableLayoutPanel();
            label1 = new Label();
            lblLName = new Label();
            txtFName = new TextBox();
            txtLName = new TextBox();
            lblEmail = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            pnlGuestDivider = new Panel();
            pnlGuestHeader = new Panel();
            btnSelectGuest = new Button();
            btnNewGuest = new Button();
            lblGuestTitle = new Label();
            pnlGuestAccent = new Panel();
            pnlStayCard = new Panel();
            tblStay = new TableLayoutPanel();
            lblDateBirth = new Label();
            label3 = new Label();
            label7 = new Label();
            dtpCheckinDate = new DateTimePicker();
            dtpCheckoutDate = new DateTimePicker();
            nudGuests = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            cboRoomType = new ComboBox();
            cboRoomNumber = new ComboBox();
            btnAddBooking = new Guna.UI2.WinForms.Guna2Button();
            pnlStayDivider = new Panel();
            label2 = new Label();
            pnlStayAccent = new Panel();
            pnlBookingsCard = new Panel();
            pnlGridHost = new Panel();
            dgvBookings = new DataGridView();
            RoomID = new DataGridViewTextBoxColumn();
            GuestID = new DataGridViewTextBoxColumn();
            CheckIn = new DataGridViewTextBoxColumn();
            CheckOut = new DataGridViewTextBoxColumn();
            RoomType = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            Guests = new DataGridViewTextBoxColumn();
            Nights = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            pnlBookingsDivider = new Panel();
            lblRecentBookings = new Label();
            pnlBookingsAccent = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tblContent.SuspendLayout();
            pnlGuestCard.SuspendLayout();
            tblGuest.SuspendLayout();
            pnlGuestHeader.SuspendLayout();
            pnlStayCard.SuspendLayout();
            tblStay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGuests).BeginInit();
            pnlBookingsCard.SuspendLayout();
            pnlGridHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(47, 65, 86);
            panel2.Controls.Add(lblSubtitle);
            panel2.Controls.Add(lblCurrentUser);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1718, 76);
            panel2.TabIndex = 44;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(203, 217, 230);
            lblSubtitle.Location = new Point(26, 46);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(355, 20);
            lblSubtitle.Size = new Size(284, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Select a guest, add rooms, then confirm the booking";
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentUser.ForeColor = Color.White;
            lblCurrentUser.Location = new Point(22, 8);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(202, 41);
            lblCurrentUser.Size = new Size(159, 32);
            lblCurrentUser.TabIndex = 0;
            lblCurrentUser.Text = "New booking";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnConfirmBooking);
            panel1.Controls.Add(lblTotalAmount);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 843);
            panel1.Name = "panel1";
            panel1.Size = new Size(1718, 72);
            panel1.TabIndex = 69;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(232, 190, 182);
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(250, 224, 219);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 238, 235);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(192, 57, 43);
            btnCancel.Location = new Point(1372, 14);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 44);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirmBooking
            // 
            btnConfirmBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfirmBooking.Animated = true;
            btnConfirmBooking.BorderRadius = 4;
            btnConfirmBooking.CustomizableEdges = customizableEdges1;
            btnConfirmBooking.DisabledState.BorderColor = Color.FromArgb(214, 222, 232);
            btnConfirmBooking.DisabledState.CustomBorderColor = Color.FromArgb(214, 222, 232);
            btnConfirmBooking.DisabledState.FillColor = Color.FromArgb(214, 222, 232);
            btnConfirmBooking.DisabledState.ForeColor = Color.FromArgb(140, 155, 175);
            btnConfirmBooking.Enabled = false;
            btnConfirmBooking.FillColor = Color.FromArgb(47, 65, 86);
            btnConfirmBooking.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmBooking.ForeColor = Color.White;
            btnConfirmBooking.HoverState.FillColor = Color.FromArgb(62, 82, 107);
            btnConfirmBooking.Location = new Point(1514, 14);
            btnConfirmBooking.Name = "btnConfirmBooking";
            btnConfirmBooking.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnConfirmBooking.Size = new Size(180, 44);
            btnConfirmBooking.TabIndex = 0;
            btnConfirmBooking.Text = "Confirm booking";
            btnConfirmBooking.Click += btnConfirmBooking_Click;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = Color.FromArgb(47, 65, 86);
            lblTotalAmount.Location = new Point(50, 28);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 41);
            lblTotalAmount.Size = new Size(0, 32);
            lblTotalAmount.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(47, 65, 86);
            label9.Location = new Point(21, 28);
            label9.Name = "label9";
            label9.Size = new Size(36, 41);
            label9.Size = new Size(29, 32);
            label9.TabIndex = 7;
            label9.Text = "₱";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(92, 108, 128);
            label8.Location = new Point(24, 10);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.Size = new Size(78, 15);
            label8.TabIndex = 5;
            label8.Text = "Total amount";
            // 
            // tblContent
            // 
            tblContent.ColumnCount = 2;
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            tblContent.Controls.Add(pnlGuestCard, 0, 0);
            tblContent.Controls.Add(pnlStayCard, 1, 0);
            tblContent.Controls.Add(pnlBookingsCard, 0, 1);
            tblContent.Dock = DockStyle.Fill;
            tblContent.Location = new Point(0, 76);
            tblContent.Name = "tblContent";
            tblContent.Padding = new Padding(24);
            tblContent.RowCount = 2;
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 232F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblContent.Size = new Size(1718, 767);
            tblContent.TabIndex = 0;
            // 
            // pnlGuestCard
            // 
            pnlGuestCard.BackColor = Color.White;
            pnlGuestCard.Controls.Add(txtGuestID);
            pnlGuestCard.Controls.Add(tblGuest);
            pnlGuestCard.Controls.Add(pnlGuestDivider);
            pnlGuestCard.Controls.Add(pnlGuestHeader);
            pnlGuestCard.Controls.Add(pnlGuestAccent);
            pnlGuestCard.Dock = DockStyle.Fill;
            pnlGuestCard.Location = new Point(24, 24);
            pnlGuestCard.Margin = new Padding(0, 0, 8, 16);
            pnlGuestCard.Name = "pnlGuestCard";
            pnlGuestCard.Size = new Size(693, 216);
            pnlGuestCard.TabIndex = 0;
            // 
            // txtGuestID
            // 
            txtGuestID.BackColor = Color.FromArgb(243, 246, 249);
            txtGuestID.BorderStyle = BorderStyle.FixedSingle;
            txtGuestID.Location = new Point(600, 70);
            txtGuestID.Name = "txtGuestID";
            txtGuestID.ReadOnly = true;
            txtGuestID.Size = new Size(80, 27);
            txtGuestID.Location = new Point(613, 70);
            txtGuestID.Name = "txtGuestID";
            txtGuestID.ReadOnly = true;
            txtGuestID.Size = new Size(67, 23);
            txtGuestID.TabIndex = 0;
            txtGuestID.TabStop = false;
            txtGuestID.Visible = false;
            // 
            // tblGuest
            // 
            tblGuest.ColumnCount = 2;
            tblGuest.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblGuest.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblGuest.Controls.Add(label1, 0, 0);
            tblGuest.Controls.Add(lblLName, 1, 0);
            tblGuest.Controls.Add(txtFName, 0, 1);
            tblGuest.Controls.Add(txtLName, 1, 1);
            tblGuest.Controls.Add(lblEmail, 0, 2);
            tblGuest.Controls.Add(label6, 1, 2);
            tblGuest.Controls.Add(txtEmail, 0, 3);
            tblGuest.Controls.Add(txtPhoneNumber, 1, 3);
            tblGuest.Dock = DockStyle.Fill;
            tblGuest.Location = new Point(0, 60);
            tblGuest.Name = "tblGuest";
            tblGuest.Padding = new Padding(20, 12, 20, 12);
            tblGuest.RowCount = 5;
            tblGuest.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tblGuest.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblGuest.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tblGuest.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblGuest.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblGuest.Size = new Size(693, 156);
            tblGuest.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(92, 108, 128);
            label1.Location = new Point(20, 12);
            label1.Margin = new Padding(0, 0, 0, 4);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.Location = new Point(20, 15);
            label1.Margin = new Padding(0, 0, 0, 4);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // lblLName
            // 
            lblLName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLName.ForeColor = Color.FromArgb(92, 108, 128);
            lblLName.Location = new Point(354, 12);
            lblLName.Margin = new Padding(8, 0, 0, 4);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(77, 18);
            lblLName.Location = new Point(354, 15);
            lblLName.Margin = new Padding(8, 0, 0, 4);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(61, 15);
            lblLName.TabIndex = 1;
            lblLName.Text = "Last name";
            // 
            // txtFName
            // 
            txtFName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFName.BackColor = Color.FromArgb(243, 246, 249);
            txtFName.BorderStyle = BorderStyle.FixedSingle;
            txtFName.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFName.ForeColor = Color.FromArgb(47, 65, 86);
            txtFName.Location = new Point(20, 34);
            txtFName.Margin = new Padding(0, 0, 8, 0);
            txtFName.Name = "txtFName";
            txtFName.ReadOnly = true;
            txtFName.Size = new Size(318, 31);
            txtFName.TabIndex = 2;
            txtFName.TabStop = false;
            // 
            // txtLName
            // 
            txtLName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLName.BackColor = Color.FromArgb(243, 246, 249);
            txtLName.BorderStyle = BorderStyle.FixedSingle;
            txtLName.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLName.ForeColor = Color.FromArgb(47, 65, 86);
            txtLName.Location = new Point(354, 34);
            txtLName.Margin = new Padding(8, 0, 0, 0);
            txtLName.Name = "txtLName";
            txtLName.ReadOnly = true;
            txtLName.Size = new Size(319, 31);
            txtLName.TabIndex = 3;
            txtLName.TabStop = false;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(92, 108, 128);
            lblEmail.Location = new Point(20, 74);
            lblEmail.Location = new Point(20, 77);
            lblEmail.Margin = new Padding(0, 0, 0, 4);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 18);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(92, 108, 128);
            label6.Location = new Point(354, 74);
            label6.Margin = new Padding(8, 0, 0, 4);
            label6.Name = "label6";
            label6.Size = new Size(111, 18);
            label6.Location = new Point(354, 77);
            label6.Margin = new Padding(8, 0, 0, 4);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 5;
            label6.Text = "Phone number";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.FromArgb(243, 246, 249);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(47, 65, 86);
            txtEmail.Location = new Point(20, 96);
            txtEmail.Margin = new Padding(0, 0, 8, 0);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(318, 31);
            txtEmail.TabIndex = 6;
            txtEmail.TabStop = false;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneNumber.BackColor = Color.FromArgb(243, 246, 249);
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.ForeColor = Color.FromArgb(47, 65, 86);
            txtPhoneNumber.Location = new Point(354, 96);
            txtPhoneNumber.Margin = new Padding(8, 0, 0, 0);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(319, 31);
            txtPhoneNumber.TabIndex = 7;
            txtPhoneNumber.TabStop = false;
            // 
            // pnlGuestDivider
            // 
            pnlGuestDivider.BackColor = Color.FromArgb(228, 234, 241);
            pnlGuestDivider.Dock = DockStyle.Top;
            pnlGuestDivider.Location = new Point(0, 59);
            pnlGuestDivider.Name = "pnlGuestDivider";
            pnlGuestDivider.Size = new Size(693, 1);
            pnlGuestDivider.TabIndex = 2;
            // 
            // pnlGuestHeader
            // 
            pnlGuestHeader.BackColor = Color.White;
            pnlGuestHeader.Controls.Add(btnSelectGuest);
            pnlGuestHeader.Controls.Add(btnNewGuest);
            pnlGuestHeader.Controls.Add(lblGuestTitle);
            pnlGuestHeader.Dock = DockStyle.Top;
            pnlGuestHeader.Location = new Point(0, 3);
            pnlGuestHeader.Name = "pnlGuestHeader";
            pnlGuestHeader.Size = new Size(693, 56);
            pnlGuestHeader.TabIndex = 3;
            // 
            // btnSelectGuest
            // 
            btnSelectGuest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectGuest.BackColor = Color.White;
            btnSelectGuest.Cursor = Cursors.Hand;
            btnSelectGuest.FlatAppearance.BorderColor = Color.FromArgb(203, 217, 230);
            btnSelectGuest.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 230, 240);
            btnSelectGuest.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 242, 247);
            btnSelectGuest.FlatStyle = FlatStyle.Flat;
            btnSelectGuest.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectGuest.ForeColor = Color.FromArgb(47, 65, 86);
            btnSelectGuest.Location = new Point(435, 12);
            btnSelectGuest.Name = "btnSelectGuest";
            btnSelectGuest.Size = new Size(120, 32);
            btnSelectGuest.TabIndex = 0;
            btnSelectGuest.Text = "Select guest";
            btnSelectGuest.UseVisualStyleBackColor = false;
            btnSelectGuest.Click += btnSelectGuest_Click;
            // 
            // btnNewGuest
            // 
            btnNewGuest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewGuest.BackColor = Color.FromArgb(47, 65, 86);
            btnNewGuest.Cursor = Cursors.Hand;
            btnNewGuest.FlatAppearance.BorderSize = 0;
            btnNewGuest.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 50, 68);
            btnNewGuest.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 82, 107);
            btnNewGuest.FlatStyle = FlatStyle.Flat;
            btnNewGuest.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewGuest.ForeColor = Color.White;
            btnNewGuest.Location = new Point(563, 12);
            btnNewGuest.Name = "btnNewGuest";
            btnNewGuest.Size = new Size(110, 32);
            btnNewGuest.TabIndex = 1;
            btnNewGuest.Text = "New guest";
            btnNewGuest.UseVisualStyleBackColor = false;
            // 
            // lblGuestTitle
            // 
            lblGuestTitle.AutoSize = true;
            lblGuestTitle.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuestTitle.ForeColor = Color.FromArgb(47, 65, 86);
            lblGuestTitle.Location = new Point(20, 14);
            lblGuestTitle.Name = "lblGuestTitle";
            lblGuestTitle.Size = new Size(68, 30);
            lblGuestTitle.Size = new Size(54, 23);
            lblGuestTitle.TabIndex = 0;
            lblGuestTitle.Text = "Guest";
            // 
            // pnlGuestAccent
            // 
            pnlGuestAccent.BackColor = Color.FromArgb(47, 65, 86);
            pnlGuestAccent.Dock = DockStyle.Top;
            pnlGuestAccent.Location = new Point(0, 0);
            pnlGuestAccent.Name = "pnlGuestAccent";
            pnlGuestAccent.Size = new Size(693, 3);
            pnlGuestAccent.TabIndex = 4;
            // 
            // pnlStayCard
            // 
            pnlStayCard.BackColor = Color.White;
            pnlStayCard.Controls.Add(tblStay);
            pnlStayCard.Controls.Add(pnlStayDivider);
            pnlStayCard.Controls.Add(label2);
            pnlStayCard.Controls.Add(pnlStayAccent);
            pnlStayCard.Dock = DockStyle.Fill;
            pnlStayCard.Location = new Point(733, 24);
            pnlStayCard.Margin = new Padding(8, 0, 0, 16);
            pnlStayCard.Name = "pnlStayCard";
            pnlStayCard.Size = new Size(961, 216);
            pnlStayCard.TabIndex = 1;
            // 
            // tblStay
            // 
            tblStay.ColumnCount = 3;
            tblStay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tblStay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tblStay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tblStay.Controls.Add(lblDateBirth, 0, 0);
            tblStay.Controls.Add(label3, 1, 0);
            tblStay.Controls.Add(label7, 2, 0);
            tblStay.Controls.Add(dtpCheckinDate, 0, 1);
            tblStay.Controls.Add(dtpCheckoutDate, 1, 1);
            tblStay.Controls.Add(nudGuests, 2, 1);
            tblStay.Controls.Add(label4, 0, 2);
            tblStay.Controls.Add(label5, 1, 2);
            tblStay.Controls.Add(cboRoomType, 0, 3);
            tblStay.Controls.Add(cboRoomNumber, 1, 3);
            tblStay.Controls.Add(btnAddBooking, 2, 3);
            tblStay.Dock = DockStyle.Fill;
            tblStay.Location = new Point(0, 60);
            tblStay.Name = "tblStay";
            tblStay.Padding = new Padding(20, 12, 20, 12);
            tblStay.RowCount = 5;
            tblStay.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tblStay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblStay.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tblStay.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblStay.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblStay.Size = new Size(961, 156);
            tblStay.TabIndex = 0;
            // 
            // lblDateBirth
            // 
            lblDateBirth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDateBirth.AutoSize = true;
            lblDateBirth.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateBirth.ForeColor = Color.FromArgb(92, 108, 128);
            lblDateBirth.Location = new Point(20, 12);
            lblDateBirth.Margin = new Padding(0, 0, 0, 4);
            lblDateBirth.Name = "lblDateBirth";
            lblDateBirth.Size = new Size(67, 18);
            lblDateBirth.Location = new Point(20, 15);
            lblDateBirth.Margin = new Padding(0, 0, 0, 4);
            lblDateBirth.Name = "lblDateBirth";
            lblDateBirth.Size = new Size(52, 15);
            lblDateBirth.TabIndex = 0;
            lblDateBirth.Text = "Check in";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(92, 108, 128);
            label3.Location = new Point(334, 12);
            label3.Margin = new Padding(8, 0, 0, 4);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.Location = new Point(334, 15);
            label3.Margin = new Padding(8, 0, 0, 4);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 1;
            label3.Text = "Check out";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(92, 108, 128);
            label7.Location = new Point(640, 12);
            label7.Margin = new Padding(8, 0, 0, 4);
            label7.Name = "label7";
            label7.Size = new Size(53, 18);
            label7.Location = new Point(640, 15);
            label7.Margin = new Padding(8, 0, 0, 4);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 2;
            label7.Text = "Guests";
            // 
            // dtpCheckinDate
            // 
            dtpCheckinDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpCheckinDate.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckinDate.CalendarTitleBackColor = Color.FromArgb(47, 65, 86);
            dtpCheckinDate.CalendarTitleForeColor = Color.White;
            dtpCheckinDate.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckinDate.Format = DateTimePickerFormat.Short;
            dtpCheckinDate.Location = new Point(20, 34);
            dtpCheckinDate.Margin = new Padding(0, 0, 8, 0);
            dtpCheckinDate.Name = "dtpCheckinDate";
            dtpCheckinDate.Size = new Size(298, 31);
            dtpCheckinDate.Size = new Size(298, 26);
            dtpCheckinDate.TabIndex = 3;
            dtpCheckinDate.ValueChanged += dtpCheckinDate_ValueChanged;
            // 
            // dtpCheckoutDate
            // 
            dtpCheckoutDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpCheckoutDate.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckoutDate.CalendarTitleBackColor = Color.FromArgb(47, 65, 86);
            dtpCheckoutDate.CalendarTitleForeColor = Color.White;
            dtpCheckoutDate.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckoutDate.Format = DateTimePickerFormat.Short;
            dtpCheckoutDate.Location = new Point(334, 34);
            dtpCheckoutDate.Margin = new Padding(8, 0, 8, 0);
            dtpCheckoutDate.Name = "dtpCheckoutDate";
            dtpCheckoutDate.Size = new Size(290, 31);
            dtpCheckoutDate.Size = new Size(290, 26);
            dtpCheckoutDate.TabIndex = 4;
            dtpCheckoutDate.ValueChanged += dtpCheckoutDate_ValueChanged;
            // 
            // nudGuests
            // 
            nudGuests.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudGuests.BackColor = Color.FromArgb(247, 249, 251);
            nudGuests.BorderStyle = BorderStyle.FixedSingle;
            nudGuests.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudGuests.ForeColor = Color.FromArgb(47, 65, 86);
            nudGuests.Location = new Point(640, 34);
            nudGuests.Margin = new Padding(8, 0, 0, 0);
            nudGuests.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudGuests.Name = "nudGuests";
            nudGuests.Size = new Size(301, 31);
            nudGuests.Size = new Size(301, 26);
            nudGuests.TabIndex = 5;
            nudGuests.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudGuests.ValueChanged += nudGuests_ValueChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(92, 108, 128);
            label4.Location = new Point(20, 74);
            label4.Margin = new Padding(0, 0, 0, 4);
            label4.Name = "label4";
            label4.Size = new Size(83, 18);
            label4.Location = new Point(20, 77);
            label4.Margin = new Padding(0, 0, 0, 4);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 6;
            label4.Text = "Room type";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(92, 108, 128);
            label5.Location = new Point(334, 74);
            label5.Margin = new Padding(8, 0, 0, 4);
            label5.Name = "label5";
            label5.Size = new Size(107, 18);
            label5.Location = new Point(334, 77);
            label5.Margin = new Padding(8, 0, 0, 4);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 7;
            label5.Text = "Room number";
            // 
            // cboRoomType
            // 
            cboRoomType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboRoomType.BackColor = Color.FromArgb(247, 249, 251);
            cboRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoomType.FlatStyle = FlatStyle.Flat;
            cboRoomType.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRoomType.ForeColor = Color.FromArgb(47, 65, 86);
            cboRoomType.FormattingEnabled = true;
            cboRoomType.Location = new Point(20, 96);
            cboRoomType.Margin = new Padding(0, 0, 8, 0);
            cboRoomType.Name = "cboRoomType";
            cboRoomType.Size = new Size(298, 31);
            cboRoomType.Size = new Size(298, 27);
            cboRoomType.TabIndex = 8;
            cboRoomType.SelectedIndexChanged += cboRoomType_SelectedIndexChanged;
            // 
            // cboRoomNumber
            // 
            cboRoomNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboRoomNumber.BackColor = Color.FromArgb(247, 249, 251);
            cboRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoomNumber.FlatStyle = FlatStyle.Flat;
            cboRoomNumber.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRoomNumber.ForeColor = Color.FromArgb(47, 65, 86);
            cboRoomNumber.FormattingEnabled = true;
            cboRoomNumber.Location = new Point(334, 96);
            cboRoomNumber.Margin = new Padding(8, 0, 8, 0);
            cboRoomNumber.Name = "cboRoomNumber";
            cboRoomNumber.Size = new Size(290, 31);
            cboRoomNumber.Size = new Size(290, 27);
            cboRoomNumber.TabIndex = 9;
            // 
            // btnAddBooking
            // 
            btnAddBooking.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAddBooking.Animated = true;
            btnAddBooking.BorderRadius = 4;
            btnAddBooking.CustomizableEdges = customizableEdges3;
            btnAddBooking.DisabledState.BorderColor = Color.FromArgb(214, 222, 232);
            btnAddBooking.DisabledState.CustomBorderColor = Color.FromArgb(214, 222, 232);
            btnAddBooking.DisabledState.FillColor = Color.FromArgb(214, 222, 232);
            btnAddBooking.DisabledState.ForeColor = Color.FromArgb(140, 155, 175);
            btnAddBooking.FillColor = Color.FromArgb(47, 65, 86);
            btnAddBooking.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddBooking.ForeColor = Color.White;
            btnAddBooking.HoverState.FillColor = Color.FromArgb(62, 82, 107);
            btnAddBooking.Location = new Point(640, 96);
            btnAddBooking.Margin = new Padding(8, 0, 0, 0);
            btnAddBooking.Name = "btnAddBooking";
            btnAddBooking.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAddBooking.Size = new Size(301, 30);
            btnAddBooking.TabIndex = 10;
            btnAddBooking.Text = "Add booking";
            btnAddBooking.Click += btnAddBooking_Click;
            // 
            // pnlStayDivider
            // 
            pnlStayDivider.BackColor = Color.FromArgb(228, 234, 241);
            pnlStayDivider.Dock = DockStyle.Top;
            pnlStayDivider.Location = new Point(0, 59);
            pnlStayDivider.Name = "pnlStayDivider";
            pnlStayDivider.Size = new Size(961, 1);
            pnlStayDivider.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(47, 65, 86);
            label2.Location = new Point(0, 3);
            label2.Name = "label2";
            label2.Padding = new Padding(20, 0, 0, 0);
            label2.Size = new Size(961, 56);
            label2.TabIndex = 2;
            label2.Text = "Stay details";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlStayAccent
            // 
            pnlStayAccent.BackColor = Color.FromArgb(47, 65, 86);
            pnlStayAccent.Dock = DockStyle.Top;
            pnlStayAccent.Location = new Point(0, 0);
            pnlStayAccent.Name = "pnlStayAccent";
            pnlStayAccent.Size = new Size(961, 3);
            pnlStayAccent.TabIndex = 3;
            // 
            // pnlBookingsCard
            // 
            pnlBookingsCard.BackColor = Color.White;
            tblContent.SetColumnSpan(pnlBookingsCard, 2);
            pnlBookingsCard.Controls.Add(pnlGridHost);
            pnlBookingsCard.Controls.Add(pnlBookingsDivider);
            pnlBookingsCard.Controls.Add(lblRecentBookings);
            pnlBookingsCard.Controls.Add(pnlBookingsAccent);
            pnlBookingsCard.Dock = DockStyle.Fill;
            pnlBookingsCard.Location = new Point(24, 256);
            pnlBookingsCard.Margin = new Padding(0);
            pnlBookingsCard.Name = "pnlBookingsCard";
            pnlBookingsCard.Size = new Size(1670, 487);
            pnlBookingsCard.TabIndex = 2;
            // 
            // pnlGridHost
            // 
            pnlGridHost.BackColor = Color.White;
            pnlGridHost.Controls.Add(dgvBookings);
            pnlGridHost.Dock = DockStyle.Fill;
            pnlGridHost.Location = new Point(0, 60);
            pnlGridHost.Name = "pnlGridHost";
            pnlGridHost.Padding = new Padding(16);
            pnlGridHost.Size = new Size(1670, 427);
            pnlGridHost.TabIndex = 0;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 251, 253);
            dgvBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.BackgroundColor = Color.White;
            dgvBookings.BorderStyle = BorderStyle.None;
            dgvBookings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(238, 243, 248);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(47, 65, 86);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(238, 243, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(47, 65, 86);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBookings.ColumnHeadersHeight = 40;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBookings.Columns.AddRange(new DataGridViewColumn[] { RoomID, GuestID, CheckIn, CheckOut, RoomType, RoomNumber, Guests, Nights, TotalAmount });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(47, 65, 86);
            dataGridViewCellStyle5.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(219, 230, 242);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(47, 65, 86);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvBookings.DefaultCellStyle = dataGridViewCellStyle5;
            dgvBookings.Dock = DockStyle.Fill;
            dgvBookings.EnableHeadersVisualStyles = false;
            dgvBookings.GridColor = Color.FromArgb(228, 234, 241);
            dgvBookings.Location = new Point(16, 16);
            dgvBookings.MultiSelect = false;
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersVisible = false;
            dgvBookings.RowHeadersWidth = 51;
            dgvBookings.RowTemplate.Height = 36;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(1638, 395);
            dgvBookings.TabIndex = 0;
            // 
            // RoomID
            // 
            RoomID.DataPropertyName = "RoomID";
            RoomID.HeaderText = "RoomID";
            RoomID.MinimumWidth = 6;
            RoomID.Name = "RoomID";
            RoomID.ReadOnly = true;
            RoomID.Visible = false;
            // 
            // GuestID
            // 
            GuestID.DataPropertyName = "GuestID";
            GuestID.HeaderText = "Guest ID";
            GuestID.MinimumWidth = 6;
            GuestID.Name = "GuestID";
            GuestID.ReadOnly = true;
            GuestID.Visible = false;
            // 
            // CheckIn
            // 
            CheckIn.DataPropertyName = "CheckIn";
            dataGridViewCellStyle3.Format = "MMM dd, yyyy";
            CheckIn.DefaultCellStyle = dataGridViewCellStyle3;
            CheckIn.HeaderText = "Check In";
            CheckIn.MinimumWidth = 6;
            CheckIn.Name = "CheckIn";
            CheckIn.ReadOnly = true;
            // 
            // CheckOut
            // 
            CheckOut.DataPropertyName = "CheckOut";
            CheckOut.DefaultCellStyle = dataGridViewCellStyle3;
            CheckOut.HeaderText = "Check Out";
            CheckOut.MinimumWidth = 6;
            CheckOut.Name = "CheckOut";
            CheckOut.ReadOnly = true;
            // 
            // RoomType
            // 
            RoomType.DataPropertyName = "RoomType";
            RoomType.HeaderText = "Room Type";
            RoomType.MinimumWidth = 6;
            RoomType.Name = "RoomType";
            RoomType.ReadOnly = true;
            // 
            // RoomNumber
            // 
            RoomNumber.DataPropertyName = "RoomNumber";
            RoomNumber.HeaderText = "Room Number";
            RoomNumber.MinimumWidth = 6;
            RoomNumber.Name = "RoomNumber";
            RoomNumber.ReadOnly = true;
            // 
            // Guests
            // 
            Guests.DataPropertyName = "Guests";
            Guests.FillWeight = 60F;
            Guests.HeaderText = "Guests";
            Guests.MinimumWidth = 6;
            Guests.Name = "Guests";
            Guests.ReadOnly = true;
            // 
            // Nights
            // 
            Nights.DataPropertyName = "Nights";
            Nights.FillWeight = 60F;
            Nights.HeaderText = "Nights";
            Nights.MinimumWidth = 6;
            Nights.Name = "Nights";
            Nights.ReadOnly = true;
            // 
            // TotalAmount
            // 
            TotalAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            TotalAmount.DefaultCellStyle = dataGridViewCellStyle4;
            TotalAmount.HeaderText = "Total";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            // 
            // pnlBookingsDivider
            // 
            pnlBookingsDivider.BackColor = Color.FromArgb(228, 234, 241);
            pnlBookingsDivider.Dock = DockStyle.Top;
            pnlBookingsDivider.Location = new Point(0, 59);
            pnlBookingsDivider.Name = "pnlBookingsDivider";
            pnlBookingsDivider.Size = new Size(1670, 1);
            pnlBookingsDivider.TabIndex = 1;
            // 
            // lblRecentBookings
            // 
            lblRecentBookings.Dock = DockStyle.Top;
            lblRecentBookings.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentBookings.ForeColor = Color.FromArgb(47, 65, 86);
            lblRecentBookings.Location = new Point(0, 3);
            lblRecentBookings.Name = "lblRecentBookings";
            lblRecentBookings.Padding = new Padding(20, 0, 0, 0);
            lblRecentBookings.Size = new Size(1670, 56);
            lblRecentBookings.TabIndex = 2;
            lblRecentBookings.Text = "Recent Bookings";
            lblRecentBookings.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlBookingsAccent
            // 
            pnlBookingsAccent.BackColor = Color.FromArgb(47, 65, 86);
            pnlBookingsAccent.Dock = DockStyle.Top;
            pnlBookingsAccent.Location = new Point(0, 0);
            pnlBookingsAccent.Name = "pnlBookingsAccent";
            pnlBookingsAccent.Size = new Size(1670, 3);
            pnlBookingsAccent.TabIndex = 3;
            // 
            // BookingsControl
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(238, 242, 246);
            Controls.Add(tblContent);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "BookingsControl";
            Size = new Size(1718, 915);
            Load += BookingsControl_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tblContent.ResumeLayout(false);
            pnlGuestCard.ResumeLayout(false);
            pnlGuestCard.PerformLayout();
            tblGuest.ResumeLayout(false);
            tblGuest.PerformLayout();
            pnlGuestHeader.ResumeLayout(false);
            pnlGuestHeader.PerformLayout();
            pnlStayCard.ResumeLayout(false);
            tblStay.ResumeLayout(false);
            tblStay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGuests).EndInit();
            pnlBookingsCard.ResumeLayout(false);
            pnlGridHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblCurrentUser;
        private Label lblSubtitle;
        private Panel panel1;
        private Label label8;
        private Label label9;
        private Label lblTotalAmount;
        private Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnConfirmBooking;
        private TableLayoutPanel tblContent;
        private Panel pnlGuestCard;
        private Panel pnlGuestAccent;
        private Panel pnlGuestHeader;
        private Panel pnlGuestDivider;
        private Label lblGuestTitle;
        private Button btnSelectGuest;
        private Button btnNewGuest;
        private TextBox txtGuestID;
        private TableLayoutPanel tblGuest;
        private Label label1;
        private TextBox txtFName;
        private Label lblLName;
        private TextBox txtLName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtPhoneNumber;
        private Panel pnlStayCard;
        private Panel pnlStayAccent;
        private Panel pnlStayDivider;
        private Label label2;
        private TableLayoutPanel tblStay;
        private Label lblDateBirth;
        private DateTimePicker dtpCheckinDate;
        private Label label3;
        private DateTimePicker dtpCheckoutDate;
        private Label label7;
        private NumericUpDown nudGuests;
        private Label label4;
        private ComboBox cboRoomType;
        private Label label5;
        private ComboBox cboRoomNumber;
        private Guna.UI2.WinForms.Guna2Button btnAddBooking;
        private Panel pnlBookingsCard;
        private Panel pnlBookingsAccent;
        private Panel pnlBookingsDivider;
        private Label lblRecentBookings;
        private Panel pnlGridHost;
        private DataGridView dgvBookings;
        private DataGridViewTextBoxColumn RoomID;
        private DataGridViewTextBoxColumn GuestID;
        private DataGridViewTextBoxColumn CheckIn;
        private DataGridViewTextBoxColumn CheckOut;
        private DataGridViewTextBoxColumn RoomType;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn Guests;
        private DataGridViewTextBoxColumn Nights;
        private DataGridViewTextBoxColumn TotalAmount;
    }
}