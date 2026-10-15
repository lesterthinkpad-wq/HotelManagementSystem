namespace HotelBookingManagementSystem.View
{
    partial class frmLogin
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
            components = new System.ComponentModel.Container();
            elipseForm = new Guna.UI2.WinForms.Guna2Elipse(components);
            dragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlLeft = new Guna.UI2.WinForms.Guna2Panel();
            pnlAccent = new Guna.UI2.WinForms.Guna2Panel();
            lblBrand = new Label();
            lblTagline = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblUserID = new Label();
            txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            lblPassword = new Label();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            chkShowPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            pnlLeft.SuspendLayout();
            SuspendLayout();
            //
            // elipseForm (rounded window corners)
            //
            elipseForm.BorderRadius = 16;
            elipseForm.TargetControl = this;
            //
            // dragControl (drag the window by the left panel)
            //
            dragControl.TargetControl = pnlLeft;
            //
            // pnlLeft
            //
            pnlLeft.BackColor = Color.FromArgb(47, 65, 86);
            pnlLeft.Controls.Add(pnlAccent);
            pnlLeft.Controls.Add(lblBrand);
            pnlLeft.Controls.Add(lblTagline);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(290, 470);
            pnlLeft.TabIndex = 0;
            //
            // pnlAccent
            //
            pnlAccent.BackColor = Color.Transparent;
            pnlAccent.BorderRadius = 2;
            pnlAccent.FillColor = Color.FromArgb(203, 217, 230);
            pnlAccent.Location = new Point(32, 262);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new Size(56, 4);
            pnlAccent.TabIndex = 2;
            //
            // lblBrand
            //
            lblBrand.BackColor = Color.Transparent;
            lblBrand.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrand.ForeColor = Color.FromArgb(245, 239, 235);
            lblBrand.Location = new Point(26, 150);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(250, 104);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "Hotel" + Environment.NewLine + "California";
            //
            // lblTagline
            //
            lblTagline.BackColor = Color.Transparent;
            lblTagline.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTagline.ForeColor = Color.FromArgb(203, 217, 230);
            lblTagline.Location = new Point(32, 278);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(240, 52);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "Booking Management System";
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(47, 65, 86);
            lblTitle.Location = new Point(346, 52);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(210, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Welcome back";
            //
            // lblSubtitle
            //
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(349, 100);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(160, 19);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Sign in to your account";
            //
            // lblUserID
            //
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = Color.FromArgb(47, 65, 86);
            lblUserID.Location = new Point(349, 152);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(58, 19);
            lblUserID.TabIndex = 3;
            lblUserID.Text = "User ID";
            //
            // txtUserID
            //
            txtUserID.BorderColor = Color.FromArgb(203, 217, 230);
            txtUserID.BorderRadius = 8;
            txtUserID.Cursor = Cursors.IBeam;
            txtUserID.DefaultText = "";
            txtUserID.FillColor = Color.White;
            txtUserID.FocusedState.BorderColor = Color.FromArgb(47, 65, 86);
            txtUserID.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserID.ForeColor = Color.FromArgb(47, 65, 86);
            txtUserID.Location = new Point(349, 176);
            txtUserID.Margin = new Padding(3, 4, 3, 4);
            txtUserID.Name = "txtUserID";
            txtUserID.PlaceholderText = "Enter your user ID";
            txtUserID.SelectedText = "";
            txtUserID.Size = new Size(370, 46);
            txtUserID.TabIndex = 4;
            //
            // lblPassword
            //
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(47, 65, 86);
            lblPassword.Location = new Point(349, 236);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 19);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            //
            // txtPassword
            //
            txtPassword.BorderColor = Color.FromArgb(203, 217, 230);
            txtPassword.BorderRadius = 8;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.DefaultText = "";
            txtPassword.FillColor = Color.White;
            txtPassword.FocusedState.BorderColor = Color.FromArgb(47, 65, 86);
            txtPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(47, 65, 86);
            txtPassword.Location = new Point(349, 260);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.SelectedText = "";
            txtPassword.Size = new Size(370, 46);
            txtPassword.TabIndex = 6;
            //
            // chkShowPassword
            //
            chkShowPassword.AutoSize = true;
            chkShowPassword.CheckedState.BorderColor = Color.FromArgb(47, 65, 86);
            chkShowPassword.CheckedState.BorderRadius = 3;
            chkShowPassword.CheckedState.BorderThickness = 0;
            chkShowPassword.CheckedState.FillColor = Color.FromArgb(47, 65, 86);
            chkShowPassword.CheckMarkColor = Color.White;
            chkShowPassword.Cursor = Cursors.Hand;
            chkShowPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = Color.DimGray;
            chkShowPassword.Location = new Point(351, 320);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(128, 21);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkShowPassword.UncheckedState.BorderRadius = 3;
            chkShowPassword.UncheckedState.BorderThickness = 1;
            chkShowPassword.UncheckedState.FillColor = Color.White;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            //
            // btnLogin
            //
            btnLogin.Animated = true;
            btnLogin.BorderRadius = 8;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FillColor = Color.FromArgb(47, 65, 86);
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(245, 239, 235);
            btnLogin.HoverState.FillColor = Color.FromArgb(68, 92, 122);
            btnLogin.Location = new Point(349, 366);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(178, 46);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            //
            // btnCancel
            //
            btnCancel.Animated = true;
            btnCancel.BorderColor = Color.FromArgb(203, 217, 230);
            btnCancel.BorderRadius = 8;
            btnCancel.BorderThickness = 1;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FillColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(47, 65, 86);
            btnCancel.HoverState.FillColor = Color.FromArgb(203, 217, 230);
            btnCancel.Location = new Point(541, 366);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(178, 46);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            //
            // frmLogin
            //
            AcceptButton = btnLogin;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(245, 239, 235);
            ClientSize = new Size(760, 470);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserID);
            Controls.Add(lblUserID);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            pnlLeft.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseForm;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2Panel pnlLeft;
        private Guna.UI2.WinForms.Guna2Panel pnlAccent;
        private Label lblBrand;
        private Label lblTagline;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblUserID;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2CheckBox chkShowPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}