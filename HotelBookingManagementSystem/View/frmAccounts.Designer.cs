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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblAccounts = new Label();
            lblSubtitle = new Label();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            dgvUsers = new DataGridView();
            btnEditUser = new Guna.UI2.WinForms.Guna2Button();
            pnlGuestDetail = new Guna.UI2.WinForms.Guna2Panel();
            lblDetails = new Label();
            lblFName = new Label();
            txtFName = new Guna.UI2.WinForms.Guna2TextBox();
            lblLName = new Label();
            txtLName = new Guna.UI2.WinForms.Guna2TextBox();
            lblEmail = new Label();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            lblPhone = new Label();
            txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            lblPassword = new Label();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            lblRole = new Label();
            txtRole = new Guna.UI2.WinForms.Guna2TextBox();
            lblStatus = new Label();
            txtStatus = new Guna.UI2.WinForms.Guna2TextBox();
            lblUserID = new Label();
            txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            btnClear = new Guna.UI2.WinForms.Guna2Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            pnlGuestDetail.SuspendLayout();
            SuspendLayout();
            //
            // pnlHeader
            //
            pnlHeader.BackColor = Color.FromArgb(47, 65, 86);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblAccounts);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(934, 76);
            pnlHeader.TabIndex = 0;
            //
            // lblAccounts
            //
            lblAccounts.AutoSize = true;
            lblAccounts.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccounts.ForeColor = Color.FromArgb(245, 239, 235);
            lblAccounts.Location = new Point(22, 10);
            lblAccounts.Name = "lblAccounts";
            lblAccounts.Size = new Size(120, 32);
            lblAccounts.TabIndex = 0;
            lblAccounts.Text = "Accounts";
            //
            // lblSubtitle
            //
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(203, 217, 230);
            lblSubtitle.Location = new Point(25, 45);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(200, 19);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage staff user accounts";
            //
            // txtSearch
            //
            txtSearch.BorderColor = Color.FromArgb(160, 180, 200);
            txtSearch.BorderRadius = 8;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.DefaultText = "";
            txtSearch.FillColor = Color.White;
            txtSearch.FocusedState.BorderColor = Color.FromArgb(47, 65, 86);
            txtSearch.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(47, 65, 86);
            txtSearch.Location = new Point(24, 94);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search users...";
            txtSearch.SelectedText = "";
            txtSearch.Size = new Size(420, 42);
            txtSearch.TabIndex = 1;
            //
            // btnSearch
            //
            btnSearch.Animated = true;
            btnSearch.BorderRadius = 8;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FillColor = Color.FromArgb(47, 65, 86);
            btnSearch.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.FromArgb(245, 239, 235);
            btnSearch.HoverState.FillColor = Color.FromArgb(68, 92, 122);
            btnSearch.Location = new Point(456, 94);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 42);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            //
            // dgvUsers
            //
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(47, 65, 86);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(245, 239, 235);
            dataGridViewCellStyle1.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(47, 65, 86);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(245, 239, 235);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeight = 40;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(47, 65, 86);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(203, 217, 230);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(47, 65, 86);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(245, 248, 251);
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = Color.FromArgb(226, 232, 240);
            dgvUsers.Location = new Point(24, 152);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.Height = 34;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(886, 290);
            dgvUsers.TabIndex = 3;
            //
            // btnEditUser
            //
            btnEditUser.Animated = true;
            btnEditUser.BorderRadius = 8;
            btnEditUser.Cursor = Cursors.Hand;
            btnEditUser.FillColor = Color.FromArgb(47, 65, 86);
            btnEditUser.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditUser.ForeColor = Color.FromArgb(245, 239, 235);
            btnEditUser.HoverState.FillColor = Color.FromArgb(68, 92, 122);
            btnEditUser.Location = new Point(24, 454);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(130, 40);
            btnEditUser.TabIndex = 4;
            btnEditUser.Text = "Edit user";
            btnEditUser.Click += btnEditUser_Click;
            //
            // pnlGuestDetail
            //
            pnlGuestDetail.BackColor = Color.Transparent;
            pnlGuestDetail.BorderRadius = 12;
            pnlGuestDetail.Controls.Add(lblDetails);
            pnlGuestDetail.Controls.Add(lblFName);
            pnlGuestDetail.Controls.Add(txtFName);
            pnlGuestDetail.Controls.Add(lblLName);
            pnlGuestDetail.Controls.Add(txtLName);
            pnlGuestDetail.Controls.Add(lblEmail);
            pnlGuestDetail.Controls.Add(txtEmail);
            pnlGuestDetail.Controls.Add(lblPhone);
            pnlGuestDetail.Controls.Add(txtPhoneNumber);
            pnlGuestDetail.Controls.Add(lblPassword);
            pnlGuestDetail.Controls.Add(txtPassword);
            pnlGuestDetail.Controls.Add(lblRole);
            pnlGuestDetail.Controls.Add(txtRole);
            pnlGuestDetail.Controls.Add(lblStatus);
            pnlGuestDetail.Controls.Add(txtStatus);
            pnlGuestDetail.Controls.Add(lblUserID);
            pnlGuestDetail.Controls.Add(txtUserID);
            pnlGuestDetail.Controls.Add(btnSave);
            pnlGuestDetail.Controls.Add(btnClear);
            pnlGuestDetail.FillColor = Color.FromArgb(47, 65, 86);
            pnlGuestDetail.Location = new Point(24, 510);
            pnlGuestDetail.Name = "pnlGuestDetail";
            pnlGuestDetail.Size = new Size(886, 306);
            pnlGuestDetail.TabIndex = 5;
            //
            // lblDetails
            //
            lblDetails.AutoSize = true;
            lblDetails.BackColor = Color.Transparent;
            lblDetails.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetails.ForeColor = Color.FromArgb(245, 239, 235);
            lblDetails.Location = new Point(26, 14);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(116, 25);
            lblDetails.TabIndex = 0;
            lblDetails.Text = "User details";
            //
            // lblFName
            //
            lblFName.AutoSize = true;
            lblFName.BackColor = Color.Transparent;
            lblFName.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFName.ForeColor = Color.FromArgb(203, 217, 230);
            lblFName.Location = new Point(28, 56);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(70, 17);
            lblFName.TabIndex = 1;
            lblFName.Text = "First name";
            //
            // txtFName
            //
            txtFName.BorderColor = Color.FromArgb(203, 217, 230);
            txtFName.BorderRadius = 8;
            txtFName.Cursor = Cursors.IBeam;
            txtFName.DefaultText = "";
            txtFName.FillColor = Color.FromArgb(245, 239, 235);
            txtFName.FocusedState.BorderColor = Color.FromArgb(120, 160, 200);
            txtFName.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFName.ForeColor = Color.FromArgb(47, 65, 86);
            txtFName.Margin = new Padding(3, 4, 3, 4);
            txtFName.SelectedText = "";
            txtFName.Location = new Point(28, 78);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(250, 40);
            txtFName.TabIndex = 2;
            //
            // lblLName
            //
            lblLName.AutoSize = true;
            lblLName.BackColor = Color.Transparent;
            lblLName.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLName.ForeColor = Color.FromArgb(203, 217, 230);
            lblLName.Location = new Point(318, 56);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(70, 17);
            lblLName.TabIndex = 3;
            lblLName.Text = "Last name";
            //
            // txtLName
            //
            txtLName.BorderColor = Color.FromArgb(203, 217, 230);
            txtLName.BorderRadius = 8;
            txtLName.Cursor = Cursors.IBeam;
            txtLName.DefaultText = "";
            txtLName.FillColor = Color.FromArgb(245, 239, 235);
            txtLName.FocusedState.BorderColor = Color.FromArgb(120, 160, 200);
            txtLName.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLName.ForeColor = Color.FromArgb(47, 65, 86);
            txtLName.Margin = new Padding(3, 4, 3, 4);
            txtLName.SelectedText = "";
            txtLName.Location = new Point(318, 78);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(250, 40);
            txtLName.TabIndex = 4;
            //
            // lblEmail
            //
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(203, 217, 230);
            lblEmail.Location = new Point(608, 56);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 17);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            //
            // txtEmail
            //
            txtEmail.BorderColor = Color.FromArgb(203, 217, 230);
            txtEmail.BorderRadius = 8;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.DefaultText = "";
            txtEmail.FillColor = Color.FromArgb(245, 239, 235);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(120, 160, 200);
            txtEmail.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(47, 65, 86);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.SelectedText = "";
            txtEmail.Location = new Point(608, 78);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 40);
            txtEmail.TabIndex = 6;
            //
            // lblPhone
            //
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.FromArgb(203, 217, 230);
            lblPhone.Location = new Point(28, 136);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(95, 17);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Phone number";
            //
            // txtPhoneNumber
            //
            txtPhoneNumber.BorderColor = Color.FromArgb(203, 217, 230);
            txtPhoneNumber.BorderRadius = 8;
            txtPhoneNumber.Cursor = Cursors.IBeam;
            txtPhoneNumber.DefaultText = "";
            txtPhoneNumber.FillColor = Color.FromArgb(245, 239, 235);
            txtPhoneNumber.FocusedState.BorderColor = Color.FromArgb(120, 160, 200);
            txtPhoneNumber.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.ForeColor = Color.FromArgb(47, 65, 86);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.SelectedText = "";
            txtPhoneNumber.Location = new Point(28, 158);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(250, 40);
            txtPhoneNumber.TabIndex = 8;
            //
            // lblPassword
            //
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(203, 217, 230);
            lblPassword.Location = new Point(318, 136);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(63, 17);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password";
            //
            // txtPassword
            //
            txtPassword.BorderColor = Color.FromArgb(203, 217, 230);
            txtPassword.BorderRadius = 8;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.DefaultText = "";
            txtPassword.FillColor = Color.FromArgb(245, 239, 235);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(120, 160, 200);
            txtPassword.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(47, 65, 86);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.SelectedText = "";
            txtPassword.Location = new Point(318, 158);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 40);
            txtPassword.TabIndex = 10;
            //
            // lblRole
            //
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(203, 217, 230);
            lblRole.Location = new Point(608, 136);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(61, 17);
            lblRole.TabIndex = 11;
            lblRole.Text = "User role";
            //
            // txtRole
            //
            txtRole.BorderColor = Color.FromArgb(203, 217, 230);
            txtRole.BorderRadius = 8;
            txtRole.Cursor = Cursors.IBeam;
            txtRole.DefaultText = "";
            txtRole.FillColor = Color.FromArgb(245, 239, 235);
            txtRole.FocusedState.BorderColor = Color.FromArgb(120, 160, 200);
            txtRole.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRole.ForeColor = Color.FromArgb(47, 65, 86);
            txtRole.Margin = new Padding(3, 4, 3, 4);
            txtRole.SelectedText = "";
            txtRole.Location = new Point(608, 158);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(120, 40);
            txtRole.TabIndex = 12;
            //
            // lblStatus
            //
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(203, 217, 230);
            lblStatus.Location = new Point(742, 136);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(44, 17);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status";
            //
            // txtStatus
            //
            txtStatus.BorderColor = Color.FromArgb(203, 217, 230);
            txtStatus.BorderRadius = 8;
            txtStatus.Cursor = Cursors.IBeam;
            txtStatus.DefaultText = "";
            txtStatus.FillColor = Color.FromArgb(245, 239, 235);
            txtStatus.FocusedState.BorderColor = Color.FromArgb(120, 160, 200);
            txtStatus.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStatus.ForeColor = Color.FromArgb(47, 65, 86);
            txtStatus.Margin = new Padding(3, 4, 3, 4);
            txtStatus.SelectedText = "";
            txtStatus.Location = new Point(742, 158);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(116, 40);
            txtStatus.TabIndex = 14;
            //
            // lblUserID (hidden, holds the selected user's id)
            //
            lblUserID.AutoSize = true;
            lblUserID.BackColor = Color.Transparent;
            lblUserID.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = Color.FromArgb(203, 217, 230);
            lblUserID.Location = new Point(400, 226);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(48, 17);
            lblUserID.TabIndex = 15;
            lblUserID.Text = "User ID";
            lblUserID.Visible = false;
            //
            // txtUserID (hidden)
            //
            txtUserID.BorderColor = Color.FromArgb(203, 217, 230);
            txtUserID.BorderRadius = 8;
            txtUserID.Cursor = Cursors.IBeam;
            txtUserID.DefaultText = "";
            txtUserID.FillColor = Color.FromArgb(245, 239, 235);
            txtUserID.FocusedState.BorderColor = Color.FromArgb(120, 160, 200);
            txtUserID.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserID.ForeColor = Color.FromArgb(47, 65, 86);
            txtUserID.Margin = new Padding(3, 4, 3, 4);
            txtUserID.SelectedText = "";
            txtUserID.Location = new Point(400, 248);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(120, 40);
            txtUserID.TabIndex = 16;
            txtUserID.Visible = false;
            //
            // btnSave
            //
            btnSave.Animated = true;
            btnSave.BorderRadius = 8;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FillColor = Color.FromArgb(203, 217, 230);
            btnSave.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(47, 65, 86);
            btnSave.HoverState.FillColor = Color.FromArgb(245, 239, 235);
            btnSave.Location = new Point(28, 242);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 44);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            //
            // btnClear
            //
            btnClear.Animated = true;
            btnClear.BorderColor = Color.FromArgb(203, 217, 230);
            btnClear.BorderRadius = 8;
            btnClear.BorderThickness = 1;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FillColor = Color.FromArgb(47, 65, 86);
            btnClear.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.FromArgb(245, 239, 235);
            btnClear.HoverState.FillColor = Color.FromArgb(68, 92, 122);
            btnClear.Location = new Point(192, 242);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 44);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            //
            // frmAccounts
            //
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(203, 217, 230);
            ClientSize = new Size(934, 840);
            Controls.Add(pnlGuestDetail);
            Controls.Add(btnEditUser);
            Controls.Add(dgvUsers);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAccounts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accounts";
            Load += frmAccounts_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            pnlGuestDetail.ResumeLayout(false);
            pnlGuestDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblAccounts;
        private Label lblSubtitle;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private DataGridView dgvUsers;
        private Guna.UI2.WinForms.Guna2Button btnEditUser;
        private Guna.UI2.WinForms.Guna2Panel pnlGuestDetail;
        private Label lblDetails;
        private Label lblFName;
        private Guna.UI2.WinForms.Guna2TextBox txtFName;
        private Label lblLName;
        private Guna.UI2.WinForms.Guna2TextBox txtLName;
        private Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Label lblPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Label lblRole;
        private Guna.UI2.WinForms.Guna2TextBox txtRole;
        private Label lblStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtStatus;
        private Label lblUserID;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClear;
    }
}