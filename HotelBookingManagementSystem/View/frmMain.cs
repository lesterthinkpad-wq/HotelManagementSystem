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
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            if (LoginController.userRole == "Staff")
            {
                btnStaffAccount.Hide();
                btnReports.Hide();
            }
            lblRecentBookings.Text = "Active users";
            LoadData();
        }

        private void LoadData()
        {
            DashboardController.LoadDGV(dgvBookingsAccounts);
            lblCurrentUser.Text = $"Logged in as: {LoginController.userRole}";

            lblBookingNum.Text = $"{DashboardController.GetTotalBookings()}";
            lblPendingCheckins.Text = $"{DashboardController.GetPendingsCount()}";
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            frmBookings bookings = new frmBookings();
            bookings.ShowDialog();
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

        private void btnGuests_Click(object sender, EventArgs e)
        {
            frmGuests guestForm = new frmGuests();
            guestForm.ShowDialog();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            frmRooms roomForms = new frmRooms();
            roomForms.ShowDialog();
        }

        private void btnStaffAccount_Click(object sender, EventArgs e)
        {
            frmAccounts accountForm = new frmAccounts();
            accountForm.ShowDialog();
        }
    }
}
