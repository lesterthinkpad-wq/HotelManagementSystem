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
            panel2 = new Panel();
            lblCurrentUser = new Label();
            splitter1 = new Splitter();
            lblRecentBookings = new Label();
            btnSelectGuest = new Button();
            btnNewGuest = new Button();
            label6 = new Label();
            txtPhoneNumber = new TextBox();
            lblLName = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            txtFName = new TextBox();
            label2 = new Label();
            dtpCheckinDate = new DateTimePicker();
            lblDateBirth = new Label();
            dtpCheckoutDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            cboRoomType = new ComboBox();
            cboRoomNumber = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            nudGuests = new NumericUpDown();
            dgvBookings = new DataGridView();
            btnAddBookings = new Button();
            panel1 = new Panel();
            label9 = new Label();
            lblTotalAmount = new Label();
            label8 = new Label();
            splitter2 = new Splitter();
            btnConfirmBooking = new Button();
            btnCancel = new Button();
            txtLName = new TextBox();
            txtGuestID = new TextBox();
            RoomID = new DataGridViewTextBoxColumn();
            GuestID = new DataGridViewTextBoxColumn();
            CheckIn = new DataGridViewTextBoxColumn();
            CheckOut = new DataGridViewTextBoxColumn();
            RoomType = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            Guests = new DataGridViewTextBoxColumn();
            Nights = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGuests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(47, 65, 86);
            panel2.Controls.Add(lblCurrentUser);
            panel2.Controls.Add(splitter1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(927, 113);
            panel2.TabIndex = 2;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Font = new Font("Monotype Corsiva", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCurrentUser.ForeColor = Color.FromArgb(245, 239, 235);
            lblCurrentUser.Location = new Point(23, 35);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(190, 41);
            lblCurrentUser.TabIndex = 3;
            lblCurrentUser.Text = "New booking";
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
            // lblRecentBookings
            // 
            lblRecentBookings.AutoSize = true;
            lblRecentBookings.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            lblRecentBookings.ForeColor = Color.DimGray;
            lblRecentBookings.Location = new Point(24, 127);
            lblRecentBookings.Name = "lblRecentBookings";
            lblRecentBookings.Size = new Size(211, 29);
            lblRecentBookings.TabIndex = 4;
            lblRecentBookings.Text = "Recent Bookings";
            // 
            // btnSelectGuest
            // 
            btnSelectGuest.BackColor = Color.FromArgb(245, 239, 235);
            btnSelectGuest.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSelectGuest.Location = new Point(24, 169);
            btnSelectGuest.Name = "btnSelectGuest";
            btnSelectGuest.Size = new Size(194, 51);
            btnSelectGuest.TabIndex = 5;
            btnSelectGuest.Text = "Select guest";
            btnSelectGuest.UseVisualStyleBackColor = false;
            btnSelectGuest.Click += btnSelectGuest_Click;
            // 
            // btnNewGuest
            // 
            btnNewGuest.BackColor = Color.FromArgb(47, 65, 86);
            btnNewGuest.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnNewGuest.ForeColor = Color.White;
            btnNewGuest.Location = new Point(224, 169);
            btnNewGuest.Name = "btnNewGuest";
            btnNewGuest.Size = new Size(194, 51);
            btnNewGuest.TabIndex = 6;
            btnNewGuest.Text = "New guest";
            btnNewGuest.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(506, 337);
            label6.Name = "label6";
            label6.Size = new Size(143, 25);
            label6.TabIndex = 25;
            label6.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.FromArgb(245, 239, 235);
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Location = new Point(506, 366);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(395, 38);
            txtPhoneNumber.TabIndex = 24;
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Microsoft Sans Serif", 12F);
            lblLName.ForeColor = Color.DimGray;
            lblLName.Location = new Point(506, 242);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(106, 25);
            lblLName.TabIndex = 23;
            lblLName.Text = "Last Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 12F);
            lblEmail.ForeColor = Color.DimGray;
            lblEmail.Location = new Point(24, 338);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 25);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(245, 239, 235);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(23, 366);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(382, 38);
            txtEmail.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(24, 243);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 19;
            label1.Text = "First Name";
            // 
            // txtFName
            // 
            txtFName.BackColor = Color.FromArgb(245, 239, 235);
            txtFName.BorderStyle = BorderStyle.FixedSingle;
            txtFName.Location = new Point(23, 271);
            txtFName.Multiline = true;
            txtFName.Name = "txtFName";
            txtFName.ReadOnly = true;
            txtFName.Size = new Size(382, 38);
            txtFName.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(24, 431);
            label2.Name = "label2";
            label2.Size = new Size(148, 29);
            label2.TabIndex = 26;
            label2.Text = "Stay details";
            // 
            // dtpCheckinDate
            // 
            dtpCheckinDate.CalendarFont = new Font("Microsoft Sans Serif", 16.2F);
            dtpCheckinDate.Font = new Font("Microsoft Sans Serif", 13.8F);
            dtpCheckinDate.Location = new Point(24, 503);
            dtpCheckinDate.Name = "dtpCheckinDate";
            dtpCheckinDate.Size = new Size(309, 34);
            dtpCheckinDate.TabIndex = 28;
            dtpCheckinDate.ValueChanged += dtpCheckinDate_ValueChanged;
            // 
            // lblDateBirth
            // 
            lblDateBirth.AutoSize = true;
            lblDateBirth.Font = new Font("Microsoft Sans Serif", 12F);
            lblDateBirth.ForeColor = Color.DimGray;
            lblDateBirth.Location = new Point(24, 475);
            lblDateBirth.Name = "lblDateBirth";
            lblDateBirth.Size = new Size(89, 25);
            lblDateBirth.TabIndex = 27;
            lblDateBirth.Text = "Check in";
            // 
            // dtpCheckoutDate
            // 
            dtpCheckoutDate.CalendarFont = new Font("Microsoft Sans Serif", 16.2F);
            dtpCheckoutDate.Font = new Font("Microsoft Sans Serif", 13.8F);
            dtpCheckoutDate.Location = new Point(506, 502);
            dtpCheckoutDate.Name = "dtpCheckoutDate";
            dtpCheckoutDate.Size = new Size(309, 34);
            dtpCheckoutDate.TabIndex = 30;
            dtpCheckoutDate.ValueChanged += dtpCheckoutDate_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(506, 474);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 29;
            label3.Text = "Check out";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(24, 554);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 31;
            label4.Text = "Room type";
            // 
            // cboRoomType
            // 
            cboRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoomType.Font = new Font("Microsoft Sans Serif", 15F);
            cboRoomType.FormattingEnabled = true;
            cboRoomType.Location = new Point(23, 582);
            cboRoomType.Name = "cboRoomType";
            cboRoomType.Size = new Size(214, 37);
            cboRoomType.TabIndex = 32;
            cboRoomType.SelectedIndexChanged += cboRoomType_SelectedIndexChanged;
            // 
            // cboRoomNumber
            // 
            cboRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoomNumber.Font = new Font("Microsoft Sans Serif", 15F);
            cboRoomNumber.FormattingEnabled = true;
            cboRoomNumber.Location = new Point(349, 581);
            cboRoomNumber.Name = "cboRoomNumber";
            cboRoomNumber.Size = new Size(214, 37);
            cboRoomNumber.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(350, 553);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 33;
            label5.Text = "Room number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(675, 553);
            label7.Name = "label7";
            label7.Size = new Size(74, 25);
            label7.TabIndex = 35;
            label7.Text = "Guests";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Microsoft Sans Serif", 15F);
            numericUpDown1.Location = new Point(5355, 2000);
            numericUpDown1.Margin = new Padding(21, 10, 21, 10);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(1140, 36);
            numericUpDown1.TabIndex = 36;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudGuests
            // 
            nudGuests.Font = new Font("Microsoft Sans Serif", 15F);
            nudGuests.Location = new Point(675, 582);
            nudGuests.Margin = new Padding(4);
            nudGuests.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudGuests.Name = "nudGuests";
            nudGuests.Size = new Size(140, 36);
            nudGuests.TabIndex = 37;
            nudGuests.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudGuests.ValueChanged += nudGuests_ValueChanged;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Columns.AddRange(new DataGridViewColumn[] { RoomID, GuestID, CheckIn, CheckOut, RoomType, RoomNumber, Guests, Nights, TotalAmount });
            dgvBookings.Location = new Point(23, 688);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersWidth = 51;
            dgvBookings.Size = new Size(878, 180);
            dgvBookings.TabIndex = 38;
            // 
            // btnAddBookings
            // 
            btnAddBookings.BackColor = Color.FromArgb(47, 65, 86);
            btnAddBookings.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnAddBookings.ForeColor = Color.White;
            btnAddBookings.Location = new Point(23, 632);
            btnAddBookings.Name = "btnAddBookings";
            btnAddBookings.Size = new Size(194, 51);
            btnAddBookings.TabIndex = 39;
            btnAddBookings.Text = "Add booking";
            btnAddBookings.UseVisualStyleBackColor = false;
            btnAddBookings.Click += btnAddBookings_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 65, 86);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(lblTotalAmount);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(splitter2);
            panel1.Location = new Point(23, 876);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 49);
            panel1.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(668, 10);
            label9.Name = "label9";
            label9.Size = new Size(29, 29);
            label9.TabIndex = 7;
            label9.Text = "₱";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            lblTotalAmount.ForeColor = Color.White;
            lblTotalAmount.Location = new Point(703, 10);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 29);
            lblTotalAmount.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, 10);
            label8.Name = "label8";
            label8.Size = new Size(172, 29);
            label8.TabIndex = 5;
            label8.Text = "Total amount:";
            // 
            // splitter2
            // 
            splitter2.BackColor = Color.FromArgb(203, 217, 230);
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(1, 49);
            splitter2.TabIndex = 0;
            splitter2.TabStop = false;
            // 
            // btnConfirmBooking
            // 
            btnConfirmBooking.BackColor = Color.FromArgb(47, 65, 86);
            btnConfirmBooking.Enabled = false;
            btnConfirmBooking.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnConfirmBooking.ForeColor = Color.White;
            btnConfirmBooking.Location = new Point(23, 937);
            btnConfirmBooking.Name = "btnConfirmBooking";
            btnConfirmBooking.Size = new Size(194, 51);
            btnConfirmBooking.TabIndex = 42;
            btnConfirmBooking.Text = "Confirm booking";
            btnConfirmBooking.UseVisualStyleBackColor = false;
            btnConfirmBooking.Click += btnConfirmBooking_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(245, 239, 235);
            btnCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(252, 67, 22);
            btnCancel.Location = new Point(223, 937);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(194, 51);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtLName
            // 
            txtLName.BackColor = Color.FromArgb(245, 239, 235);
            txtLName.BorderStyle = BorderStyle.FixedSingle;
            txtLName.Location = new Point(506, 270);
            txtLName.Multiline = true;
            txtLName.Name = "txtLName";
            txtLName.ReadOnly = true;
            txtLName.Size = new Size(395, 38);
            txtLName.TabIndex = 22;
            // 
            // txtGuestID
            // 
            txtGuestID.BackColor = Color.FromArgb(245, 239, 235);
            txtGuestID.BorderStyle = BorderStyle.FixedSingle;
            txtGuestID.Location = new Point(847, 128);
            txtGuestID.Multiline = true;
            txtGuestID.Name = "txtGuestID";
            txtGuestID.ReadOnly = true;
            txtGuestID.Size = new Size(80, 38);
            txtGuestID.TabIndex = 43;
            txtGuestID.Visible = false;
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
            CheckIn.HeaderText = "Check In";
            CheckIn.MinimumWidth = 6;
            CheckIn.Name = "CheckIn";
            CheckIn.ReadOnly = true;
            // 
            // CheckOut
            // 
            CheckOut.DataPropertyName = "CheckOut";
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
            Guests.HeaderText = "Guests";
            Guests.MinimumWidth = 6;
            Guests.Name = "Guests";
            Guests.ReadOnly = true;
            // 
            // Nights
            // 
            Nights.DataPropertyName = "Nights";
            Nights.HeaderText = "Nights";
            Nights.MinimumWidth = 6;
            Nights.Name = "Nights";
            Nights.ReadOnly = true;
            // 
            // TotalAmount
            // 
            TotalAmount.DataPropertyName = "TotalAmount";
            TotalAmount.HeaderText = "Total";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            // 
            // frmBookings
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 217, 230);
            ClientSize = new Size(927, 1013);
            ControlBox = false;
            Controls.Add(txtGuestID);
            Controls.Add(btnConfirmBooking);
            Controls.Add(btnCancel);
            Controls.Add(panel1);
            Controls.Add(btnAddBookings);
            Controls.Add(dgvBookings);
            Controls.Add(nudGuests);
            Controls.Add(numericUpDown1);
            Controls.Add(label7);
            Controls.Add(cboRoomNumber);
            Controls.Add(label5);
            Controls.Add(cboRoomType);
            Controls.Add(label4);
            Controls.Add(dtpCheckoutDate);
            Controls.Add(label3);
            Controls.Add(dtpCheckinDate);
            Controls.Add(lblDateBirth);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblLName);
            Controls.Add(txtLName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(txtFName);
            Controls.Add(btnNewGuest);
            Controls.Add(btnSelectGuest);
            Controls.Add(lblRecentBookings);
            Controls.Add(panel2);
            Font = new Font("Microsoft Sans Serif", 12F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "frmBookings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmBookings";
            Load += frmBookings_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGuests).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lblCurrentUser;
        private Splitter splitter1;
        private Label lblRecentBookings;
        private Button btnSelectGuest;
        private Button btnNewGuest;
        private Label label6;
        private TextBox txtPhoneNumber;
        private Label lblLName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtFName;
        private Label label2;
        private DateTimePicker dtpCheckinDate;
        private Label lblDateBirth;
        private DateTimePicker dtpCheckoutDate;
        private Label label3;
        private Label label4;
        private ComboBox cboRoomType;
        private ComboBox cboRoomNumber;
        private Label label5;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private NumericUpDown nudGuests;
        private DataGridView dgvBookings;
        private Button btnAddBookings;
        private Panel panel1;
        private Splitter splitter2;
        private Label label8;
        private Button btnConfirmBooking;
        private Button btnCancel;
        private TextBox txtLName;
        private TextBox txtGuestID;
        private Label lblTotalAmount;
        private Label label9;
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