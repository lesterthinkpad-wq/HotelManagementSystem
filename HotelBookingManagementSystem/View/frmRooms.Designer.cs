namespace HotelBookingManagementSystem.View
{
    partial class frmRooms
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
            cboFloorSearch = new ComboBox();
            lblSearch = new Label();
            label1 = new Label();
            cboTypesSearch = new ComboBox();
            label2 = new Label();
            cboStatusSearch = new ComboBox();
            dgvRooms = new DataGridView();
            panel1 = new Panel();
            label3 = new Label();
            splitter2 = new Splitter();
            label4 = new Label();
            label5 = new Label();
            cboRoomType = new ComboBox();
            cboStatus = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            btnSave = new Button();
            cboRoomNumber = new ComboBox();
            cboFloor = new ComboBox();
            btnCancel = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
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
            panel2.Size = new Size(916, 82);
            panel2.TabIndex = 3;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Font = new Font("Monotype Corsiva", 16.2F, FontStyle.Bold | FontStyle.Italic);
            lblCurrentUser.ForeColor = Color.FromArgb(245, 239, 235);
            lblCurrentUser.Location = new Point(12, 26);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(85, 34);
            lblCurrentUser.TabIndex = 3;
            lblCurrentUser.Text = "Rooms";
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
            // cboFloorSearch
            // 
            cboFloorSearch.BackColor = Color.FromArgb(245, 239, 235);
            cboFloorSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFloorSearch.Font = new Font("Microsoft Sans Serif", 16.2F);
            cboFloorSearch.FormattingEnabled = true;
            cboFloorSearch.ItemHeight = 31;
            cboFloorSearch.Location = new Point(22, 137);
            cboFloorSearch.Name = "cboFloorSearch";
            cboFloorSearch.Size = new Size(173, 39);
            cboFloorSearch.TabIndex = 4;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Microsoft Sans Serif", 13.8F);
            lblSearch.ForeColor = Color.DimGray;
            lblSearch.Location = new Point(22, 105);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(70, 29);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Floor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(225, 105);
            label1.Name = "label1";
            label1.Size = new Size(80, 29);
            label1.TabIndex = 7;
            label1.Text = "Types";
            // 
            // cboTypesSearch
            // 
            cboTypesSearch.BackColor = Color.FromArgb(245, 239, 235);
            cboTypesSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTypesSearch.Font = new Font("Microsoft Sans Serif", 16.2F);
            cboTypesSearch.FormattingEnabled = true;
            cboTypesSearch.ItemHeight = 31;
            cboTypesSearch.Location = new Point(225, 137);
            cboTypesSearch.Name = "cboTypesSearch";
            cboTypesSearch.Size = new Size(173, 39);
            cboTypesSearch.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(426, 105);
            label2.Name = "label2";
            label2.Size = new Size(79, 29);
            label2.TabIndex = 9;
            label2.Text = "Status";
            // 
            // cboStatusSearch
            // 
            cboStatusSearch.BackColor = Color.FromArgb(245, 239, 235);
            cboStatusSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatusSearch.Font = new Font("Microsoft Sans Serif", 16.2F);
            cboStatusSearch.FormattingEnabled = true;
            cboStatusSearch.ItemHeight = 31;
            cboStatusSearch.Location = new Point(426, 137);
            cboStatusSearch.Name = "cboStatusSearch";
            cboStatusSearch.Size = new Size(173, 39);
            cboStatusSearch.TabIndex = 8;
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AllowUserToDeleteRows = false;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Location = new Point(13, 195);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.Size = new Size(887, 300);
            dgvRooms.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 65, 86);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(cboFloor);
            panel1.Controls.Add(cboRoomNumber);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cboStatus);
            panel1.Controls.Add(cboRoomType);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(splitter2);
            panel1.Location = new Point(12, 544);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 218);
            panel1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 16.2F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.FromArgb(245, 239, 235);
            label3.Location = new Point(12, 10);
            label3.Name = "label3";
            label3.Size = new Size(155, 34);
            label3.TabIndex = 3;
            label3.Text = "Room details";
            // 
            // splitter2
            // 
            splitter2.BackColor = Color.FromArgb(203, 217, 230);
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(1, 218);
            splitter2.TabIndex = 0;
            splitter2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 59);
            label4.Name = "label4";
            label4.Size = new Size(134, 25);
            label4.TabIndex = 20;
            label4.Text = "Room number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(232, 59);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 22;
            label5.Text = "Room type";
            // 
            // cboRoomType
            // 
            cboRoomType.BackColor = Color.FromArgb(245, 239, 235);
            cboRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoomType.Font = new Font("Microsoft Sans Serif", 16.2F);
            cboRoomType.FormattingEnabled = true;
            cboRoomType.ItemHeight = 31;
            cboRoomType.Location = new Point(232, 87);
            cboRoomType.Name = "cboRoomType";
            cboRoomType.Size = new Size(173, 39);
            cboRoomType.TabIndex = 25;
            // 
            // cboStatus
            // 
            cboStatus.BackColor = Color.FromArgb(245, 239, 235);
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Font = new Font("Microsoft Sans Serif", 16.2F);
            cboStatus.FormattingEnabled = true;
            cboStatus.ItemHeight = 31;
            cboStatus.Location = new Point(690, 87);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(173, 39);
            cboStatus.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(470, 59);
            label6.Name = "label6";
            label6.Size = new Size(56, 25);
            label6.TabIndex = 24;
            label6.Text = "Floor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(690, 59);
            label7.Name = "label7";
            label7.Size = new Size(68, 25);
            label7.TabIndex = 27;
            label7.Text = "Status";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(203, 217, 230);
            btnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSave.Location = new Point(12, 159);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(166, 51);
            btnSave.TabIndex = 28;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // cboRoomNumber
            // 
            cboRoomNumber.BackColor = Color.FromArgb(245, 239, 235);
            cboRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoomNumber.Font = new Font("Microsoft Sans Serif", 16.2F);
            cboRoomNumber.FormattingEnabled = true;
            cboRoomNumber.ItemHeight = 31;
            cboRoomNumber.Location = new Point(12, 87);
            cboRoomNumber.Name = "cboRoomNumber";
            cboRoomNumber.Size = new Size(173, 39);
            cboRoomNumber.TabIndex = 30;
            // 
            // cboFloor
            // 
            cboFloor.BackColor = Color.FromArgb(245, 239, 235);
            cboFloor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFloor.Font = new Font("Microsoft Sans Serif", 16.2F);
            cboFloor.FormattingEnabled = true;
            cboFloor.ItemHeight = 31;
            cboFloor.Location = new Point(470, 87);
            cboFloor.Name = "cboFloor";
            cboFloor.Size = new Size(173, 39);
            cboFloor.TabIndex = 31;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(245, 239, 235);
            btnCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(202, 159);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 51);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmRooms
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 217, 230);
            ClientSize = new Size(916, 787);
            Controls.Add(panel1);
            Controls.Add(dgvRooms);
            Controls.Add(label2);
            Controls.Add(cboStatusSearch);
            Controls.Add(label1);
            Controls.Add(cboTypesSearch);
            Controls.Add(lblSearch);
            Controls.Add(cboFloorSearch);
            Controls.Add(panel2);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRooms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRooms";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lblCurrentUser;
        private Splitter splitter1;
        private ComboBox cboFloorSearch;
        private Label lblSearch;
        private Label label1;
        private ComboBox cboTypesSearch;
        private Label label2;
        private ComboBox cboStatusSearch;
        private DataGridView dgvRooms;
        private Panel panel1;
        private Label label3;
        private Splitter splitter2;
        private Label label4;
        private Label label7;
        private ComboBox cboStatus;
        private ComboBox cboRoomType;
        private Label label6;
        private Label label5;
        private Button btnSave;
        private ComboBox cboFloor;
        private ComboBox cboRoomNumber;
        private Button btnCancel;
    }
}