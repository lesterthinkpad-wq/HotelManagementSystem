namespace HotelBookingManagementSystem.View
{
    partial class frmGuests
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btnBookings = new Button();
            lblGuests = new Label();
            splitter1 = new Splitter();
            txtUserID = new TextBox();
            lblSearch = new Label();
            btnSearch = new Button();
            dgvGuests = new DataGridView();
            pnlGuestDetail = new Panel();
            btnViewBooking = new Button();
            dtpBirthDate = new DateTimePicker();
            label8 = new Label();
            txtIDNumber = new TextBox();
            label7 = new Label();
            txtIDType = new TextBox();
            label6 = new Label();
            txtPhoneNumber = new TextBox();
            lblLName = new Label();
            txtLName = new TextBox();
            lblDateBirth = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            txtFName = new TextBox();
            btnSave = new Button();
            splitter2 = new Splitter();
            label2 = new Label();
            btnSelect = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).BeginInit();
            pnlGuestDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(47, 65, 86);
            panel2.Controls.Add(btnBookings);
            panel2.Controls.Add(lblGuests);
            panel2.Controls.Add(splitter1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 82);
            panel2.TabIndex = 2;
            // 
            // btnBookings
            // 
            btnBookings.BackColor = Color.FromArgb(203, 217, 230);
            btnBookings.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnBookings.Location = new Point(720, 15);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(194, 51);
            btnBookings.TabIndex = 4;
            btnBookings.Text = "Bookings";
            btnBookings.UseVisualStyleBackColor = false;
            // 
            // lblGuests
            // 
            lblGuests.AutoSize = true;
            lblGuests.Font = new Font("Monotype Corsiva", 16.2F, FontStyle.Bold | FontStyle.Italic);
            lblGuests.ForeColor = Color.FromArgb(245, 239, 235);
            lblGuests.Location = new Point(12, 26);
            lblGuests.Name = "lblGuests";
            lblGuests.Size = new Size(88, 34);
            lblGuests.TabIndex = 3;
            lblGuests.Text = "Guests";
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.FromArgb(203, 217, 230);
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1, 82);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // txtUserID
            // 
            txtUserID.BackColor = Color.FromArgb(245, 239, 235);
            txtUserID.BorderStyle = BorderStyle.FixedSingle;
            txtUserID.Location = new Point(12, 126);
            txtUserID.Multiline = true;
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(387, 38);
            txtUserID.TabIndex = 3;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Microsoft Sans Serif", 13.8F);
            lblSearch.ForeColor = Color.DimGray;
            lblSearch.Location = new Point(12, 94);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(89, 29);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(245, 239, 235);
            btnSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSearch.Location = new Point(405, 126);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 38);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvGuests
            // 
            dgvGuests.AllowUserToAddRows = false;
            dgvGuests.AllowUserToDeleteRows = false;
            dgvGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvGuests.DefaultCellStyle = dataGridViewCellStyle6;
            dgvGuests.Location = new Point(12, 171);
            dgvGuests.Name = "dgvGuests";
            dgvGuests.ReadOnly = true;
            dgvGuests.RowHeadersWidth = 51;
            dgvGuests.Size = new Size(906, 300);
            dgvGuests.TabIndex = 6;
            // 
            // pnlGuestDetail
            // 
            pnlGuestDetail.BackColor = Color.FromArgb(47, 65, 86);
            pnlGuestDetail.Controls.Add(btnViewBooking);
            pnlGuestDetail.Controls.Add(dtpBirthDate);
            pnlGuestDetail.Controls.Add(label8);
            pnlGuestDetail.Controls.Add(txtIDNumber);
            pnlGuestDetail.Controls.Add(label7);
            pnlGuestDetail.Controls.Add(txtIDType);
            pnlGuestDetail.Controls.Add(label6);
            pnlGuestDetail.Controls.Add(txtPhoneNumber);
            pnlGuestDetail.Controls.Add(lblLName);
            pnlGuestDetail.Controls.Add(txtLName);
            pnlGuestDetail.Controls.Add(lblDateBirth);
            pnlGuestDetail.Controls.Add(lblEmail);
            pnlGuestDetail.Controls.Add(txtEmail);
            pnlGuestDetail.Controls.Add(label1);
            pnlGuestDetail.Controls.Add(txtFName);
            pnlGuestDetail.Controls.Add(btnSave);
            pnlGuestDetail.Controls.Add(splitter2);
            pnlGuestDetail.Location = new Point(12, 568);
            pnlGuestDetail.Name = "pnlGuestDetail";
            pnlGuestDetail.Size = new Size(906, 373);
            pnlGuestDetail.TabIndex = 7;
            // 
            // btnViewBooking
            // 
            btnViewBooking.BackColor = Color.FromArgb(245, 239, 235);
            btnViewBooking.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnViewBooking.Location = new Point(199, 305);
            btnViewBooking.Name = "btnViewBooking";
            btnViewBooking.Size = new Size(225, 51);
            btnViewBooking.TabIndex = 23;
            btnViewBooking.Text = "View booking history";
            btnViewBooking.UseVisualStyleBackColor = false;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CalendarFont = new Font("Microsoft Sans Serif", 16.2F);
            dtpBirthDate.Font = new Font("Microsoft Sans Serif", 13.8F);
            dtpBirthDate.Location = new Point(28, 233);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(309, 34);
            dtpBirthDate.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.ForeColor = Color.FromArgb(245, 239, 235);
            label8.Location = new Point(748, 194);
            label8.Name = "label8";
            label8.Size = new Size(105, 25);
            label8.TabIndex = 21;
            label8.Text = "ID Number";
            // 
            // txtIDNumber
            // 
            txtIDNumber.BackColor = Color.FromArgb(245, 239, 235);
            txtIDNumber.BorderStyle = BorderStyle.FixedSingle;
            txtIDNumber.Location = new Point(747, 222);
            txtIDNumber.Multiline = true;
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(133, 38);
            txtIDNumber.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.ForeColor = Color.FromArgb(245, 239, 235);
            label7.Location = new Point(571, 194);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 19;
            label7.Text = "ID Type";
            // 
            // txtIDType
            // 
            txtIDType.BackColor = Color.FromArgb(245, 239, 235);
            txtIDType.BorderStyle = BorderStyle.FixedSingle;
            txtIDType.Location = new Point(570, 222);
            txtIDType.Multiline = true;
            txtIDType.Name = "txtIDType";
            txtIDType.Size = new Size(133, 38);
            txtIDType.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.ForeColor = Color.FromArgb(245, 239, 235);
            label6.Location = new Point(571, 110);
            label6.Name = "label6";
            label6.Size = new Size(143, 25);
            label6.TabIndex = 17;
            label6.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.FromArgb(245, 239, 235);
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Location = new Point(570, 138);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(310, 38);
            txtPhoneNumber.TabIndex = 16;
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Microsoft Sans Serif", 12F);
            lblLName.ForeColor = Color.FromArgb(245, 239, 235);
            lblLName.Location = new Point(571, 15);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(106, 25);
            lblLName.TabIndex = 15;
            lblLName.Text = "Last Name";
            // 
            // txtLName
            // 
            txtLName.BackColor = Color.FromArgb(245, 239, 235);
            txtLName.BorderStyle = BorderStyle.FixedSingle;
            txtLName.Location = new Point(570, 43);
            txtLName.Multiline = true;
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(310, 38);
            txtLName.TabIndex = 14;
            // 
            // lblDateBirth
            // 
            lblDateBirth.AutoSize = true;
            lblDateBirth.Font = new Font("Microsoft Sans Serif", 12F);
            lblDateBirth.ForeColor = Color.FromArgb(245, 239, 235);
            lblDateBirth.Location = new Point(28, 205);
            lblDateBirth.Name = "lblDateBirth";
            lblDateBirth.Size = new Size(94, 25);
            lblDateBirth.TabIndex = 13;
            lblDateBirth.Text = "Birth date";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 12F);
            lblEmail.ForeColor = Color.FromArgb(245, 239, 235);
            lblEmail.Location = new Point(28, 110);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 25);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(245, 239, 235);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(27, 138);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(310, 38);
            txtEmail.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = Color.FromArgb(245, 239, 235);
            label1.Location = new Point(28, 15);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 9;
            label1.Text = "First Name";
            // 
            // txtFName
            // 
            txtFName.BackColor = Color.FromArgb(245, 239, 235);
            txtFName.BorderStyle = BorderStyle.FixedSingle;
            txtFName.Location = new Point(27, 43);
            txtFName.Multiline = true;
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(310, 38);
            txtFName.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(203, 217, 230);
            btnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSave.Location = new Point(27, 305);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(166, 51);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // splitter2
            // 
            splitter2.BackColor = Color.FromArgb(203, 217, 230);
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(1, 373);
            splitter2.TabIndex = 0;
            splitter2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(12, 536);
            label2.Name = "label2";
            label2.Size = new Size(153, 29);
            label2.TabIndex = 8;
            label2.Text = "Guest details";
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.FromArgb(245, 239, 235);
            btnSelect.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSelect.Location = new Point(806, 127);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(108, 38);
            btnSelect.TabIndex = 9;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // frmGuests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 217, 230);
            ClientSize = new Size(930, 953);
            Controls.Add(btnSelect);
            Controls.Add(label2);
            Controls.Add(pnlGuestDetail);
            Controls.Add(dgvGuests);
            Controls.Add(btnSearch);
            Controls.Add(lblSearch);
            Controls.Add(txtUserID);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGuests";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGuests";
            Load += frmGuests_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).EndInit();
            pnlGuestDetail.ResumeLayout(false);
            pnlGuestDetail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lblGuests;
        private Splitter splitter1;
        private TextBox txtUserID;
        private Label lblSearch;
        private Button btnSearch;
        private DataGridView dgvGuests;
        private Button btnBookings;
        private Panel pnlGuestDetail;
        private Button btnSave;
        private Splitter splitter2;
        private Label label2;
        private TextBox txtFName;
        private Label label1;
        private Label lblDateBirth;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtIDType;
        private Label label6;
        private TextBox txtPhoneNumber;
        private Label lblLName;
        private TextBox txtLName;
        private Label label8;
        private TextBox txtIDNumber;
        private DateTimePicker dtpBirthDate;
        private Button btnViewBooking;
        private Button btnSelect;
    }
}