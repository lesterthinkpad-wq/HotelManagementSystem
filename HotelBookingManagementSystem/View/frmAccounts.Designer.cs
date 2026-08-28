namespace HotelBookingManagementSystem.View
{
    partial class frmAccounts
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
            panel2 = new Panel();
            lblAccounts = new Label();
            splitter1 = new Splitter();
            btnEditUser = new Button();
            dgvUsers = new DataGridView();
            btnSearch = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            pnlGuestDetail = new Panel();
            txtStatus = new TextBox();
            txtRole = new TextBox();
            label7 = new Label();
            txtUserID = new TextBox();
            btnClear = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtPhoneNumber = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            lblLName = new Label();
            txtLName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            txtFName = new TextBox();
            btnSave = new Button();
            splitter2 = new Splitter();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            pnlGuestDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(47, 65, 86);
            panel2.Controls.Add(lblAccounts);
            panel2.Controls.Add(splitter1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 82);
            panel2.TabIndex = 4;
            // 
            // lblAccounts
            // 
            lblAccounts.AutoSize = true;
            lblAccounts.Font = new Font("Monotype Corsiva", 16.2F, FontStyle.Bold | FontStyle.Italic);
            lblAccounts.ForeColor = Color.FromArgb(245, 239, 235);
            lblAccounts.Location = new Point(12, 26);
            lblAccounts.Name = "lblAccounts";
            lblAccounts.Size = new Size(115, 34);
            lblAccounts.TabIndex = 3;
            lblAccounts.Text = "Accounts";
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
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.FromArgb(245, 239, 235);
            btnEditUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditUser.ForeColor = Color.Black;
            btnEditUser.Location = new Point(12, 474);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(115, 34);
            btnEditUser.TabIndex = 33;
            btnEditUser.Text = "Edit user";
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.Location = new Point(12, 168);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(910, 300);
            dgvUsers.TabIndex = 34;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(245, 239, 235);
            btnSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSearch.Location = new Point(405, 124);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 38);
            btnSearch.TabIndex = 37;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Microsoft Sans Serif", 13.8F);
            lblSearch.ForeColor = Color.DimGray;
            lblSearch.Location = new Point(12, 92);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(89, 29);
            lblSearch.TabIndex = 36;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(245, 239, 235);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(12, 124);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(387, 38);
            txtSearch.TabIndex = 35;
            // 
            // pnlGuestDetail
            // 
            pnlGuestDetail.BackColor = Color.FromArgb(47, 65, 86);
            pnlGuestDetail.Controls.Add(txtStatus);
            pnlGuestDetail.Controls.Add(txtRole);
            pnlGuestDetail.Controls.Add(label7);
            pnlGuestDetail.Controls.Add(txtUserID);
            pnlGuestDetail.Controls.Add(btnClear);
            pnlGuestDetail.Controls.Add(label5);
            pnlGuestDetail.Controls.Add(label4);
            pnlGuestDetail.Controls.Add(label2);
            pnlGuestDetail.Controls.Add(txtPhoneNumber);
            pnlGuestDetail.Controls.Add(label3);
            pnlGuestDetail.Controls.Add(txtPassword);
            pnlGuestDetail.Controls.Add(label6);
            pnlGuestDetail.Controls.Add(lblLName);
            pnlGuestDetail.Controls.Add(txtLName);
            pnlGuestDetail.Controls.Add(lblEmail);
            pnlGuestDetail.Controls.Add(txtEmail);
            pnlGuestDetail.Controls.Add(label1);
            pnlGuestDetail.Controls.Add(txtFName);
            pnlGuestDetail.Controls.Add(btnSave);
            pnlGuestDetail.Controls.Add(splitter2);
            pnlGuestDetail.Location = new Point(12, 540);
            pnlGuestDetail.Name = "pnlGuestDetail";
            pnlGuestDetail.Size = new Size(910, 305);
            pnlGuestDetail.TabIndex = 38;
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.FromArgb(245, 239, 235);
            txtStatus.BorderStyle = BorderStyle.FixedSingle;
            txtStatus.Location = new Point(764, 154);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(115, 38);
            txtStatus.TabIndex = 39;
            // 
            // txtRole
            // 
            txtRole.BackColor = Color.FromArgb(245, 239, 235);
            txtRole.BorderStyle = BorderStyle.FixedSingle;
            txtRole.Location = new Point(624, 154);
            txtRole.Multiline = true;
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(115, 38);
            txtRole.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.ForeColor = Color.FromArgb(245, 239, 235);
            label7.Location = new Point(623, 204);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 37;
            label7.Text = "User ID";
            label7.Visible = false;
            // 
            // txtUserID
            // 
            txtUserID.BackColor = Color.FromArgb(245, 239, 235);
            txtUserID.BorderStyle = BorderStyle.FixedSingle;
            txtUserID.Location = new Point(623, 232);
            txtUserID.Multiline = true;
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(115, 38);
            txtUserID.TabIndex = 36;
            txtUserID.Visible = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(245, 239, 235);
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(203, 232);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(164, 51);
            btnClear.TabIndex = 35;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(4, 3);
            label5.Name = "label5";
            label5.Size = new Size(153, 29);
            label5.TabIndex = 34;
            label5.Text = "User details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.ForeColor = Color.FromArgb(245, 239, 235);
            label4.Location = new Point(764, 126);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 32;
            label4.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.FromArgb(245, 239, 235);
            label2.Location = new Point(29, 126);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 27;
            label2.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.FromArgb(245, 239, 235);
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Location = new Point(28, 154);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(257, 38);
            txtPhoneNumber.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.ForeColor = Color.FromArgb(245, 239, 235);
            label3.Location = new Point(329, 126);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 25;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(245, 239, 235);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(329, 154);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(256, 38);
            txtPassword.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.ForeColor = Color.FromArgb(245, 239, 235);
            label6.Location = new Point(623, 126);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 17;
            label6.Text = "User role";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Microsoft Sans Serif", 12F);
            lblLName.ForeColor = Color.FromArgb(245, 239, 235);
            lblLName.Location = new Point(329, 45);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(106, 25);
            lblLName.TabIndex = 15;
            lblLName.Text = "Last Name";
            // 
            // txtLName
            // 
            txtLName.BackColor = Color.FromArgb(245, 239, 235);
            txtLName.BorderStyle = BorderStyle.FixedSingle;
            txtLName.Location = new Point(329, 73);
            txtLName.Multiline = true;
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(256, 38);
            txtLName.TabIndex = 14;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 12F);
            lblEmail.ForeColor = Color.FromArgb(245, 239, 235);
            lblEmail.Location = new Point(624, 45);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 25);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(245, 239, 235);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(623, 73);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(256, 38);
            txtEmail.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = Color.FromArgb(245, 239, 235);
            label1.Location = new Point(28, 45);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 9;
            label1.Text = "First Name";
            // 
            // txtFName
            // 
            txtFName.BackColor = Color.FromArgb(245, 239, 235);
            txtFName.BorderStyle = BorderStyle.FixedSingle;
            txtFName.Location = new Point(27, 73);
            txtFName.Multiline = true;
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(256, 38);
            txtFName.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(203, 217, 230);
            btnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSave.Location = new Point(31, 232);
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
            splitter2.Size = new Size(1, 305);
            splitter2.TabIndex = 0;
            splitter2.TabStop = false;
            // 
            // frmAccounts
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 217, 230);
            ClientSize = new Size(934, 853);
            Controls.Add(pnlGuestDetail);
            Controls.Add(btnSearch);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvUsers);
            Controls.Add(btnEditUser);
            Controls.Add(panel2);
            Font = new Font("Microsoft Sans Serif", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAccounts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAccounts";
            Load += frmAccounts_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            pnlGuestDetail.ResumeLayout(false);
            pnlGuestDetail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lblAccounts;
        private Splitter splitter1;
        private Button btnEditUser;
        private DataGridView dgvUsers;
        private Button btnSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Panel pnlGuestDetail;
        private Label label6;
        private Label lblLName;
        private TextBox txtLName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtFName;
        private Button btnSave;
        private Splitter splitter2;
        private Label label2;
        private TextBox txtPhoneNumber;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private Label label5;
        private Button btnClear;
        private Label label7;
        private TextBox txtUserID;
        private TextBox txtStatus;
        private TextBox txtRole;
    }
}