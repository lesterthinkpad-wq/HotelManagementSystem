using HotelBookingManagementSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagementSystem.View
{
    public partial class frmGuests : Form
    {
        public static int guestID = 0;
        public static string firstName, lastName, email, phone;

        private bool selectionMode = false;

        public frmGuests()
        {
            InitializeComponent();
        }

        public frmGuests(bool selectionMode)
        {
            InitializeComponent();

            this.selectionMode = selectionMode;
        }

        private void frmGuests_Load(object sender, EventArgs e)
        {
            if (selectionMode)
            {
                btnBookings.Visible = false;

                this.Height = 535;
                this.Width = 952;

                lblGuests.Text = "Select guest";

                GuestController.GuestSelection(dgvGuests);
                GuestController.FormatSelectGuestDGV(dgvGuests);
            }
        } 

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvGuests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a guest.");
                return;
            }

            guestID = Convert.ToInt32(
                dgvGuests.SelectedRows[0].Cells["guest_id"].Value
            );

            firstName = dgvGuests.SelectedRows[0].Cells["first_name"].Value.ToString();
            lastName = dgvGuests.SelectedRows[0].Cells["last_name"].Value.ToString();
            email = dgvGuests.SelectedRows[0].Cells["email"].Value.ToString();
            phone = dgvGuests.SelectedRows[0].Cells["phone"].Value.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
