namespace HotelBookingManagementSystem.View
{
    partial class GuestControls
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btnBookings = new Button();
            lblSubtitle = new Label();
            lblGuests = new Label();
            pnlListCard = new Panel();
            dgvGuests = new DataGridView();
            pnlToolbar = new Panel();
            txtUserID = new TextBox();
            btnSearch = new Button();
            btnSelect = new Button();
            btnRefresh = new Button();
            txtGuestID = new TextBox();
            pnlGuestDetail = new Panel();
            tblDetail = new TableLayoutPanel();
            label1 = new Label();
            lblLName = new Label();
            txtFName = new TextBox();
            txtLName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            lblDateBirth = new Label();
            txtPhoneNumber = new TextBox();
            dtpBirthDate = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            txtIDType = new TextBox();
            txtIDNumber = new TextBox();
            btnSave = new Button();
            btnViewBooking = new Button();
            pnlDetailDivider = new Panel();
            label2 = new Label();
            pnlDetailAccent = new Panel();
            panel2.SuspendLayout();
            pnlListCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).BeginInit();
            pnlToolbar.SuspendLayout();
            pnlGuestDetail.SuspendLayout();
            tblDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(47, 65, 86);
            panel2.Controls.Add(btnBookings);
            panel2.Controls.Add(lblSubtitle);
            panel2.Controls.Add(lblGuests);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1092, 76);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // btnBookings
            // 
            btnBookings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBookings.BackColor = Color.FromArgb(62, 82, 107);
            btnBookings.Cursor = Cursors.Hand;
            btnBookings.FlatAppearance.BorderColor = Color.FromArgb(95, 118, 145);
            btnBookings.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 50, 68);
            btnBookings.FlatAppearance.MouseOverBackColor = Color.FromArgb(78, 100, 128);
            btnBookings.FlatStyle = FlatStyle.Flat;
            btnBookings.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookings.ForeColor = Color.White;
            btnBookings.Location = new Point(928, 18);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(140, 40);
            btnBookings.TabIndex = 1;
            btnBookings.Text = "Bookings";
            btnBookings.UseVisualStyleBackColor = false;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(203, 217, 230);
            lblSubtitle.Location = new Point(26, 46);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(188, 15);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Guest records and booking history";
            // 
            // lblGuests
            // 
            lblGuests.AutoSize = true;
            lblGuests.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuests.ForeColor = Color.White;
            lblGuests.Location = new Point(22, 8);
            lblGuests.Name = "lblGuests";
            lblGuests.Size = new Size(87, 32);
            lblGuests.TabIndex = 0;
            lblGuests.Text = "Guests";
            // 
            // pnlListCard
            // 
            pnlListCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlListCard.BackColor = Color.White;
            pnlListCard.Controls.Add(dgvGuests);
            pnlListCard.Controls.Add(pnlToolbar);
            pnlListCard.Location = new Point(24, 100);
            pnlListCard.Name = "pnlListCard";
            pnlListCard.Padding = new Padding(16);
            pnlListCard.Size = new Size(620, 548);
            pnlListCard.TabIndex = 3;
            // 
            // dgvGuests
            // 
            dgvGuests.AllowUserToAddRows = false;
            dgvGuests.AllowUserToDeleteRows = false;
            dgvGuests.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(249, 251, 253);
            dgvGuests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuests.BackgroundColor = Color.White;
            dgvGuests.BorderStyle = BorderStyle.None;
            dgvGuests.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGuests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(238, 243, 248);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(47, 65, 86);
            dataGridViewCellStyle5.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(238, 243, 248);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(47, 65, 86);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvGuests.ColumnHeadersHeight = 40;
            dgvGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(47, 65, 86);
            dataGridViewCellStyle6.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(219, 230, 242);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(47, 65, 86);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvGuests.DefaultCellStyle = dataGridViewCellStyle6;
            dgvGuests.Dock = DockStyle.Fill;
            dgvGuests.EnableHeadersVisualStyles = false;
            dgvGuests.GridColor = Color.FromArgb(228, 234, 241);
            dgvGuests.Location = new Point(16, 60);
            dgvGuests.MultiSelect = false;
            dgvGuests.Name = "dgvGuests";
            dgvGuests.ReadOnly = true;
            dgvGuests.RowHeadersVisible = false;
            dgvGuests.RowHeadersWidth = 51;
            dgvGuests.RowTemplate.Height = 36;
            dgvGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGuests.Size = new Size(588, 472);
            dgvGuests.TabIndex = 0;
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(txtUserID);
            pnlToolbar.Controls.Add(btnSearch);
            pnlToolbar.Controls.Add(btnSelect);
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(16, 16);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(588, 44);
            pnlToolbar.TabIndex = 1;
            // 
            // txtUserID
            // 
            txtUserID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUserID.BackColor = Color.FromArgb(247, 249, 251);
            txtUserID.BorderStyle = BorderStyle.FixedSingle;
            txtUserID.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserID.ForeColor = Color.FromArgb(47, 65, 86);
            txtUserID.Location = new Point(0, 0);
            txtUserID.Name = "txtUserID";
            txtUserID.PlaceholderText = "Search guests...";
            txtUserID.Size = new Size(296, 27);
            txtUserID.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(47, 65, 86);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 50, 68);
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 82, 107);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(304, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 28);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelect.BackColor = Color.White;
            btnSelect.Cursor = Cursors.Hand;
            btnSelect.FlatAppearance.BorderColor = Color.FromArgb(203, 217, 230);
            btnSelect.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 230, 240);
            btnSelect.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 242, 247);
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelect.ForeColor = Color.FromArgb(47, 65, 86);
            btnSelect.Location = new Point(496, 0);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(92, 28);
            btnSelect.TabIndex = 3;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.White;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(203, 217, 230);
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 230, 240);
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 242, 247);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.FromArgb(47, 65, 86);
            btnRefresh.Location = new Point(400, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(88, 28);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtGuestID
            // 
            txtGuestID.Location = new Point(347, 9);
            txtGuestID.Name = "txtGuestID";
            txtGuestID.ReadOnly = true;
            txtGuestID.Size = new Size(50, 23);
            txtGuestID.TabIndex = 99;
            txtGuestID.Visible = false;
            // 
            // pnlGuestDetail
            // 
            pnlGuestDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlGuestDetail.BackColor = Color.White;
            pnlGuestDetail.Controls.Add(txtGuestID);
            pnlGuestDetail.Controls.Add(tblDetail);
            pnlGuestDetail.Controls.Add(pnlDetailDivider);
            pnlGuestDetail.Controls.Add(label2);
            pnlGuestDetail.Controls.Add(pnlDetailAccent);
            pnlGuestDetail.Location = new Point(668, 100);
            pnlGuestDetail.Name = "pnlGuestDetail";
            pnlGuestDetail.Size = new Size(400, 548);
            pnlGuestDetail.TabIndex = 4;
            // 
            // tblDetail
            // 
            tblDetail.ColumnCount = 2;
            tblDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDetail.Controls.Add(label1, 0, 0);
            tblDetail.Controls.Add(lblLName, 1, 0);
            tblDetail.Controls.Add(txtFName, 0, 1);
            tblDetail.Controls.Add(txtLName, 1, 1);
            tblDetail.Controls.Add(lblEmail, 0, 2);
            tblDetail.Controls.Add(txtEmail, 0, 3);
            tblDetail.Controls.Add(label6, 0, 4);
            tblDetail.Controls.Add(lblDateBirth, 1, 4);
            tblDetail.Controls.Add(txtPhoneNumber, 0, 5);
            tblDetail.Controls.Add(dtpBirthDate, 1, 5);
            tblDetail.Controls.Add(label7, 0, 6);
            tblDetail.Controls.Add(label8, 1, 6);
            tblDetail.Controls.Add(txtIDType, 0, 7);
            tblDetail.Controls.Add(txtIDNumber, 1, 7);
            tblDetail.Controls.Add(btnSave, 0, 8);
            tblDetail.Controls.Add(btnViewBooking, 1, 8);
            tblDetail.Dock = DockStyle.Fill;
            tblDetail.Location = new Point(0, 56);
            tblDetail.Name = "tblDetail";
            tblDetail.Padding = new Padding(20, 12, 20, 16);
            tblDetail.RowCount = 9;
            tblDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tblDetail.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tblDetail.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tblDetail.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tblDetail.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tblDetail.Size = new Size(400, 492);
            tblDetail.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(92, 108, 128);
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
            lblLName.Location = new Point(208, 15);
            lblLName.Margin = new Padding(8, 0, 0, 4);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(61, 15);
            lblLName.TabIndex = 2;
            lblLName.Text = "Last name";
            // 
            // txtFName
            // 
            txtFName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFName.BackColor = Color.FromArgb(247, 249, 251);
            txtFName.BorderStyle = BorderStyle.FixedSingle;
            txtFName.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFName.ForeColor = Color.FromArgb(47, 65, 86);
            txtFName.Location = new Point(20, 34);
            txtFName.Margin = new Padding(0, 0, 8, 0);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(172, 26);
            txtFName.TabIndex = 0;
            // 
            // txtLName
            // 
            txtLName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLName.BackColor = Color.FromArgb(247, 249, 251);
            txtLName.BorderStyle = BorderStyle.FixedSingle;
            txtLName.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLName.ForeColor = Color.FromArgb(47, 65, 86);
            txtLName.Location = new Point(208, 34);
            txtLName.Margin = new Padding(8, 0, 0, 0);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(172, 26);
            txtLName.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblEmail.AutoSize = true;
            tblDetail.SetColumnSpan(lblEmail, 2);
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(92, 108, 128);
            lblEmail.Location = new Point(20, 118);
            lblEmail.Margin = new Padding(0, 0, 0, 4);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(79, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email address";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.FromArgb(247, 249, 251);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            tblDetail.SetColumnSpan(txtEmail, 2);
            txtEmail.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(47, 65, 86);
            txtEmail.Location = new Point(20, 137);
            txtEmail.Margin = new Padding(0);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(360, 26);
            txtEmail.TabIndex = 2;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(92, 108, 128);
            label6.Location = new Point(20, 221);
            label6.Margin = new Padding(0, 0, 0, 4);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 4;
            label6.Text = "Phone number";
            // 
            // lblDateBirth
            // 
            lblDateBirth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDateBirth.AutoSize = true;
            lblDateBirth.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateBirth.ForeColor = Color.FromArgb(92, 108, 128);
            lblDateBirth.Location = new Point(208, 221);
            lblDateBirth.Margin = new Padding(8, 0, 0, 4);
            lblDateBirth.Name = "lblDateBirth";
            lblDateBirth.Size = new Size(58, 15);
            lblDateBirth.TabIndex = 5;
            lblDateBirth.Text = "Birth date";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneNumber.BackColor = Color.FromArgb(247, 249, 251);
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.ForeColor = Color.FromArgb(47, 65, 86);
            txtPhoneNumber.Location = new Point(20, 240);
            txtPhoneNumber.Margin = new Padding(0, 0, 8, 0);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(172, 26);
            txtPhoneNumber.TabIndex = 3;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpBirthDate.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirthDate.CalendarMonthBackground = Color.White;
            dtpBirthDate.CalendarTitleBackColor = Color.FromArgb(47, 65, 86);
            dtpBirthDate.CalendarTitleForeColor = Color.White;
            dtpBirthDate.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(208, 240);
            dtpBirthDate.Margin = new Padding(8, 0, 0, 0);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(172, 26);
            dtpBirthDate.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(92, 108, 128);
            label7.Location = new Point(20, 324);
            label7.Margin = new Padding(0, 0, 0, 4);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 6;
            label7.Text = "ID type";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(92, 108, 128);
            label8.Location = new Point(208, 324);
            label8.Margin = new Padding(8, 0, 0, 4);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 7;
            label8.Text = "ID number";
            // 
            // txtIDType
            // 
            txtIDType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIDType.BackColor = Color.FromArgb(247, 249, 251);
            txtIDType.BorderStyle = BorderStyle.FixedSingle;
            txtIDType.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDType.ForeColor = Color.FromArgb(47, 65, 86);
            txtIDType.Location = new Point(20, 343);
            txtIDType.Margin = new Padding(0, 0, 8, 0);
            txtIDType.Name = "txtIDType";
            txtIDType.Size = new Size(172, 26);
            txtIDType.TabIndex = 5;
            // 
            // txtIDNumber
            // 
            txtIDNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIDNumber.BackColor = Color.FromArgb(247, 249, 251);
            txtIDNumber.BorderStyle = BorderStyle.FixedSingle;
            txtIDNumber.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDNumber.ForeColor = Color.FromArgb(47, 65, 86);
            txtIDNumber.Location = new Point(208, 343);
            txtIDNumber.Margin = new Padding(8, 0, 0, 0);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(172, 26);
            txtIDNumber.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(47, 65, 86);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Dock = DockStyle.Fill;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 50, 68);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 82, 107);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(20, 432);
            btnSave.Margin = new Padding(0, 8, 8, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(172, 44);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnViewBooking
            // 
            btnViewBooking.BackColor = Color.White;
            btnViewBooking.Cursor = Cursors.Hand;
            btnViewBooking.Dock = DockStyle.Fill;
            btnViewBooking.FlatAppearance.BorderColor = Color.FromArgb(203, 217, 230);
            btnViewBooking.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 230, 240);
            btnViewBooking.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 242, 247);
            btnViewBooking.FlatStyle = FlatStyle.Flat;
            btnViewBooking.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewBooking.ForeColor = Color.FromArgb(47, 65, 86);
            btnViewBooking.Location = new Point(208, 432);
            btnViewBooking.Margin = new Padding(8, 8, 0, 0);
            btnViewBooking.Name = "btnViewBooking";
            btnViewBooking.Size = new Size(172, 44);
            btnViewBooking.TabIndex = 8;
            btnViewBooking.Text = "Booking history";
            btnViewBooking.UseVisualStyleBackColor = false;
            // 
            // pnlDetailDivider
            // 
            pnlDetailDivider.BackColor = Color.FromArgb(228, 234, 241);
            pnlDetailDivider.Dock = DockStyle.Top;
            pnlDetailDivider.Location = new Point(0, 55);
            pnlDetailDivider.Name = "pnlDetailDivider";
            pnlDetailDivider.Size = new Size(400, 1);
            pnlDetailDivider.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(47, 65, 86);
            label2.Location = new Point(0, 3);
            label2.Name = "label2";
            label2.Padding = new Padding(20, 0, 0, 0);
            label2.Size = new Size(400, 52);
            label2.TabIndex = 2;
            label2.Text = "Guest details";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlDetailAccent
            // 
            pnlDetailAccent.BackColor = Color.FromArgb(47, 65, 86);
            pnlDetailAccent.Dock = DockStyle.Top;
            pnlDetailAccent.Location = new Point(0, 0);
            pnlDetailAccent.Name = "pnlDetailAccent";
            pnlDetailAccent.Size = new Size(400, 3);
            pnlDetailAccent.TabIndex = 3;
            // 
            // GuestControls
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(238, 242, 246);
            Controls.Add(pnlGuestDetail);
            Controls.Add(pnlListCard);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "GuestControls";
            Size = new Size(1092, 672);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlListCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGuests).EndInit();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlGuestDetail.ResumeLayout(false);
            pnlGuestDetail.PerformLayout();
            tblDetail.ResumeLayout(false);
            tblDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblGuests;
        private Label lblSubtitle;
        private Button btnBookings;
        private Panel pnlListCard;
        private Panel pnlToolbar;
        private TextBox txtUserID;
        private Button btnSearch;
        private Button btnSelect;
        private DataGridView dgvGuests;
        private Panel pnlGuestDetail;
        private Panel pnlDetailAccent;
        private Panel pnlDetailDivider;
        private TableLayoutPanel tblDetail;
        private Label label2;
        private Label label1;
        private TextBox txtFName;
        private Label lblLName;
        private TextBox txtLName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtPhoneNumber;
        private Label lblDateBirth;
        private DateTimePicker dtpBirthDate;
        private Label label7;
        private TextBox txtIDType;
        private Label label8;
        private TextBox txtIDNumber;
        private Button btnSave;
        private Button btnViewBooking;
        private Button btnRefresh;
        private TextBox txtGuestID;
    }
}