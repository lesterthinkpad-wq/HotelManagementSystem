namespace HotelBookingManagementSystem.View
{
    partial class ReportsControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle altStyle = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlGapHeader = new Panel();
            pnlFilters = new Panel();
            tblFilters = new TableLayoutPanel();
            pnlFieldType = new Panel();
            lblFieldType = new Label();
            cboReportType = new Guna.UI2.WinForms.Guna2ComboBox();
            pnlFieldFrom = new Panel();
            lblFieldFrom = new Label();
            dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            pnlFieldTo = new Panel();
            lblFieldTo = new Label();
            dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            pnlButtonGenerate = new Panel();
            btnGenerate = new Guna.UI2.WinForms.Guna2Button();
            pnlButtonExport = new Panel();
            btnExport = new Guna.UI2.WinForms.Guna2Button();
            pnlGapFilters = new Panel();
            tblKpi = new TableLayoutPanel();
            pnlKpiRevenue = new Panel();
            pnlKpiRevenueAccent = new Panel();
            lblKpiRevenueCaption = new Label();
            lblKpiRevenueValue = new Label();
            lblKpiRevenueNote = new Label();
            pnlKpiBookings = new Panel();
            pnlKpiBookingsAccent = new Panel();
            lblKpiBookingsCaption = new Label();
            lblKpiBookingsValue = new Label();
            lblKpiBookingsNote = new Label();
            pnlKpiOccupancy = new Panel();
            pnlKpiOccupancyAccent = new Panel();
            lblKpiOccupancyCaption = new Label();
            lblKpiOccupancyValue = new Label();
            lblKpiOccupancyNote = new Label();
            pnlKpiAvgStay = new Panel();
            pnlKpiAvgStayAccent = new Panel();
            lblKpiAvgStayCaption = new Label();
            lblKpiAvgStayValue = new Label();
            lblKpiAvgStayNote = new Label();
            pnlGapKpi = new Panel();
            pnlResults = new Panel();
            pnlResultsHeader = new Panel();
            lblResultsTitle = new Label();
            lblRecordCount = new Label();
            pnlResultsDivider = new Panel();
            dgvReport = new DataGridView();
            pnlFooter = new Panel();
            pnlFooterDivider = new Panel();
            lblFooterNote = new Label();
            lblGrandTotal = new Label();
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.FromArgb(238, 243, 248);
            headerStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerStyle.ForeColor = Color.FromArgb(92, 108, 128);
            headerStyle.Padding = new Padding(12, 0, 0, 0);
            headerStyle.SelectionBackColor = Color.FromArgb(238, 243, 248);
            headerStyle.SelectionForeColor = Color.FromArgb(92, 108, 128);
            headerStyle.WrapMode = DataGridViewTriState.False;
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = Color.White;
            cellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cellStyle.ForeColor = Color.FromArgb(47, 65, 86);
            cellStyle.Padding = new Padding(12, 0, 0, 0);
            cellStyle.SelectionBackColor = Color.FromArgb(222, 232, 243);
            cellStyle.SelectionForeColor = Color.FromArgb(47, 65, 86);
            cellStyle.WrapMode = DataGridViewTriState.False;
            altStyle.BackColor = Color.FromArgb(249, 251, 253);
            altStyle.SelectionBackColor = Color.FromArgb(222, 232, 243);
            altStyle.SelectionForeColor = Color.FromArgb(47, 65, 86);
            pnlHeader.SuspendLayout();
            pnlGapHeader.SuspendLayout();
            pnlFilters.SuspendLayout();
            tblFilters.SuspendLayout();
            pnlFieldType.SuspendLayout();
            pnlFieldFrom.SuspendLayout();
            pnlFieldTo.SuspendLayout();
            pnlButtonGenerate.SuspendLayout();
            pnlButtonExport.SuspendLayout();
            pnlGapFilters.SuspendLayout();
            tblKpi.SuspendLayout();
            pnlKpiRevenue.SuspendLayout();
            pnlKpiRevenueAccent.SuspendLayout();
            pnlKpiBookings.SuspendLayout();
            pnlKpiBookingsAccent.SuspendLayout();
            pnlKpiOccupancy.SuspendLayout();
            pnlKpiOccupancyAccent.SuspendLayout();
            pnlKpiAvgStay.SuspendLayout();
            pnlKpiAvgStayAccent.SuspendLayout();
            pnlGapKpi.SuspendLayout();
            pnlResults.SuspendLayout();
            pnlResultsHeader.SuspendLayout();
            pnlResultsDivider.SuspendLayout();
            pnlFooter.SuspendLayout();
            pnlFooterDivider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // ReportsControl
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(203, 217, 230);
            Controls.Add(pnlResults);
            Controls.Add(pnlGapKpi);
            Controls.Add(tblKpi);
            Controls.Add(pnlGapFilters);
            Controls.Add(pnlFilters);
            Controls.Add(pnlGapHeader);
            Controls.Add(pnlHeader);
            Name = "ReportsControl";
            Padding = new Padding(24, 20, 24, 20);
            Size = new Size(1092, 672);
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Transparent;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(100, 64);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = false;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(47, 65, 86);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Reports";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.Size = new Size(100, 38);
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = false;
            lblSubtitle.Dock = DockStyle.Fill;
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(92, 108, 128);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Text = "Review revenue, bookings and occupancy for any date range.";
            lblSubtitle.TextAlign = ContentAlignment.TopLeft;
            lblSubtitle.Padding = new Padding(2, 2, 0, 0);
            // 
            // pnlGapHeader
            // 
            pnlGapHeader.BackColor = Color.Transparent;
            pnlGapHeader.Dock = DockStyle.Top;
            pnlGapHeader.Name = "pnlGapHeader";
            pnlGapHeader.Size = new Size(100, 14);
            // 
            // pnlFilters
            // 
            pnlFilters.BackColor = Color.White;
            pnlFilters.Dock = DockStyle.Top;
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Padding = new Padding(20, 14, 20, 14);
            pnlFilters.Size = new Size(100, 96);
            pnlFilters.Controls.Add(tblFilters);
            // 
            // tblFilters
            // 
            tblFilters.ColumnCount = 6;
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tblFilters.Controls.Add(pnlFieldType, 0, 0);
            tblFilters.Controls.Add(pnlFieldFrom, 1, 0);
            tblFilters.Controls.Add(pnlFieldTo, 2, 0);
            tblFilters.Controls.Add(pnlButtonGenerate, 4, 0);
            tblFilters.Controls.Add(pnlButtonExport, 5, 0);
            tblFilters.Dock = DockStyle.Fill;
            tblFilters.Name = "tblFilters";
            tblFilters.RowCount = 1;
            tblFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblFilters.Size = new Size(1000, 68);
            // 
            // pnlFieldType
            // 
            pnlFieldType.BackColor = Color.Transparent;
            pnlFieldType.Dock = DockStyle.Fill;
            pnlFieldType.Name = "pnlFieldType";
            pnlFieldType.Margin = new Padding(0, 0, 14, 0);
            pnlFieldType.Controls.Add(cboReportType);
            pnlFieldType.Controls.Add(lblFieldType);
            // 
            // lblFieldType
            // 
            lblFieldType.AutoSize = false;
            lblFieldType.Dock = DockStyle.Top;
            lblFieldType.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFieldType.ForeColor = Color.FromArgb(92, 108, 128);
            lblFieldType.Name = "lblFieldType";
            lblFieldType.Text = "REPORT TYPE";
            lblFieldType.TextAlign = ContentAlignment.MiddleLeft;
            lblFieldType.Size = new Size(100, 24);
            // 
            // cboReportType
            // 
            cboReportType.BackColor = Color.Transparent;
            cboReportType.BorderColor = Color.FromArgb(214, 222, 232);
            cboReportType.BorderRadius = 8;
            cboReportType.Cursor = Cursors.Hand;
            cboReportType.DrawMode = DrawMode.OwnerDrawFixed;
            cboReportType.Dock = DockStyle.Top;
            cboReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboReportType.FillColor = Color.FromArgb(249, 251, 253);
            cboReportType.FocusedColor = Color.FromArgb(62, 110, 160);
            cboReportType.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboReportType.ForeColor = Color.FromArgb(47, 65, 86);
            cboReportType.ItemHeight = 30;
            cboReportType.Items.AddRange(new object[] { "Revenue Summary", "Booking Summary", "Occupancy Report", "Guest Report" });
            cboReportType.Name = "cboReportType";
            cboReportType.SelectedIndex = 0;
            cboReportType.Size = new Size(100, 36);
            // 
            // pnlFieldFrom
            // 
            pnlFieldFrom.BackColor = Color.Transparent;
            pnlFieldFrom.Dock = DockStyle.Fill;
            pnlFieldFrom.Name = "pnlFieldFrom";
            pnlFieldFrom.Margin = new Padding(0, 0, 14, 0);
            pnlFieldFrom.Controls.Add(dtpFrom);
            pnlFieldFrom.Controls.Add(lblFieldFrom);
            // 
            // lblFieldFrom
            // 
            lblFieldFrom.AutoSize = false;
            lblFieldFrom.Dock = DockStyle.Top;
            lblFieldFrom.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFieldFrom.ForeColor = Color.FromArgb(92, 108, 128);
            lblFieldFrom.Name = "lblFieldFrom";
            lblFieldFrom.Text = "FROM";
            lblFieldFrom.TextAlign = ContentAlignment.MiddleLeft;
            lblFieldFrom.Size = new Size(100, 24);
            // 
            // pnlFieldTo
            // 
            pnlFieldTo.BackColor = Color.Transparent;
            pnlFieldTo.Dock = DockStyle.Fill;
            pnlFieldTo.Name = "pnlFieldTo";
            pnlFieldTo.Margin = new Padding(0, 0, 14, 0);
            pnlFieldTo.Controls.Add(dtpTo);
            pnlFieldTo.Controls.Add(lblFieldTo);
            // 
            // lblFieldTo
            // 
            lblFieldTo.AutoSize = false;
            lblFieldTo.Dock = DockStyle.Top;
            lblFieldTo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFieldTo.ForeColor = Color.FromArgb(92, 108, 128);
            lblFieldTo.Name = "lblFieldTo";
            lblFieldTo.Text = "TO";
            lblFieldTo.TextAlign = ContentAlignment.MiddleLeft;
            lblFieldTo.Size = new Size(100, 24);
            // 
            // dtpFrom
            // 
            dtpFrom.BorderColor = Color.FromArgb(214, 222, 232);
            dtpFrom.BorderRadius = 8;
            dtpFrom.BorderThickness = 1;
            dtpFrom.Checked = true;
            dtpFrom.Cursor = Cursors.Hand;
            dtpFrom.CustomFormat = "MMM dd, yyyy";
            dtpFrom.Dock = DockStyle.Top;
            dtpFrom.FillColor = Color.FromArgb(249, 251, 253);
            dtpFrom.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFrom.ForeColor = Color.FromArgb(47, 65, 86);
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(100, 36);
            // 
            // dtpTo
            // 
            dtpTo.BorderColor = Color.FromArgb(214, 222, 232);
            dtpTo.BorderRadius = 8;
            dtpTo.BorderThickness = 1;
            dtpTo.Checked = true;
            dtpTo.Cursor = Cursors.Hand;
            dtpTo.CustomFormat = "MMM dd, yyyy";
            dtpTo.Dock = DockStyle.Top;
            dtpTo.FillColor = Color.FromArgb(249, 251, 253);
            dtpTo.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTo.ForeColor = Color.FromArgb(47, 65, 86);
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(100, 36);
            // 
            // pnlButtonGenerate
            // 
            pnlButtonGenerate.BackColor = Color.Transparent;
            pnlButtonGenerate.Dock = DockStyle.Fill;
            pnlButtonGenerate.Name = "pnlButtonGenerate";
            pnlButtonGenerate.Padding = new Padding(0, 24, 12, 0);
            pnlButtonGenerate.Controls.Add(btnGenerate);
            // 
            // pnlButtonExport
            // 
            pnlButtonExport.BackColor = Color.Transparent;
            pnlButtonExport.Dock = DockStyle.Fill;
            pnlButtonExport.Name = "pnlButtonExport";
            pnlButtonExport.Padding = new Padding(0, 24, 0, 0);
            pnlButtonExport.Controls.Add(btnExport);
            // 
            // btnGenerate
            // 
            btnGenerate.Animated = true;
            btnGenerate.BackColor = Color.Transparent;
            btnGenerate.BorderColor = Color.FromArgb(47, 65, 86);
            btnGenerate.BorderRadius = 8;
            btnGenerate.BorderThickness = 1;
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.Dock = DockStyle.Top;
            btnGenerate.FillColor = Color.FromArgb(47, 65, 86);
            btnGenerate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.HoverState.FillColor = Color.FromArgb(62, 82, 107);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(100, 36);
            btnGenerate.Text = "Generate";
            // 
            // btnExport
            // 
            btnExport.Animated = true;
            btnExport.BackColor = Color.Transparent;
            btnExport.BorderColor = Color.FromArgb(214, 222, 232);
            btnExport.BorderRadius = 8;
            btnExport.BorderThickness = 1;
            btnExport.Cursor = Cursors.Hand;
            btnExport.Dock = DockStyle.Top;
            btnExport.FillColor = Color.White;
            btnExport.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.FromArgb(47, 65, 86);
            btnExport.HoverState.FillColor = Color.FromArgb(238, 243, 248);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(100, 36);
            btnExport.Text = "Export";
            // 
            // pnlGapFilters
            // 
            pnlGapFilters.BackColor = Color.Transparent;
            pnlGapFilters.Dock = DockStyle.Top;
            pnlGapFilters.Name = "pnlGapFilters";
            pnlGapFilters.Size = new Size(100, 14);
            // 
            // tblKpi
            // 
            tblKpi.ColumnCount = 4;
            tblKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblKpi.Controls.Add(pnlKpiRevenue, 0, 0);
            tblKpi.Controls.Add(pnlKpiBookings, 1, 0);
            tblKpi.Controls.Add(pnlKpiOccupancy, 2, 0);
            tblKpi.Controls.Add(pnlKpiAvgStay, 3, 0);
            tblKpi.Dock = DockStyle.Top;
            tblKpi.Name = "tblKpi";
            tblKpi.RowCount = 1;
            tblKpi.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblKpi.Size = new Size(1044, 108);
            // 
            // pnlKpiRevenue
            // 
            pnlKpiRevenue.BackColor = Color.White;
            pnlKpiRevenue.Dock = DockStyle.Fill;
            pnlKpiRevenue.Name = "pnlKpiRevenue";
            pnlKpiRevenue.Margin = new Padding(0, 0, 16, 0);
            pnlKpiRevenue.Controls.Add(lblKpiRevenueValue);
            pnlKpiRevenue.Controls.Add(lblKpiRevenueNote);
            pnlKpiRevenue.Controls.Add(lblKpiRevenueCaption);
            pnlKpiRevenue.Controls.Add(pnlKpiRevenueAccent);
            // 
            // pnlKpiRevenueAccent
            // 
            pnlKpiRevenueAccent.BackColor = Color.FromArgb(47, 65, 86);
            pnlKpiRevenueAccent.Dock = DockStyle.Left;
            pnlKpiRevenueAccent.Name = "pnlKpiRevenueAccent";
            pnlKpiRevenueAccent.Size = new Size(5, 100);
            // 
            // lblKpiRevenueCaption
            // 
            lblKpiRevenueCaption.AutoSize = false;
            lblKpiRevenueCaption.Dock = DockStyle.Top;
            lblKpiRevenueCaption.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiRevenueCaption.ForeColor = Color.FromArgb(92, 108, 128);
            lblKpiRevenueCaption.Name = "lblKpiRevenueCaption";
            lblKpiRevenueCaption.Text = "TOTAL REVENUE";
            lblKpiRevenueCaption.TextAlign = ContentAlignment.BottomLeft;
            lblKpiRevenueCaption.Padding = new Padding(16, 0, 0, 4);
            lblKpiRevenueCaption.Size = new Size(100, 36);
            // 
            // lblKpiRevenueValue
            // 
            lblKpiRevenueValue.AutoSize = false;
            lblKpiRevenueValue.Dock = DockStyle.Fill;
            lblKpiRevenueValue.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiRevenueValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblKpiRevenueValue.Name = "lblKpiRevenueValue";
            lblKpiRevenueValue.Text = "₱ 0.00";
            lblKpiRevenueValue.TextAlign = ContentAlignment.MiddleLeft;
            lblKpiRevenueValue.Padding = new Padding(16, 0, 0, 0);
            // 
            // lblKpiRevenueNote
            // 
            lblKpiRevenueNote.AutoSize = false;
            lblKpiRevenueNote.Dock = DockStyle.Bottom;
            lblKpiRevenueNote.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKpiRevenueNote.ForeColor = Color.FromArgb(140, 155, 175);
            lblKpiRevenueNote.Name = "lblKpiRevenueNote";
            lblKpiRevenueNote.Text = "Selected period";
            lblKpiRevenueNote.TextAlign = ContentAlignment.TopLeft;
            lblKpiRevenueNote.Padding = new Padding(16, 0, 0, 0);
            lblKpiRevenueNote.Size = new Size(100, 28);
            // 
            // pnlKpiBookings
            // 
            pnlKpiBookings.BackColor = Color.White;
            pnlKpiBookings.Dock = DockStyle.Fill;
            pnlKpiBookings.Name = "pnlKpiBookings";
            pnlKpiBookings.Margin = new Padding(0, 0, 16, 0);
            pnlKpiBookings.Controls.Add(lblKpiBookingsValue);
            pnlKpiBookings.Controls.Add(lblKpiBookingsNote);
            pnlKpiBookings.Controls.Add(lblKpiBookingsCaption);
            pnlKpiBookings.Controls.Add(pnlKpiBookingsAccent);
            // 
            // pnlKpiBookingsAccent
            // 
            pnlKpiBookingsAccent.BackColor = Color.FromArgb(62, 110, 160);
            pnlKpiBookingsAccent.Dock = DockStyle.Left;
            pnlKpiBookingsAccent.Name = "pnlKpiBookingsAccent";
            pnlKpiBookingsAccent.Size = new Size(5, 100);
            // 
            // lblKpiBookingsCaption
            // 
            lblKpiBookingsCaption.AutoSize = false;
            lblKpiBookingsCaption.Dock = DockStyle.Top;
            lblKpiBookingsCaption.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiBookingsCaption.ForeColor = Color.FromArgb(92, 108, 128);
            lblKpiBookingsCaption.Name = "lblKpiBookingsCaption";
            lblKpiBookingsCaption.Text = "TOTAL BOOKINGS";
            lblKpiBookingsCaption.TextAlign = ContentAlignment.BottomLeft;
            lblKpiBookingsCaption.Padding = new Padding(16, 0, 0, 4);
            lblKpiBookingsCaption.Size = new Size(100, 36);
            // 
            // lblKpiBookingsValue
            // 
            lblKpiBookingsValue.AutoSize = false;
            lblKpiBookingsValue.Dock = DockStyle.Fill;
            lblKpiBookingsValue.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiBookingsValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblKpiBookingsValue.Name = "lblKpiBookingsValue";
            lblKpiBookingsValue.Text = "0";
            lblKpiBookingsValue.TextAlign = ContentAlignment.MiddleLeft;
            lblKpiBookingsValue.Padding = new Padding(16, 0, 0, 0);
            // 
            // lblKpiBookingsNote
            // 
            lblKpiBookingsNote.AutoSize = false;
            lblKpiBookingsNote.Dock = DockStyle.Bottom;
            lblKpiBookingsNote.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKpiBookingsNote.ForeColor = Color.FromArgb(140, 155, 175);
            lblKpiBookingsNote.Name = "lblKpiBookingsNote";
            lblKpiBookingsNote.Text = "Confirmed and completed";
            lblKpiBookingsNote.TextAlign = ContentAlignment.TopLeft;
            lblKpiBookingsNote.Padding = new Padding(16, 0, 0, 0);
            lblKpiBookingsNote.Size = new Size(100, 28);
            // 
            // pnlKpiOccupancy
            // 
            pnlKpiOccupancy.BackColor = Color.White;
            pnlKpiOccupancy.Dock = DockStyle.Fill;
            pnlKpiOccupancy.Name = "pnlKpiOccupancy";
            pnlKpiOccupancy.Margin = new Padding(0, 0, 16, 0);
            pnlKpiOccupancy.Controls.Add(lblKpiOccupancyValue);
            pnlKpiOccupancy.Controls.Add(lblKpiOccupancyNote);
            pnlKpiOccupancy.Controls.Add(lblKpiOccupancyCaption);
            pnlKpiOccupancy.Controls.Add(pnlKpiOccupancyAccent);
            // 
            // pnlKpiOccupancyAccent
            // 
            pnlKpiOccupancyAccent.BackColor = Color.FromArgb(46, 139, 125);
            pnlKpiOccupancyAccent.Dock = DockStyle.Left;
            pnlKpiOccupancyAccent.Name = "pnlKpiOccupancyAccent";
            pnlKpiOccupancyAccent.Size = new Size(5, 100);
            // 
            // lblKpiOccupancyCaption
            // 
            lblKpiOccupancyCaption.AutoSize = false;
            lblKpiOccupancyCaption.Dock = DockStyle.Top;
            lblKpiOccupancyCaption.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiOccupancyCaption.ForeColor = Color.FromArgb(92, 108, 128);
            lblKpiOccupancyCaption.Name = "lblKpiOccupancyCaption";
            lblKpiOccupancyCaption.Text = "OCCUPANCY RATE";
            lblKpiOccupancyCaption.TextAlign = ContentAlignment.BottomLeft;
            lblKpiOccupancyCaption.Padding = new Padding(16, 0, 0, 4);
            lblKpiOccupancyCaption.Size = new Size(100, 36);
            // 
            // lblKpiOccupancyValue
            // 
            lblKpiOccupancyValue.AutoSize = false;
            lblKpiOccupancyValue.Dock = DockStyle.Fill;
            lblKpiOccupancyValue.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiOccupancyValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblKpiOccupancyValue.Name = "lblKpiOccupancyValue";
            lblKpiOccupancyValue.Text = "0%";
            lblKpiOccupancyValue.TextAlign = ContentAlignment.MiddleLeft;
            lblKpiOccupancyValue.Padding = new Padding(16, 0, 0, 0);
            // 
            // lblKpiOccupancyNote
            // 
            lblKpiOccupancyNote.AutoSize = false;
            lblKpiOccupancyNote.Dock = DockStyle.Bottom;
            lblKpiOccupancyNote.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKpiOccupancyNote.ForeColor = Color.FromArgb(140, 155, 175);
            lblKpiOccupancyNote.Name = "lblKpiOccupancyNote";
            lblKpiOccupancyNote.Text = "Rooms occupied";
            lblKpiOccupancyNote.TextAlign = ContentAlignment.TopLeft;
            lblKpiOccupancyNote.Padding = new Padding(16, 0, 0, 0);
            lblKpiOccupancyNote.Size = new Size(100, 28);
            // 
            // pnlKpiAvgStay
            // 
            pnlKpiAvgStay.BackColor = Color.White;
            pnlKpiAvgStay.Dock = DockStyle.Fill;
            pnlKpiAvgStay.Name = "pnlKpiAvgStay";
            pnlKpiAvgStay.Margin = new Padding(0, 0, 0, 0);
            pnlKpiAvgStay.Controls.Add(lblKpiAvgStayValue);
            pnlKpiAvgStay.Controls.Add(lblKpiAvgStayNote);
            pnlKpiAvgStay.Controls.Add(lblKpiAvgStayCaption);
            pnlKpiAvgStay.Controls.Add(pnlKpiAvgStayAccent);
            // 
            // pnlKpiAvgStayAccent
            // 
            pnlKpiAvgStayAccent.BackColor = Color.FromArgb(196, 134, 52);
            pnlKpiAvgStayAccent.Dock = DockStyle.Left;
            pnlKpiAvgStayAccent.Name = "pnlKpiAvgStayAccent";
            pnlKpiAvgStayAccent.Size = new Size(5, 100);
            // 
            // lblKpiAvgStayCaption
            // 
            lblKpiAvgStayCaption.AutoSize = false;
            lblKpiAvgStayCaption.Dock = DockStyle.Top;
            lblKpiAvgStayCaption.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiAvgStayCaption.ForeColor = Color.FromArgb(92, 108, 128);
            lblKpiAvgStayCaption.Name = "lblKpiAvgStayCaption";
            lblKpiAvgStayCaption.Text = "AVERAGE STAY";
            lblKpiAvgStayCaption.TextAlign = ContentAlignment.BottomLeft;
            lblKpiAvgStayCaption.Padding = new Padding(16, 0, 0, 4);
            lblKpiAvgStayCaption.Size = new Size(100, 36);
            // 
            // lblKpiAvgStayValue
            // 
            lblKpiAvgStayValue.AutoSize = false;
            lblKpiAvgStayValue.Dock = DockStyle.Fill;
            lblKpiAvgStayValue.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKpiAvgStayValue.ForeColor = Color.FromArgb(47, 65, 86);
            lblKpiAvgStayValue.Name = "lblKpiAvgStayValue";
            lblKpiAvgStayValue.Text = "0.0 nights";
            lblKpiAvgStayValue.TextAlign = ContentAlignment.MiddleLeft;
            lblKpiAvgStayValue.Padding = new Padding(16, 0, 0, 0);
            // 
            // lblKpiAvgStayNote
            // 
            lblKpiAvgStayNote.AutoSize = false;
            lblKpiAvgStayNote.Dock = DockStyle.Bottom;
            lblKpiAvgStayNote.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKpiAvgStayNote.ForeColor = Color.FromArgb(140, 155, 175);
            lblKpiAvgStayNote.Name = "lblKpiAvgStayNote";
            lblKpiAvgStayNote.Text = "Per booking";
            lblKpiAvgStayNote.TextAlign = ContentAlignment.TopLeft;
            lblKpiAvgStayNote.Padding = new Padding(16, 0, 0, 0);
            lblKpiAvgStayNote.Size = new Size(100, 28);
            // 
            // pnlGapKpi
            // 
            pnlGapKpi.BackColor = Color.Transparent;
            pnlGapKpi.Dock = DockStyle.Top;
            pnlGapKpi.Name = "pnlGapKpi";
            pnlGapKpi.Size = new Size(100, 16);
            // 
            // pnlResults
            // 
            pnlResults.BackColor = Color.White;
            pnlResults.Dock = DockStyle.Fill;
            pnlResults.Name = "pnlResults";
            pnlResults.Controls.Add(dgvReport);
            pnlResults.Controls.Add(pnlFooter);
            pnlResults.Controls.Add(pnlResultsHeader);
            // 
            // pnlResultsHeader
            // 
            pnlResultsHeader.BackColor = Color.White;
            pnlResultsHeader.Dock = DockStyle.Top;
            pnlResultsHeader.Name = "pnlResultsHeader";
            pnlResultsHeader.Size = new Size(100, 58);
            pnlResultsHeader.Controls.Add(lblRecordCount);
            pnlResultsHeader.Controls.Add(lblResultsTitle);
            pnlResultsHeader.Controls.Add(pnlResultsDivider);
            // 
            // lblResultsTitle
            // 
            lblResultsTitle.AutoSize = false;
            lblResultsTitle.Dock = DockStyle.Left;
            lblResultsTitle.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultsTitle.ForeColor = Color.FromArgb(47, 65, 86);
            lblResultsTitle.Name = "lblResultsTitle";
            lblResultsTitle.Text = "Report Details";
            lblResultsTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblResultsTitle.Padding = new Padding(20, 0, 0, 0);
            lblResultsTitle.Size = new Size(320, 40);
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = false;
            lblRecordCount.Dock = DockStyle.Right;
            lblRecordCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecordCount.ForeColor = Color.FromArgb(92, 108, 128);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Text = "0 records";
            lblRecordCount.TextAlign = ContentAlignment.MiddleRight;
            lblRecordCount.Padding = new Padding(0, 0, 20, 0);
            lblRecordCount.Size = new Size(240, 40);
            // 
            // pnlResultsDivider
            // 
            pnlResultsDivider.BackColor = Color.FromArgb(214, 222, 232);
            pnlResultsDivider.Dock = DockStyle.Bottom;
            pnlResultsDivider.Name = "pnlResultsDivider";
            pnlResultsDivider.Size = new Size(100, 1);
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.AllowUserToResizeRows = false;
            dgvReport.AlternatingRowsDefaultCellStyle = altStyle;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.BackgroundColor = Color.White;
            dgvReport.BorderStyle = BorderStyle.None;
            dgvReport.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReport.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvReport.ColumnHeadersHeight = 44;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReport.DefaultCellStyle = cellStyle;
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.EnableHeadersVisualStyles = false;
            dgvReport.GridColor = Color.FromArgb(228, 234, 241);
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersVisible = false;
            dgvReport.RowTemplate.Height = 40;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(1044, 300);
            dgvReport.TabIndex = 0;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(247, 249, 251);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(100, 48);
            pnlFooter.Controls.Add(lblFooterNote);
            pnlFooter.Controls.Add(lblGrandTotal);
            pnlFooter.Controls.Add(pnlFooterDivider);
            // 
            // lblFooterNote
            // 
            lblFooterNote.AutoSize = false;
            lblFooterNote.Dock = DockStyle.Fill;
            lblFooterNote.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFooterNote.ForeColor = Color.FromArgb(140, 155, 175);
            lblFooterNote.Name = "lblFooterNote";
            lblFooterNote.Text = "Figures reflect the selected report type and date range.";
            lblFooterNote.TextAlign = ContentAlignment.MiddleLeft;
            lblFooterNote.Padding = new Padding(20, 0, 0, 0);
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = false;
            lblGrandTotal.Dock = DockStyle.Right;
            lblGrandTotal.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrandTotal.ForeColor = Color.FromArgb(47, 65, 86);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Text = "Grand Total:  ₱ 0.00";
            lblGrandTotal.TextAlign = ContentAlignment.MiddleRight;
            lblGrandTotal.Padding = new Padding(0, 0, 20, 0);
            lblGrandTotal.Size = new Size(320, 40);
            // 
            // pnlFooterDivider
            // 
            pnlFooterDivider.BackColor = Color.FromArgb(214, 222, 232);
            pnlFooterDivider.Dock = DockStyle.Top;
            pnlFooterDivider.Name = "pnlFooterDivider";
            pnlFooterDivider.Size = new Size(100, 1);
            pnlHeader.ResumeLayout(false);
            pnlGapHeader.ResumeLayout(false);
            pnlFilters.ResumeLayout(false);
            tblFilters.ResumeLayout(false);
            pnlFieldType.ResumeLayout(false);
            pnlFieldFrom.ResumeLayout(false);
            pnlFieldTo.ResumeLayout(false);
            pnlButtonGenerate.ResumeLayout(false);
            pnlButtonExport.ResumeLayout(false);
            pnlGapFilters.ResumeLayout(false);
            tblKpi.ResumeLayout(false);
            pnlKpiRevenue.ResumeLayout(false);
            pnlKpiRevenueAccent.ResumeLayout(false);
            pnlKpiBookings.ResumeLayout(false);
            pnlKpiBookingsAccent.ResumeLayout(false);
            pnlKpiOccupancy.ResumeLayout(false);
            pnlKpiOccupancyAccent.ResumeLayout(false);
            pnlKpiAvgStay.ResumeLayout(false);
            pnlKpiAvgStayAccent.ResumeLayout(false);
            pnlGapKpi.ResumeLayout(false);
            pnlResults.ResumeLayout(false);
            pnlResultsHeader.ResumeLayout(false);
            pnlResultsDivider.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            pnlFooterDivider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlGapHeader;
        private Panel pnlFilters;
        private TableLayoutPanel tblFilters;
        private Panel pnlFieldType;
        private Label lblFieldType;
        private Guna.UI2.WinForms.Guna2ComboBox cboReportType;
        private Panel pnlFieldFrom;
        private Label lblFieldFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Panel pnlFieldTo;
        private Label lblFieldTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private Panel pnlButtonGenerate;
        private Guna.UI2.WinForms.Guna2Button btnGenerate;
        private Panel pnlButtonExport;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Panel pnlGapFilters;
        private TableLayoutPanel tblKpi;
        private Panel pnlKpiRevenue;
        private Panel pnlKpiRevenueAccent;
        private Label lblKpiRevenueCaption;
        private Label lblKpiRevenueValue;
        private Label lblKpiRevenueNote;
        private Panel pnlKpiBookings;
        private Panel pnlKpiBookingsAccent;
        private Label lblKpiBookingsCaption;
        private Label lblKpiBookingsValue;
        private Label lblKpiBookingsNote;
        private Panel pnlKpiOccupancy;
        private Panel pnlKpiOccupancyAccent;
        private Label lblKpiOccupancyCaption;
        private Label lblKpiOccupancyValue;
        private Label lblKpiOccupancyNote;
        private Panel pnlKpiAvgStay;
        private Panel pnlKpiAvgStayAccent;
        private Label lblKpiAvgStayCaption;
        private Label lblKpiAvgStayValue;
        private Label lblKpiAvgStayNote;
        private Panel pnlGapKpi;
        private Panel pnlResults;
        private Panel pnlResultsHeader;
        private Label lblResultsTitle;
        private Label lblRecordCount;
        private Panel pnlResultsDivider;
        private DataGridView dgvReport;
        private Panel pnlFooter;
        private Panel pnlFooterDivider;
        private Label lblFooterNote;
        private Label lblGrandTotal;
    }
}