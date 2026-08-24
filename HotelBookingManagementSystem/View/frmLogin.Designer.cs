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
            panel1 = new Panel();
            label1 = new Label();
            txtUserID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 65, 86);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 124);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 25.8000011F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(245, 239, 235);
            label1.Location = new Point(65, 9);
            label1.Name = "label1";
            label1.Size = new Size(294, 106);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the \r\nHotel California\r\n";
            // 
            // txtUserID
            // 
            txtUserID.BackColor = Color.FromArgb(245, 239, 235);
            txtUserID.BorderStyle = BorderStyle.FixedSingle;
            txtUserID.Font = new Font("Microsoft Sans Serif", 16.2F);
            txtUserID.Location = new Point(50, 206);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(320, 38);
            txtUserID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(50, 181);
            label2.Name = "label2";
            label2.Size = new Size(70, 22);
            label2.TabIndex = 2;
            label2.Text = "User ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(50, 263);
            label3.Name = "label3";
            label3.Size = new Size(89, 22);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(245, 239, 235);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Microsoft Sans Serif", 16.2F);
            txtPassword.Location = new Point(50, 288);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(320, 38);
            txtPassword.TabIndex = 3;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Microsoft Sans Serif", 10.2F);
            chkShowPassword.ForeColor = Color.DimGray;
            chkShowPassword.Location = new Point(50, 332);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(149, 24);
            chkShowPassword.TabIndex = 5;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(47, 65, 86);
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(245, 239, 235);
            btnLogin.Location = new Point(50, 416);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(151, 51);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(245, 239, 235);
            btnCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(219, 416);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 51);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 217, 230);
            ClientSize = new Size(423, 513);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUserID);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtUserID;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private Button btnCancel;
    }
}