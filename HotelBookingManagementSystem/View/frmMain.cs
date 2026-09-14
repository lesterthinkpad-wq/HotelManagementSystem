using HotelBookingManagementSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            }
        }

    }
}
