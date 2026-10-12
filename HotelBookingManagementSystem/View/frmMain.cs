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
        public frmMain()
        {
            InitializeComponent();

            tabBookings.Controls.Add(new BookingsControl { Dock = DockStyle.Fill });
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
        }

        private void LoadData()
        {
            DashboardController.LoadDGV(dgvBookingsAccounts);
            lblCurrentUser.Text = $"Logged in as: {LoginController.userRole}";

            lblBookingNum.Text = $"{DashboardController.GetTotalBookings()}";
            lblPendingCheckins.Text = $"{DashboardController.GetPendingsCount()}";
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
            return;
        }

        private GuestControls _guestsControl;
        private BookingsControl _bookingsControl;
        private CheckoutControl _checkoutControl;
        private void tbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcMain.SelectedTab == tabGuests)
            {
                _guestsControl = new GuestControls { Dock = DockStyle.Fill };
                tabGuests.Controls.Add(_guestsControl);
                _guestsControl.LoadDGV();
            }
            else if (tbcMain.SelectedTab == tabBookings)
            {
                _bookingsControl = new BookingsControl { Dock = DockStyle.Fill };
                tabBookings.Controls.Add(_bookingsControl);
            }
            else if (tbcMain.SelectedTab == tabCheckout)
            {
                _checkoutControl = new CheckoutControl { Dock = DockStyle.Fill };
                tabCheckout.Controls.Add(_checkoutControl);
            }
        }

    }
}
