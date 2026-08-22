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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
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
    }
}
