namespace HotelBookingManagementSystem.View
{
    partial class frmBookings
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
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle altRowStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dateStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle centerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle moneyStyle = new DataGridViewCellStyle();

            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlFooter = new Panel();
            lblTotalCaption = new Label();
            lblPeso = new Label();
            lblTotalAmount = new Label();
            btnCancel = new Button();
            btnConfirmBooking = new Button();
            pnlBody = new Panel();

            pnlGuestCard = new Panel();
            lblGuestSection = new Label();
            lineGuest = new Panel();
            btnSelectGuest = new Button();
            btnNewGuest = new Button();
            lblFName = new Label();
            txtFName = new TextBox();
            lblLName = new Label();
            txtLName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            txtGuestID = new TextBox();

            pnlStayCard = new Panel();
            lblStaySection = new Label();
            lineStay = new Panel();
            lblCheckin = new Label();
            dtpCheckinDate = new DateTimePicker();
            lblCheckout = new Label();
            dtpCheckoutDate = new DateTimePicker();
            lblRoomType = new Label();
            cboRoomType = new ComboBox();
            lblRoomNumber = new Label();
            cboRoomNumber = new ComboBox();
            lblGuests = new Label();
            nudGuests = new NumericUpDown();
            btnAddBookings = new Button();

            pnlBookingsCard = new Panel();
            lblBookingsSection = new Label();
            lineBookings = new Panel();
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

            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlGuestCard.SuspendLayout();
            pnlStayCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGuests).BeginInit();
            pnlBookingsCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            SuspendLayout();

            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(47, 65, 86);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1000, 76);
            pnlHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(245, 239, 235);
            lblTitle.Location = new Point(24, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(168, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "New booking";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.75F);
            lblSubtitle.ForeColor = Color.FromArgb(203, 217, 230);
            lblSubtitle.Location = new Point(27, 46);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(410, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Select a guest, choose the stay details, then add rooms to the booking.";
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(47, 65, 86);
            pnlFooter.Controls.Add(lblTotalCaption);
            pnlFooter.Controls.Add(lblPeso);
            pnlFooter.Controls.Add(lblTotalAmount);
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Controls.Add(btnConfirmBooking);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 680);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1000, 72);
            pnlFooter.TabIndex = 3;
            // 
            // lblTotalCaption
            // 
            lblTotalCaption.AutoSize = true;
            lblTotalCaption.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lblTotalCaption.ForeColor = Color.FromArgb(203, 217, 230);
            lblTotalCaption.Location = new Point(24, 10);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(92, 13);
            lblTotalCaption.TabIndex = 0;
            lblTotalCaption.Text = "TOTAL AMOUNT";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblPeso.ForeColor = Color.White;
            lblPeso.Location = new Point(22, 26);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(30, 32);
            lblPeso.TabIndex = 1;
            lblPeso.Text = "₱";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTotalAmount.ForeColor = Color.White;
            lblTotalAmount.Location = new Point(50, 26);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(60, 32);
            lblTotalAmount.TabIndex = 2;
            lblTotalAmount.Text = "0.00";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(47, 65, 86);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(252, 67, 22);
            btnCancel.FlatAppearance.BorderSize = 1;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 239, 235);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(252, 67, 22);
            btnCancel.Location = new Point(624, 14);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 44);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirmBooking
            // 
            btnConfirmBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfirmBooking.BackColor = Color.FromArgb(245, 239, 235);
            btnConfirmBooking.Cursor = Cursors.Hand;
            btnConfirmBooking.Enabled = false;
            btnConfirmBooking.FlatAppearance.BorderSize = 0;
            btnConfirmBooking.FlatAppearance.MouseOverBackColor = Color.White;
            btnConfirmBooking.FlatStyle = FlatStyle.Flat;
            btnConfirmBooking.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnConfirmBooking.ForeColor = Color.FromArgb(47, 65, 86);
            btnConfirmBooking.Location = new Point(776, 14);
            btnConfirmBooking.Name = "btnConfirmBooking";
            btnConfirmBooking.Size = new Size(200, 44);
            btnConfirmBooking.TabIndex = 3;
            btnConfirmBooking.Text = "Confirm booking";
            btnConfirmBooking.UseVisualStyleBackColor = false;
            btnConfirmBooking.Click += btnConfirmBooking_Click;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(203, 217, 230);
            pnlBody.Controls.Add(pnlBookingsCard);
            pnlBody.Controls.Add(pnlStayCard);
            pnlBody.Controls.Add(pnlGuestCard);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 76);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(1000, 604);
            pnlBody.TabIndex = 0;

            // =====================================================
            // GUEST CARD
            // =====================================================
            // 
            // pnlGuestCard
            // 
            pnlGuestCard.BackColor = Color.White;
            pnlGuestCard.Controls.Add(txtGuestID);
            pnlGuestCard.Controls.Add(txtPhoneNumber);
            pnlGuestCard.Controls.Add(lblPhoneNumber);
            pnlGuestCard.Controls.Add(txtEmail);
            pnlGuestCard.Controls.Add(lblEmail);
            pnlGuestCard.Controls.Add(txtLName);
            pnlGuestCard.Controls.Add(lblLName);
            pnlGuestCard.Controls.Add(txtFName);
            pnlGuestCard.Controls.Add(lblFName);
            pnlGuestCard.Controls.Add(btnNewGuest);
            pnlGuestCard.Controls.Add(btnSelectGuest);
            pnlGuestCard.Controls.Add(lineGuest);
            pnlGuestCard.Controls.Add(lblGuestSection);
            pnlGuestCard.Location = new Point(24, 16);
            pnlGuestCard.Name = "pnlGuestCard";
            pnlGuestCard.Size = new Size(468, 250);
            pnlGuestCard.TabIndex = 0;
            // 
            // lblGuestSection
            // 
            lblGuestSection.AutoSize = true;
            lblGuestSection.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblGuestSection.ForeColor = Color.FromArgb(47, 65, 86);
            lblGuestSection.Location = new Point(20, 14);
            lblGuestSection.Name = "lblGuestSection";
            lblGuestSection.Size = new Size(136, 21);
            lblGuestSection.TabIndex = 0;
            lblGuestSection.Text = "Guest information";
            // 
            // lineGuest
            // 
            lineGuest.BackColor = Color.FromArgb(203, 217, 230);
            lineGuest.Location = new Point(20, 44);
            lineGuest.Name = "lineGuest";
            lineGuest.Size = new Size(428, 1);
            lineGuest.TabIndex = 1;
            // 
            // btnSelectGuest
            // 
            btnSelectGuest.BackColor = Color.FromArgb(47, 65, 86);
            btnSelectGuest.Cursor = Cursors.Hand;
            btnSelectGuest.FlatAppearance.BorderSize = 0;
            btnSelectGuest.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 84, 110);
            btnSelectGuest.FlatStyle = FlatStyle.Flat;
            btnSelectGuest.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSelectGuest.ForeColor = Color.White;
            btnSelectGuest.Location = new Point(20, 60);
            btnSelectGuest.Name = "btnSelectGuest";
            btnSelectGuest.Size = new Size(208, 38);
            btnSelectGuest.TabIndex = 0;
            btnSelectGuest.Text = "Select guest";
            btnSelectGuest.UseVisualStyleBackColor = false;
            btnSelectGuest.Click += btnSelectGuest_Click;
            // 
            // btnNewGuest
            // 
            btnNewGuest.BackColor = Color.FromArgb(245, 239, 235);
            btnNewGuest.Cursor = Cursors.Hand;
            btnNewGuest.FlatAppearance.BorderColor = Color.FromArgb(47, 65, 86);
            btnNewGuest.FlatAppearance.BorderSize = 1;
            btnNewGuest.FlatAppearance.MouseOverBackColor = Color.White;
            btnNewGuest.FlatStyle = FlatStyle.Flat;
            btnNewGuest.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnNewGuest.ForeColor = Color.FromArgb(47, 65, 86);
            btnNewGuest.Location = new Point(240, 60);
            btnNewGuest.Name = "btnNewGuest";
            btnNewGuest.Size = new Size(208, 38);
            btnNewGuest.TabIndex = 1;
            btnNewGuest.Text = "New guest";
            btnNewGuest.UseVisualStyleBackColor = false;
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Font = new Font("Segoe UI", 9F);
            lblFName.ForeColor = Color.DimGray;
            lblFName.Location = new Point(20, 112);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(64, 15);
            lblFName.TabIndex = 2;
            lblFName.Text = "First name";
            // 
            // txtFName
            // 
            txtFName.BackColor = Color.FromArgb(245, 239, 235);
            txtFName.BorderStyle = BorderStyle.FixedSingle;
            txtFName.Font = new Font("Segoe UI", 10.5F);
            txtFName.ForeColor = Color.FromArgb(47, 65, 86);
            txtFName.Location = new Point(20, 132);
            txtFName.Name = "txtFName";
            txtFName.ReadOnly = true;
            txtFName.Size = new Size(208, 26);
            txtFName.TabIndex = 3;
            txtFName.TabStop = false;
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Segoe UI", 9F);
            lblLName.ForeColor = Color.DimGray;
            lblLName.Location = new Point(240, 112);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(63, 15);
            lblLName.TabIndex = 4;
            lblLName.Text = "Last name";
            // 
            // txtLName
            // 
            txtLName.BackColor = Color.FromArgb(245, 239, 235);
            txtLName.BorderStyle = BorderStyle.FixedSingle;
            txtLName.Font = new Font("Segoe UI", 10.5F);
            txtLName.ForeColor = Color.FromArgb(47, 65, 86);
            txtLName.Location = new Point(240, 132);
            txtLName.Name = "txtLName";
            txtLName.ReadOnly = true;
            txtLName.Size = new Size(208, 26);
            txtLName.TabIndex = 5;
            txtLName.TabStop = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.ForeColor = Color.DimGray;
            lblEmail.Location = new Point(20, 174);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(245, 239, 235);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10.5F);
            txtEmail.ForeColor = Color.FromArgb(47, 65, 86);
            txtEmail.Location = new Point(20, 194);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(252, 26);
            txtEmail.TabIndex = 7;
            txtEmail.TabStop = false;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 9F);
            lblPhoneNumber.ForeColor = Color.DimGray;
            lblPhoneNumber.Location = new Point(288, 174);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(86, 15);
            lblPhoneNumber.TabIndex = 8;
            lblPhoneNumber.Text = "Phone number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.FromArgb(245, 239, 235);
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Segoe UI", 10.5F);
            txtPhoneNumber.ForeColor = Color.FromArgb(47, 65, 86);
            txtPhoneNumber.Location = new Point(288, 194);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(160, 26);
            txtPhoneNumber.TabIndex = 9;
            txtPhoneNumber.TabStop = false;
            // 
            // txtGuestID  (hidden, holds the selected guest's id)
            // 
            txtGuestID.Location = new Point(400, 16);
            txtGuestID.Name = "txtGuestID";
            txtGuestID.ReadOnly = true;
            txtGuestID.Size = new Size(48, 23);
            txtGuestID.TabIndex = 10;
            txtGuestID.TabStop = false;
            txtGuestID.Visible = false;

            // =====================================================
            // STAY CARD
            // =====================================================
            // 
            // pnlStayCard
            // 
            pnlStayCard.BackColor = Color.White;
            pnlStayCard.Controls.Add(btnAddBookings);
            pnlStayCard.Controls.Add(nudGuests);
            pnlStayCard.Controls.Add(lblGuests);
            pnlStayCard.Controls.Add(cboRoomNumber);
            pnlStayCard.Controls.Add(lblRoomNumber);
            pnlStayCard.Controls.Add(cboRoomType);
            pnlStayCard.Controls.Add(lblRoomType);
            pnlStayCard.Controls.Add(dtpCheckoutDate);
            pnlStayCard.Controls.Add(lblCheckout);
            pnlStayCard.Controls.Add(dtpCheckinDate);
            pnlStayCard.Controls.Add(lblCheckin);
            pnlStayCard.Controls.Add(lineStay);
            pnlStayCard.Controls.Add(lblStaySection);
            pnlStayCard.Location = new Point(508, 16);
            pnlStayCard.Name = "pnlStayCard";
            pnlStayCard.Size = new Size(468, 250);
            pnlStayCard.TabIndex = 1;
            // 
            // lblStaySection
            // 
            lblStaySection.AutoSize = true;
            lblStaySection.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblStaySection.ForeColor = Color.FromArgb(47, 65, 86);
            lblStaySection.Location = new Point(20, 14);
            lblStaySection.Name = "lblStaySection";
            lblStaySection.Size = new Size(97, 21);
            lblStaySection.TabIndex = 0;
            lblStaySection.Text = "Stay details";
            // 
            // lineStay
            // 
            lineStay.BackColor = Color.FromArgb(203, 217, 230);
            lineStay.Location = new Point(20, 44);
            lineStay.Name = "lineStay";
            lineStay.Size = new Size(428, 1);
            lineStay.TabIndex = 1;
            // 
            // lblCheckin
            // 
            lblCheckin.AutoSize = true;
            lblCheckin.Font = new Font("Segoe UI", 9F);
            lblCheckin.ForeColor = Color.DimGray;
            lblCheckin.Location = new Point(20, 60);
            lblCheckin.Name = "lblCheckin";
            lblCheckin.Size = new Size(54, 15);
            lblCheckin.TabIndex = 2;
            lblCheckin.Text = "Check in";
            // 
            // dtpCheckinDate
            // 
            dtpCheckinDate.CalendarForeColor = Color.FromArgb(47, 65, 86);
            dtpCheckinDate.CalendarMonthBackground = Color.White;
            dtpCheckinDate.CalendarTitleBackColor = Color.FromArgb(47, 65, 86);
            dtpCheckinDate.CalendarTitleForeColor = Color.FromArgb(245, 239, 235);
            dtpCheckinDate.CustomFormat = "ddd, MMM d, yyyy";
            dtpCheckinDate.Font = new Font("Segoe UI", 10.5F);
            dtpCheckinDate.Format = DateTimePickerFormat.Custom;
            dtpCheckinDate.Location = new Point(20, 80);
            dtpCheckinDate.Name = "dtpCheckinDate";
            dtpCheckinDate.Size = new Size(208, 27);
            dtpCheckinDate.TabIndex = 0;
            dtpCheckinDate.ValueChanged += dtpCheckinDate_ValueChanged;
            // 
            // lblCheckout
            // 
            lblCheckout.AutoSize = true;
            lblCheckout.Font = new Font("Segoe UI", 9F);
            lblCheckout.ForeColor = Color.DimGray;
            lblCheckout.Location = new Point(240, 60);
            lblCheckout.Name = "lblCheckout";
            lblCheckout.Size = new Size(63, 15);
            lblCheckout.TabIndex = 3;
            lblCheckout.Text = "Check out";
            // 
            // dtpCheckoutDate
            // 
            dtpCheckoutDate.CalendarForeColor = Color.FromArgb(47, 65, 86);
            dtpCheckoutDate.CalendarMonthBackground = Color.White;
            dtpCheckoutDate.CalendarTitleBackColor = Color.FromArgb(47, 65, 86);
            dtpCheckoutDate.CalendarTitleForeColor = Color.FromArgb(245, 239, 235);
            dtpCheckoutDate.CustomFormat = "ddd, MMM d, yyyy";
            dtpCheckoutDate.Font = new Font("Segoe UI", 10.5F);
            dtpCheckoutDate.Format = DateTimePickerFormat.Custom;
            dtpCheckoutDate.Location = new Point(240, 80);
            dtpCheckoutDate.Name = "dtpCheckoutDate";
            dtpCheckoutDate.Size = new Size(208, 27);
            dtpCheckoutDate.TabIndex = 1;
            dtpCheckoutDate.ValueChanged += dtpCheckoutDate_ValueChanged;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 9F);
            lblRoomType.ForeColor = Color.DimGray;
            lblRoomType.Location = new Point(20, 112);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(64, 15);
            lblRoomType.TabIndex = 4;
            lblRoomType.Text = "Room type";
            // 
            // cboRoomType
            // 
            cboRoomType.BackColor = Color.FromArgb(245, 239, 235);
            cboRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoomType.FlatStyle = FlatStyle.Flat;
            cboRoomType.Font = new Font("Segoe UI", 10.5F);
            cboRoomType.ForeColor = Color.FromArgb(47, 65, 86);
            cboRoomType.FormattingEnabled = true;
            cboRoomType.Location = new Point(20, 132);
            cboRoomType.Name = "cboRoomType";
            cboRoomType.Size = new Size(208, 27);
            cboRoomType.TabIndex = 2;
            cboRoomType.SelectedIndexChanged += cboRoomType_SelectedIndexChanged;
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Font = new Font("Segoe UI", 9F);
            lblRoomNumber.ForeColor = Color.DimGray;
            lblRoomNumber.Location = new Point(240, 112);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(84, 15);
            lblRoomNumber.TabIndex = 5;
            lblRoomNumber.Text = "Room number";
            // 
            // cboRoomNumber
            // 
            cboRoomNumber.BackColor = Color.FromArgb(245, 239, 235);
            cboRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoomNumber.FlatStyle = FlatStyle.Flat;
            cboRoomNumber.Font = new Font("Segoe UI", 10.5F);
            cboRoomNumber.ForeColor = Color.FromArgb(47, 65, 86);
            cboRoomNumber.FormattingEnabled = true;
            cboRoomNumber.Location = new Point(240, 132);
            cboRoomNumber.Name = "cboRoomNumber";
            cboRoomNumber.Size = new Size(208, 27);
            cboRoomNumber.TabIndex = 3;
            // 
            // lblGuests
            // 
            lblGuests.AutoSize = true;
            lblGuests.Font = new Font("Segoe UI", 9F);
            lblGuests.ForeColor = Color.DimGray;
            lblGuests.Location = new Point(20, 174);
            lblGuests.Name = "lblGuests";
            lblGuests.Size = new Size(43, 15);
            lblGuests.TabIndex = 6;
            lblGuests.Text = "Guests";
            // 
            // nudGuests
            // 
            nudGuests.BackColor = Color.FromArgb(245, 239, 235);
            nudGuests.BorderStyle = BorderStyle.FixedSingle;
            nudGuests.Font = new Font("Segoe UI", 10.5F);
            nudGuests.ForeColor = Color.FromArgb(47, 65, 86);
            nudGuests.Location = new Point(20, 194);
            nudGuests.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudGuests.Name = "nudGuests";
            nudGuests.Size = new Size(208, 26);
            nudGuests.TabIndex = 4;
            nudGuests.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudGuests.ValueChanged += nudGuests_ValueChanged;
            // 
            // btnAddBookings
            // 
            btnAddBookings.BackColor = Color.FromArgb(47, 65, 86);
            btnAddBookings.Cursor = Cursors.Hand;
            btnAddBookings.FlatAppearance.BorderSize = 0;
            btnAddBookings.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 84, 110);
            btnAddBookings.FlatStyle = FlatStyle.Flat;
            btnAddBookings.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddBookings.ForeColor = Color.White;
            btnAddBookings.Location = new Point(240, 188);
            btnAddBookings.Name = "btnAddBookings";
            btnAddBookings.Size = new Size(208, 38);
            btnAddBookings.TabIndex = 5;
            btnAddBookings.Text = "Add booking";
            btnAddBookings.UseVisualStyleBackColor = false;
            btnAddBookings.Click += btnAddBookings_Click;

            // =====================================================
            // BOOKINGS CARD
            // =====================================================
            // 
            // pnlBookingsCard
            // 
            pnlBookingsCard.BackColor = Color.White;
            pnlBookingsCard.Controls.Add(dgvBookings);
            pnlBookingsCard.Controls.Add(lineBookings);
            pnlBookingsCard.Controls.Add(lblBookingsSection);
            pnlBookingsCard.Location = new Point(24, 282);
            pnlBookingsCard.Name = "pnlBookingsCard";
            pnlBookingsCard.Size = new Size(952, 306);
            pnlBookingsCard.TabIndex = 2;
            // 
            // lblBookingsSection
            // 
            lblBookingsSection.AutoSize = true;
            lblBookingsSection.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblBookingsSection.ForeColor = Color.FromArgb(47, 65, 86);
            lblBookingsSection.Location = new Point(20, 14);
            lblBookingsSection.Name = "lblBookingsSection";
            lblBookingsSection.Size = new Size(104, 21);
            lblBookingsSection.TabIndex = 0;
            lblBookingsSection.Text = "Booking items";
            // 
            // lineBookings
            // 
            lineBookings.BackColor = Color.FromArgb(203, 217, 230);
            lineBookings.Location = new Point(20, 44);
            lineBookings.Name = "lineBookings";
            lineBookings.Size = new Size(912, 1);
            lineBookings.TabIndex = 1;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.AllowUserToResizeRows = false;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.BackgroundColor = Color.White;
            dgvBookings.BorderStyle = BorderStyle.None;
            dgvBookings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.FromArgb(47, 65, 86);
            headerStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            headerStyle.ForeColor = Color.FromArgb(245, 239, 235);
            headerStyle.Padding = new Padding(6, 0, 0, 0);
            headerStyle.SelectionBackColor = Color.FromArgb(47, 65, 86);
            headerStyle.SelectionForeColor = Color.FromArgb(245, 239, 235);
            headerStyle.WrapMode = DataGridViewTriState.False;
            dgvBookings.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvBookings.ColumnHeadersHeight = 36;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBookings.Columns.AddRange(new DataGridViewColumn[] { RoomID, GuestID, CheckIn, CheckOut, RoomType, RoomNumber, Guests, Nights, TotalAmount });
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = Color.White;
            cellStyle.Font = new Font("Segoe UI", 9.75F);
            cellStyle.ForeColor = Color.FromArgb(47, 65, 86);
            cellStyle.Padding = new Padding(6, 0, 0, 0);
            cellStyle.SelectionBackColor = Color.FromArgb(203, 217, 230);
            cellStyle.SelectionForeColor = Color.FromArgb(47, 65, 86);
            cellStyle.WrapMode = DataGridViewTriState.False;
            dgvBookings.DefaultCellStyle = cellStyle;
            dgvBookings.EnableHeadersVisualStyles = false;
            dgvBookings.GridColor = Color.FromArgb(203, 217, 230);
            dgvBookings.Location = new Point(20, 58);
            dgvBookings.MultiSelect = false;
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersVisible = false;
            dgvBookings.RowHeadersWidth = 51;
            altRowStyle.BackColor = Color.FromArgb(245, 239, 235);
            dgvBookings.AlternatingRowsDefaultCellStyle = altRowStyle;
            dgvBookings.RowTemplate.Height = 32;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(912, 228);
            dgvBookings.TabIndex = 2;
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
            dateStyle.Format = "MMM dd, yyyy";
            CheckIn.DataPropertyName = "CheckIn";
            CheckIn.DefaultCellStyle = dateStyle;
            CheckIn.HeaderText = "Check In";
            CheckIn.MinimumWidth = 6;
            CheckIn.Name = "CheckIn";
            CheckIn.ReadOnly = true;
            // 
            // CheckOut
            // 
            CheckOut.DataPropertyName = "CheckOut";
            CheckOut.DefaultCellStyle = dateStyle;
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
            centerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            centerStyle.Padding = new Padding(0);
            RoomNumber.DataPropertyName = "RoomNumber";
            RoomNumber.DefaultCellStyle = centerStyle;
            RoomNumber.HeaderText = "Room No.";
            RoomNumber.MinimumWidth = 6;
            RoomNumber.Name = "RoomNumber";
            RoomNumber.ReadOnly = true;
            // 
            // Guests
            // 
            Guests.DataPropertyName = "Guests";
            Guests.DefaultCellStyle = centerStyle;
            Guests.HeaderText = "Guests";
            Guests.MinimumWidth = 6;
            Guests.Name = "Guests";
            Guests.ReadOnly = true;
            // 
            // Nights
            // 
            Nights.DataPropertyName = "Nights";
            Nights.DefaultCellStyle = centerStyle;
            Nights.HeaderText = "Nights";
            Nights.MinimumWidth = 6;
            Nights.Name = "Nights";
            Nights.ReadOnly = true;
            // 
            // TotalAmount
            // 
            moneyStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            moneyStyle.Format = "N2";
            moneyStyle.Padding = new Padding(0, 0, 10, 0);
            TotalAmount.DataPropertyName = "TotalAmount";
            TotalAmount.DefaultCellStyle = moneyStyle;
            TotalAmount.HeaderText = "Total (₱)";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;

            // 
            // frmBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 217, 230);
            ClientSize = new Size(1000, 752);
            ControlBox = false;
            Controls.Add(pnlBody);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBookings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Booking";
            Load += frmBookings_Load;

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlGuestCard.ResumeLayout(false);
            pnlGuestCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGuests).EndInit();
            pnlStayCard.ResumeLayout(false);
            pnlStayCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            pnlBookingsCard.ResumeLayout(false);
            pnlBookingsCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Layout containers
        private Panel pnlHeader;
        private Panel pnlFooter;
        private Panel pnlBody;
        private Panel pnlGuestCard;
        private Panel pnlStayCard;
        private Panel pnlBookingsCard;
        private Panel lineGuest;
        private Panel lineStay;
        private Panel lineBookings;

        // Header / footer
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblTotalCaption;
        private Label lblPeso;
        private Label lblTotalAmount;
        private Button btnCancel;
        private Button btnConfirmBooking;

        // Guest card
        private Label lblGuestSection;
        private Button btnSelectGuest;
        private Button btnNewGuest;
        private Label lblFName;
        private TextBox txtFName;
        private Label lblLName;
        private TextBox txtLName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private TextBox txtGuestID;

        // Stay card
        private Label lblStaySection;
        private Label lblCheckin;
        private DateTimePicker dtpCheckinDate;
        private Label lblCheckout;
        private DateTimePicker dtpCheckoutDate;
        private Label lblRoomType;
        private ComboBox cboRoomType;
        private Label lblRoomNumber;
        private ComboBox cboRoomNumber;
        private Label lblGuests;
        private NumericUpDown nudGuests;
        private Button btnAddBookings;

        // Bookings card
        private Label lblBookingsSection;
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