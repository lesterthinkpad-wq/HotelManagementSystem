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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnSelect = new Button();
            label2 = new Label();
            pnlGuestDetail = new Panel();
            txtGuestID = new TextBox();
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
            dgvGuests = new DataGridView();
            btnSearch = new Button();
            txtUserID = new TextBox();
            panel5 = new Panel();
            button1 = new Button();
            lblGuests = new Label();
            splitter3 = new Splitter();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            pnlGuestDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.FromArgb(245, 239, 235);
            btnSelect.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSelect.Location = new Point(246, 465);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(122, 38);
            btnSelect.TabIndex = 23;
            btnSelect.Text = "Edit guest";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(246, 533);
            label2.Name = "label2";
            label2.Size = new Size(153, 29);
            label2.TabIndex = 22;
            label2.Text = "Guest details";
            // 
            // pnlGuestDetail
            // 
            pnlGuestDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlGuestDetail.BackColor = Color.FromArgb(47, 65, 86);
            pnlGuestDetail.Controls.Add(txtGuestID);
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
            pnlGuestDetail.Location = new Point(246, 565);
            pnlGuestDetail.Name = "pnlGuestDetail";
            pnlGuestDetail.Size = new Size(1153, 332);
            pnlGuestDetail.TabIndex = 21;
            // 
            // txtGuestID
            // 
            txtGuestID.Anchor = AnchorStyles.Left;
            txtGuestID.BackColor = Color.FromArgb(245, 239, 235);
            txtGuestID.BorderStyle = BorderStyle.FixedSingle;
            txtGuestID.Location = new Point(1070, 45);
            txtGuestID.Multiline = true;
            txtGuestID.Name = "txtGuestID";
            txtGuestID.ReadOnly = true;
            txtGuestID.Size = new Size(80, 38);
            txtGuestID.TabIndex = 73;
            txtGuestID.Visible = false;
            // 
            // btnViewBooking
            // 
            btnViewBooking.Anchor = AnchorStyles.Left;
            btnViewBooking.BackColor = Color.FromArgb(245, 239, 235);
            btnViewBooking.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnViewBooking.Location = new Point(199, 273);
            btnViewBooking.Name = "btnViewBooking";
            btnViewBooking.Size = new Size(225, 51);
            btnViewBooking.TabIndex = 23;
            btnViewBooking.Text = "View booking history";
            btnViewBooking.UseVisualStyleBackColor = false;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Anchor = AnchorStyles.Left;
            dtpBirthDate.CalendarFont = new Font("Microsoft Sans Serif", 16.2F);
            dtpBirthDate.CustomFormat = "dd, MMMM, yyyy";
            dtpBirthDate.Font = new Font("Microsoft Sans Serif", 13.8F);
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(28, 201);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(309, 34);
            dtpBirthDate.TabIndex = 22;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.ForeColor = Color.FromArgb(245, 239, 235);
            label8.Location = new Point(822, 162);
            label8.Name = "label8";
            label8.Size = new Size(105, 25);
            label8.TabIndex = 21;
            label8.Text = "ID Number";
            // 
            // txtIDNumber
            // 
            txtIDNumber.Anchor = AnchorStyles.Left;
            txtIDNumber.BackColor = Color.FromArgb(245, 239, 235);
            txtIDNumber.BorderStyle = BorderStyle.FixedSingle;
            txtIDNumber.Location = new Point(821, 190);
            txtIDNumber.Multiline = true;
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(133, 38);
            txtIDNumber.TabIndex = 20;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.ForeColor = Color.FromArgb(245, 239, 235);
            label7.Location = new Point(645, 162);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 19;
            label7.Text = "ID Type";
            // 
            // txtIDType
            // 
            txtIDType.Anchor = AnchorStyles.Left;
            txtIDType.BackColor = Color.FromArgb(245, 239, 235);
            txtIDType.BorderStyle = BorderStyle.FixedSingle;
            txtIDType.Location = new Point(644, 190);
            txtIDType.Multiline = true;
            txtIDType.Name = "txtIDType";
            txtIDType.Size = new Size(133, 38);
            txtIDType.TabIndex = 18;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.ForeColor = Color.FromArgb(245, 239, 235);
            label6.Location = new Point(645, 90);
            label6.Name = "label6";
            label6.Size = new Size(143, 25);
            label6.TabIndex = 17;
            label6.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Left;
            txtPhoneNumber.BackColor = Color.FromArgb(245, 239, 235);
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Location = new Point(644, 118);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(380, 38);
            txtPhoneNumber.TabIndex = 16;
            // 
            // lblLName
            // 
            lblLName.Anchor = AnchorStyles.Left;
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Microsoft Sans Serif", 12F);
            lblLName.ForeColor = Color.FromArgb(245, 239, 235);
            lblLName.Location = new Point(645, 17);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(106, 25);
            lblLName.TabIndex = 15;
            lblLName.Text = "Last Name";
            // 
            // txtLName
            // 
            txtLName.Anchor = AnchorStyles.Left;
            txtLName.BackColor = Color.FromArgb(245, 239, 235);
            txtLName.BorderStyle = BorderStyle.FixedSingle;
            txtLName.Location = new Point(644, 45);
            txtLName.Multiline = true;
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(380, 38);
            txtLName.TabIndex = 14;
            // 
            // lblDateBirth
            // 
            lblDateBirth.Anchor = AnchorStyles.Left;
            lblDateBirth.AutoSize = true;
            lblDateBirth.Font = new Font("Microsoft Sans Serif", 12F);
            lblDateBirth.ForeColor = Color.FromArgb(245, 239, 235);
            lblDateBirth.Location = new Point(28, 173);
            lblDateBirth.Name = "lblDateBirth";
            lblDateBirth.Size = new Size(94, 25);
            lblDateBirth.TabIndex = 13;
            lblDateBirth.Text = "Birth date";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 12F);
            lblEmail.ForeColor = Color.FromArgb(245, 239, 235);
            lblEmail.Location = new Point(28, 90);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 25);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left;
            txtEmail.BackColor = Color.FromArgb(245, 239, 235);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(27, 118);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(380, 38);
            txtEmail.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = Color.FromArgb(245, 239, 235);
            label1.Location = new Point(28, 17);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 9;
            label1.Text = "First Name";
            // 
            // txtFName
            // 
            txtFName.Anchor = AnchorStyles.Left;
            txtFName.BackColor = Color.FromArgb(245, 239, 235);
            txtFName.BorderStyle = BorderStyle.FixedSingle;
            txtFName.Location = new Point(27, 45);
            txtFName.Multiline = true;
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(380, 38);
            txtFName.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Left;
            btnSave.BackColor = Color.FromArgb(203, 217, 230);
            btnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSave.Location = new Point(27, 273);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(166, 51);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // splitter2
            // 
            splitter2.BackColor = Color.FromArgb(203, 217, 230);
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(1, 332);
            splitter2.TabIndex = 0;
            splitter2.TabStop = false;
            // 
            // dgvGuests
            // 
            dgvGuests.AllowUserToAddRows = false;
            dgvGuests.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvGuests.DefaultCellStyle = dataGridViewCellStyle2;
            dgvGuests.Location = new Point(246, 159);
            dgvGuests.Name = "dgvGuests";
            dgvGuests.ReadOnly = true;
            dgvGuests.RowHeadersWidth = 51;
            dgvGuests.Size = new Size(1153, 300);
            dgvGuests.TabIndex = 20;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(245, 239, 235);
            btnSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSearch.Location = new Point(639, 115);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 38);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtUserID
            // 
            txtUserID.BackColor = Color.FromArgb(245, 239, 235);
            txtUserID.BorderStyle = BorderStyle.FixedSingle;
            txtUserID.Location = new Point(246, 115);
            txtUserID.Multiline = true;
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(387, 38);
            txtUserID.TabIndex = 18;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(47, 65, 86);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(lblGuests);
            panel5.Controls.Add(splitter3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1718, 82);
            panel5.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(203, 217, 230);
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.Location = new Point(1516, 18);
            button1.Name = "button1";
            button1.Size = new Size(194, 51);
            button1.TabIndex = 4;
            button1.Text = "Bookings";
            button1.UseVisualStyleBackColor = false;
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
            // splitter3
            // 
            splitter3.BackColor = Color.FromArgb(203, 217, 230);
            splitter3.Location = new Point(0, 0);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(1, 82);
            splitter3.TabIndex = 0;
            splitter3.TabStop = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BorderRadius = 5;
            btnRefresh.CustomizableEdges = customizableEdges1;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.FromArgb(47, 65, 86);
            btnRefresh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(374, 465);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnRefresh.Size = new Size(110, 38);
            btnRefresh.TabIndex = 24;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // GuestControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 217, 230);
            Controls.Add(btnRefresh);
            Controls.Add(btnSelect);
            Controls.Add(label2);
            Controls.Add(pnlGuestDetail);
            Controls.Add(dgvGuests);
            Controls.Add(btnSearch);
            Controls.Add(txtUserID);
            Controls.Add(panel5);
            Name = "GuestControls";
            Size = new Size(1718, 915);
            pnlGuestDetail.ResumeLayout(false);
            pnlGuestDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelect;
        private Label label2;
        private Panel pnlGuestDetail;
        private Button btnViewBooking;
        private DateTimePicker dtpBirthDate;
        private Label label8;
        private TextBox txtIDNumber;
        private Label label7;
        private TextBox txtIDType;
        private Label label6;
        private TextBox txtPhoneNumber;
        private Label lblLName;
        private TextBox txtLName;
        private Label lblDateBirth;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtFName;
        private Button btnSave;
        private Splitter splitter2;
        private Button btnSearch;
        private TextBox txtUserID;
        private Panel panel5;
        private Button button1;
        private Label lblGuests;
        private Splitter splitter3;
        private TextBox txtGuestID;
        public DataGridView dgvGuests;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}
