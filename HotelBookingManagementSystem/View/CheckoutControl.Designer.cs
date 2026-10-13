namespace HotelBookingManagementSystem.View
{
    partial class CheckoutControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblCheckedIn = new Label();
            lblSearch = new Label();
            dgvCheckedIn = new DataGridView();
            pnlDetails = new Panel();
            label1 = new Label();
            cboPaymentMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            txtBookingID = new Guna.UI2.WinForms.Guna2TextBox();
            txtPayment = new Guna.UI2.WinForms.Guna2TextBox();
            lblDetailsTitle = new Label();
            lblRefCaption = new Label();
            lblRefValue = new Label();
            lblGuestCaption = new Label();
            lblGuestValue = new Label();
            lblPhoneCaption = new Label();
            lblPhoneValue = new Label();
            lblRoomCaption = new Label();
            lblRoomValue = new Label();
            lblCheckInCaption = new Label();
            lblCheckInValue = new Label();
            lblCheckOutCaption = new Label();
            lblCheckOutValue = new Label();
            lblNightsCaption = new Label();
            lblNightsValue = new Label();
            lblGuestsCaption = new Label();
            lblGuestsValue = new Label();
            lblTotalCaption = new Label();
            lblTotalValue = new Label();
            chkPaymentReceived = new CheckBox();
            btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            btnClear = new Guna.UI2.WinForms.Guna2Button();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCheckedIn).BeginInit();
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(47, 65, 86);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1718, 90);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Monotype Corsiva", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(245, 239, 235);
            lblTitle.Location = new Point(23, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(147, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Check out";
            // 
            // lblCheckedIn
            // 
            lblCheckedIn.AutoSize = true;
            lblCheckedIn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            lblCheckedIn.ForeColor = Color.DimGray;
            lblCheckedIn.Location = new Point(139, 97);
            lblCheckedIn.Name = "lblCheckedIn";
            lblCheckedIn.Size = new Size(246, 29);
            lblCheckedIn.TabIndex = 1;
            lblCheckedIn.Text = "Guests to Check out";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblSearch.ForeColor = Color.DimGray;
            lblSearch.Location = new Point(135, 207);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 20);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search";
            // 
            // dgvCheckedIn
            // 
            dgvCheckedIn.AllowUserToAddRows = false;
            dgvCheckedIn.AllowUserToDeleteRows = false;
            dgvCheckedIn.AllowUserToResizeRows = false;
            dgvCheckedIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckedIn.BackgroundColor = Color.White;
            dgvCheckedIn.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCheckedIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCheckedIn.ColumnHeadersHeight = 34;
            dgvCheckedIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCheckedIn.EnableHeadersVisualStyles = false;
            dgvCheckedIn.GridColor = Color.FromArgb(203, 217, 230);
            dgvCheckedIn.Location = new Point(135, 198);
            dgvCheckedIn.MultiSelect = false;
            dgvCheckedIn.Name = "dgvCheckedIn";
            dgvCheckedIn.ReadOnly = true;
            dgvCheckedIn.RowHeadersVisible = false;
            dgvCheckedIn.RowHeadersWidth = 51;
            dgvCheckedIn.RowTemplate.Height = 30;
            dgvCheckedIn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCheckedIn.Size = new Size(1002, 588);
            dgvCheckedIn.TabIndex = 5;
            dgvCheckedIn.CellContentClick += dgvCheckedIn_CellContentClick;
            // 
            // pnlDetails
            // 
            pnlDetails.BackColor = Color.FromArgb(245, 239, 235);
            pnlDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlDetails.Controls.Add(label1);
            pnlDetails.Controls.Add(cboPaymentMethod);
            pnlDetails.Controls.Add(txtBookingID);
            pnlDetails.Controls.Add(txtPayment);
            pnlDetails.Controls.Add(lblDetailsTitle);
            pnlDetails.Controls.Add(lblRefCaption);
            pnlDetails.Controls.Add(lblRefValue);
            pnlDetails.Controls.Add(lblGuestCaption);
            pnlDetails.Controls.Add(lblGuestValue);
            pnlDetails.Controls.Add(lblPhoneCaption);
            pnlDetails.Controls.Add(lblPhoneValue);
            pnlDetails.Controls.Add(lblRoomCaption);
            pnlDetails.Controls.Add(lblRoomValue);
            pnlDetails.Controls.Add(lblCheckInCaption);
            pnlDetails.Controls.Add(lblCheckInValue);
            pnlDetails.Controls.Add(lblCheckOutCaption);
            pnlDetails.Controls.Add(lblCheckOutValue);
            pnlDetails.Controls.Add(lblNightsCaption);
            pnlDetails.Controls.Add(lblNightsValue);
            pnlDetails.Controls.Add(lblGuestsCaption);
            pnlDetails.Controls.Add(lblGuestsValue);
            pnlDetails.Controls.Add(lblTotalCaption);
            pnlDetails.Controls.Add(lblTotalValue);
            pnlDetails.Controls.Add(chkPaymentReceived);
            pnlDetails.Location = new Point(1163, 198);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(426, 588);
            pnlDetails.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(18, 515);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 24;
            label1.Text = "Payment method";
            // 
            // cboPaymentMethod
            // 
            cboPaymentMethod.BackColor = Color.Transparent;
            cboPaymentMethod.BorderRadius = 10;
            cboPaymentMethod.CustomizableEdges = customizableEdges1;
            cboPaymentMethod.DrawMode = DrawMode.OwnerDrawFixed;
            cboPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaymentMethod.FocusedColor = Color.FromArgb(94, 148, 255);
            cboPaymentMethod.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboPaymentMethod.Font = new Font("Segoe UI", 10F);
            cboPaymentMethod.ForeColor = Color.FromArgb(68, 88, 112);
            cboPaymentMethod.ItemHeight = 30;
            cboPaymentMethod.Items.AddRange(new object[] { "cash", "credit_card", "debit_card", "bank_transfer", "online" });
            cboPaymentMethod.Location = new Point(18, 538);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cboPaymentMethod.Size = new Size(386, 36);
            cboPaymentMethod.TabIndex = 22;
            // 
            // txtBookingID
            // 
            txtBookingID.BorderRadius = 10;
            txtBookingID.CustomizableEdges = customizableEdges3;
            txtBookingID.DefaultText = "";
            txtBookingID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBookingID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBookingID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBookingID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBookingID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBookingID.Font = new Font("Microsoft Sans Serif", 12F);
            txtBookingID.ForeColor = Color.Black;
            txtBookingID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBookingID.Location = new Point(318, 36);
            txtBookingID.Margin = new Padding(4, 5, 4, 5);
            txtBookingID.Name = "txtBookingID";
            txtBookingID.PlaceholderForeColor = Color.Gray;
            txtBookingID.PlaceholderText = "";
            txtBookingID.SelectedText = "";
            txtBookingID.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtBookingID.Size = new Size(102, 27);
            txtBookingID.TabIndex = 21;
            txtBookingID.Visible = false;
            // 
            // txtPayment
            // 
            txtPayment.BorderRadius = 10;
            txtPayment.CustomizableEdges = customizableEdges5;
            txtPayment.DefaultText = "";
            txtPayment.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPayment.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPayment.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPayment.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPayment.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPayment.Font = new Font("Microsoft Sans Serif", 12F);
            txtPayment.ForeColor = Color.Black;
            txtPayment.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPayment.Location = new Point(18, 445);
            txtPayment.Margin = new Padding(4, 5, 4, 5);
            txtPayment.Name = "txtPayment";
            txtPayment.PlaceholderForeColor = Color.Gray;
            txtPayment.PlaceholderText = "Payment amount";
            txtPayment.SelectedText = "";
            txtPayment.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPayment.Size = new Size(386, 49);
            txtPayment.TabIndex = 20;
            // 
            // lblDetailsTitle
            // 
            lblDetailsTitle.AutoSize = true;
            lblDetailsTitle.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            lblDetailsTitle.ForeColor = Color.FromArgb(47, 65, 86);
            lblDetailsTitle.Location = new Point(18, 16);
            lblDetailsTitle.Name = "lblDetailsTitle";
            lblDetailsTitle.Size = new Size(194, 29);
            lblDetailsTitle.TabIndex = 0;
            lblDetailsTitle.Text = "Booking details";
            // 
            // lblRefCaption
            // 
            lblRefCaption.AutoSize = true;
            lblRefCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblRefCaption.ForeColor = Color.DimGray;
            lblRefCaption.Location = new Point(18, 70);
            lblRefCaption.Name = "lblRefCaption";
            lblRefCaption.Size = new Size(95, 20);
            lblRefCaption.TabIndex = 1;
            lblRefCaption.Text = "Reference";
            // 
            // lblRefValue
            // 
            lblRefValue.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblRefValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblRefValue.Location = new Point(150, 68);
            lblRefValue.Name = "lblRefValue";
            lblRefValue.Size = new Size(218, 24);
            lblRefValue.TabIndex = 2;
            lblRefValue.Text = "-";
            // 
            // lblGuestCaption
            // 
            lblGuestCaption.AutoSize = true;
            lblGuestCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblGuestCaption.ForeColor = Color.DimGray;
            lblGuestCaption.Location = new Point(18, 106);
            lblGuestCaption.Name = "lblGuestCaption";
            lblGuestCaption.Size = new Size(59, 20);
            lblGuestCaption.TabIndex = 3;
            lblGuestCaption.Text = "Guest";
            // 
            // lblGuestValue
            // 
            lblGuestValue.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblGuestValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblGuestValue.Location = new Point(150, 104);
            lblGuestValue.Name = "lblGuestValue";
            lblGuestValue.Size = new Size(218, 24);
            lblGuestValue.TabIndex = 4;
            lblGuestValue.Text = "-";
            // 
            // lblPhoneCaption
            // 
            lblPhoneCaption.AutoSize = true;
            lblPhoneCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblPhoneCaption.ForeColor = Color.DimGray;
            lblPhoneCaption.Location = new Point(18, 142);
            lblPhoneCaption.Name = "lblPhoneCaption";
            lblPhoneCaption.Size = new Size(61, 20);
            lblPhoneCaption.TabIndex = 5;
            lblPhoneCaption.Text = "Phone";
            // 
            // lblPhoneValue
            // 
            lblPhoneValue.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblPhoneValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblPhoneValue.Location = new Point(150, 140);
            lblPhoneValue.Name = "lblPhoneValue";
            lblPhoneValue.Size = new Size(218, 24);
            lblPhoneValue.TabIndex = 6;
            lblPhoneValue.Text = "-";
            // 
            // lblRoomCaption
            // 
            lblRoomCaption.AutoSize = true;
            lblRoomCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblRoomCaption.ForeColor = Color.DimGray;
            lblRoomCaption.Location = new Point(18, 178);
            lblRoomCaption.Name = "lblRoomCaption";
            lblRoomCaption.Size = new Size(57, 20);
            lblRoomCaption.TabIndex = 7;
            lblRoomCaption.Text = "Room";
            // 
            // lblRoomValue
            // 
            lblRoomValue.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblRoomValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblRoomValue.Location = new Point(150, 176);
            lblRoomValue.Name = "lblRoomValue";
            lblRoomValue.Size = new Size(218, 24);
            lblRoomValue.TabIndex = 8;
            lblRoomValue.Text = "-";
            // 
            // lblCheckInCaption
            // 
            lblCheckInCaption.AutoSize = true;
            lblCheckInCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblCheckInCaption.ForeColor = Color.DimGray;
            lblCheckInCaption.Location = new Point(18, 214);
            lblCheckInCaption.Name = "lblCheckInCaption";
            lblCheckInCaption.Size = new Size(83, 20);
            lblCheckInCaption.TabIndex = 9;
            lblCheckInCaption.Text = "Check-in";
            // 
            // lblCheckInValue
            // 
            lblCheckInValue.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblCheckInValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblCheckInValue.Location = new Point(150, 212);
            lblCheckInValue.Name = "lblCheckInValue";
            lblCheckInValue.Size = new Size(218, 24);
            lblCheckInValue.TabIndex = 10;
            lblCheckInValue.Text = "-";
            // 
            // lblCheckOutCaption
            // 
            lblCheckOutCaption.AutoSize = true;
            lblCheckOutCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblCheckOutCaption.ForeColor = Color.DimGray;
            lblCheckOutCaption.Location = new Point(18, 250);
            lblCheckOutCaption.Name = "lblCheckOutCaption";
            lblCheckOutCaption.Size = new Size(94, 20);
            lblCheckOutCaption.TabIndex = 11;
            lblCheckOutCaption.Text = "Check-out";
            // 
            // lblCheckOutValue
            // 
            lblCheckOutValue.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblCheckOutValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblCheckOutValue.Location = new Point(150, 248);
            lblCheckOutValue.Name = "lblCheckOutValue";
            lblCheckOutValue.Size = new Size(218, 24);
            lblCheckOutValue.TabIndex = 12;
            lblCheckOutValue.Text = "-";
            // 
            // lblNightsCaption
            // 
            lblNightsCaption.AutoSize = true;
            lblNightsCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblNightsCaption.ForeColor = Color.DimGray;
            lblNightsCaption.Location = new Point(18, 286);
            lblNightsCaption.Name = "lblNightsCaption";
            lblNightsCaption.Size = new Size(63, 20);
            lblNightsCaption.TabIndex = 13;
            lblNightsCaption.Text = "Nights";
            // 
            // lblNightsValue
            // 
            lblNightsValue.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblNightsValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblNightsValue.Location = new Point(150, 284);
            lblNightsValue.Name = "lblNightsValue";
            lblNightsValue.Size = new Size(218, 24);
            lblNightsValue.TabIndex = 14;
            lblNightsValue.Text = "-";
            // 
            // lblGuestsCaption
            // 
            lblGuestsCaption.AutoSize = true;
            lblGuestsCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblGuestsCaption.ForeColor = Color.DimGray;
            lblGuestsCaption.Location = new Point(18, 322);
            lblGuestsCaption.Name = "lblGuestsCaption";
            lblGuestsCaption.Size = new Size(121, 20);
            lblGuestsCaption.TabIndex = 15;
            lblGuestsCaption.Text = "No. of guests";
            // 
            // lblGuestsValue
            // 
            lblGuestsValue.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblGuestsValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblGuestsValue.Location = new Point(150, 320);
            lblGuestsValue.Name = "lblGuestsValue";
            lblGuestsValue.Size = new Size(218, 24);
            lblGuestsValue.TabIndex = 16;
            lblGuestsValue.Text = "-";
            // 
            // lblTotalCaption
            // 
            lblTotalCaption.AutoSize = true;
            lblTotalCaption.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblTotalCaption.ForeColor = Color.DimGray;
            lblTotalCaption.Location = new Point(18, 358);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(118, 20);
            lblTotalCaption.TabIndex = 17;
            lblTotalCaption.Text = "Total amount";
            // 
            // lblTotalValue
            // 
            lblTotalValue.Font = new Font("Microsoft Sans Serif", 10.8F);
            lblTotalValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblTotalValue.Location = new Point(150, 356);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(218, 24);
            lblTotalValue.TabIndex = 18;
            lblTotalValue.Text = "-";
            // 
            // chkPaymentReceived
            // 
            chkPaymentReceived.AutoSize = true;
            chkPaymentReceived.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            chkPaymentReceived.ForeColor = Color.FromArgb(47, 65, 86);
            chkPaymentReceived.Location = new Point(18, 411);
            chkPaymentReceived.Name = "chkPaymentReceived";
            chkPaymentReceived.Size = new Size(191, 26);
            chkPaymentReceived.TabIndex = 19;
            chkPaymentReceived.Text = "Payment received";
            chkPaymentReceived.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            btnCheckout.BorderRadius = 15;
            btnCheckout.CustomizableEdges = customizableEdges7;
            btnCheckout.DisabledState.BorderColor = Color.DarkGray;
            btnCheckout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCheckout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCheckout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCheckout.FillColor = Color.FromArgb(47, 65, 86);
            btnCheckout.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(1163, 792);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnCheckout.Size = new Size(210, 56);
            btnCheckout.TabIndex = 9;
            btnCheckout.Text = "Confirm check out";
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnClear
            // 
            btnClear.BorderRadius = 15;
            btnClear.CustomizableEdges = customizableEdges9;
            btnClear.DisabledState.BorderColor = Color.DarkGray;
            btnClear.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClear.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClear.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClear.FillColor = Color.FromArgb(245, 239, 235);
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(1379, 792);
            btnClear.Name = "btnClear";
            btnClear.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnClear.Size = new Size(210, 56);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            // 
            // btnSearch
            // 
            btnSearch.BorderRadius = 15;
            btnSearch.CustomizableEdges = customizableEdges11;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.FromArgb(245, 239, 235);
            btnSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(466, 149);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnSearch.Size = new Size(111, 37);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.BorderRadius = 10;
            txtSearch.CustomizableEdges = customizableEdges13;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F);
            txtSearch.ForeColor = Color.Black;
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(139, 145);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderForeColor = Color.Gray;
            txtSearch.PlaceholderText = "Guest name or booking reference";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtSearch.Size = new Size(320, 45);
            txtSearch.TabIndex = 12;
            // 
            // btnRefresh
            // 
            btnRefresh.BorderRadius = 15;
            btnRefresh.CustomizableEdges = customizableEdges15;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.FromArgb(245, 239, 235);
            btnRefresh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(1026, 155);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnRefresh.Size = new Size(111, 37);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // CheckoutControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 217, 230);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnCheckout);
            Controls.Add(pnlDetails);
            Controls.Add(dgvCheckedIn);
            Controls.Add(lblSearch);
            Controls.Add(lblCheckedIn);
            Controls.Add(pnlHeader);
            Name = "CheckoutControl";
            Size = new Size(1718, 915);
            Load += CheckoutControl_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCheckedIn).EndInit();
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblCheckedIn;
        private Label lblSearch;
        private DataGridView dgvCheckedIn;
        private Panel pnlDetails;
        private Label lblDetailsTitle;
        private Label lblRefCaption;
        private Label lblRefValue;
        private Label lblGuestCaption;
        private Label lblGuestValue;
        private Label lblPhoneCaption;
        private Label lblPhoneValue;
        private Label lblRoomCaption;
        private Label lblRoomValue;
        private Label lblCheckInCaption;
        private Label lblCheckInValue;
        private Label lblCheckOutCaption;
        private Label lblCheckOutValue;
        private Label lblNightsCaption;
        private Label lblNightsValue;
        private Label lblGuestsCaption;
        private Label lblGuestsValue;
        private Label lblTotalCaption;
        private Label lblTotalValue;
        private CheckBox chkPaymentReceived;
        private Guna.UI2.WinForms.Guna2Button btnCheckout;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtPayment;
        private Guna.UI2.WinForms.Guna2TextBox txtBookingID;
        private Guna.UI2.WinForms.Guna2ComboBox cboPaymentMethod;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}
