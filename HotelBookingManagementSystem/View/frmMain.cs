using HotelBookingManagementSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagementSystem.View
{
    public partial class frmMain : Form
    {
        private GuestControls _guestsControl;
        private BookingsControl _bookingsControl;
        private CheckoutControl _checkoutControl;
        private ReportsControl _reportsControl;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            int role = LoginController.cAdFd;

            switch (role)
            {
                case 1:
                    break;
                case 2:
                    tbcMain.TabPages.Remove(tabCheckout);
                    tbcMain.TabPages.Remove(tabReports);
                    break;
                case 3:
                    tbcMain.TabPages.Remove(tabReports);
                    tbcMain.TabPages.Remove(tabGuests);
                    tbcMain.TabPages.Remove(tabBookings);
                    break;
                default:
                    MessageBox.Show("No users found", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            
            LoadData();
            // Load whichever tab is selected when the form opens
            //tbcMain_SelectedIndexChanged(tbcMain, EventArgs.Empty);
        }

        private void LoadData()
        {
            DashboardController.LoadDGV(dgvBookingsAccounts);
            lblCurrentUser.Text = $"Logged in as: {LoginController.userRole}";

            lblBookingNum.Text = $"{DashboardController.GetTotalBookings()}";
            lblPendingCheckins.Text = $"{DashboardController.GetPendingsCount()}";
            lblAvailableRooms.Text = $"{DashboardController.GetAvailableRooms()}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout now?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcMain.SelectedTab == tabGuests)
            {
                if (_guestsControl == null)
                {
                    _guestsControl = new GuestControls { Dock = DockStyle.Fill };
                    tabGuests.Controls.Add(_guestsControl);
                }
                _guestsControl.LoadDGV();
            }
            else if (tbcMain.SelectedTab == tabBookings)
            {
                if (_bookingsControl == null)
                {
                    _bookingsControl = new BookingsControl { Dock = DockStyle.Fill };
                    tabBookings.Controls.Add(_bookingsControl);
                }
            }
            else if (tbcMain.SelectedTab == tabCheckout)
            {
                if (_checkoutControl == null)
                {
                    _checkoutControl = new CheckoutControl { Dock = DockStyle.Fill };
                    tabCheckout.Controls.Add(_checkoutControl);
                }
            }
            else if (tbcMain.SelectedTab == tabReports)
            {
                if (_reportsControl == null)
                {
                    _reportsControl = new ReportsControl { Dock = DockStyle.Fill };
                    tabReports.Controls.Add(_reportsControl);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}