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
    public partial class GuestControls : UserControl
    {
        private bool edit = false;

        public GuestControls()
        {
            InitializeComponent();

            dtpBirthDate.MaxDate = DateTime.Today;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvGuests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a guest.");
                return;
            }

            txtGuestID.Text = dgvGuests.SelectedRows[0].Cells["guest_id"].Value.ToString();
            txtFName.Text = dgvGuests.SelectedRows[0].Cells["first_name"].Value.ToString();
            txtLName.Text = dgvGuests.SelectedRows[0].Cells["last_name"].Value.ToString();
            txtEmail.Text = dgvGuests.SelectedRows[0].Cells["email"].Value.ToString();
            txtPhoneNumber.Text = dgvGuests.SelectedRows[0].Cells["phone"].Value.ToString();
            dtpBirthDate.Value = Convert.ToDateTime(dgvGuests.SelectedRows[0].Cells["date_of_birth"].Value);
            txtIDType.Text = dgvGuests.SelectedRows[0].Cells["id_document_type"].Value.ToString();
            txtIDNumber.Text = dgvGuests.SelectedRows[0].Cells["id_document_number"].Value.ToString();

            edit = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            int guestId = string.IsNullOrWhiteSpace(txtGuestID.Text) ? 0 : Convert.ToInt32(txtGuestID.Text);
            string fname = txtFName.Text;
            string lname = txtLName.Text;
            string email = txtEmail.Text;
            string phone = txtPhoneNumber.Text;
            string idType = txtIDType.Text;
            string idNum = txtIDNumber.Text;
            DateTime dob = dtpBirthDate.Value;

            if (edit)
            {
                GuestController.EditGuest(guestId, fname, lname, email, phone, dob, idType, idNum);
            }
            else
            {
                GuestController.AddGuest(fname, lname, email, phone, dob, idType, idNum);
            }

            edit = false;
            ClearGuestDetails();
            txtGuestID.Clear();
        }

        public void LoadDGV()
        {
            GuestController.LoadGuests(dgvGuests);
        }

        private void ClearGuestDetails()
        {

            txtGuestID.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtIDNumber.Clear();
            txtIDType.Clear();
            dtpBirthDate.Value = DateTime.Today;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
