using HotelBookingManagementSystem.Controller;
using StudentManagementApp.Model;
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
    public partial class frmAccounts : Form
    {
        private int addEdit = 0;

        public frmAccounts()
        {
            InitializeComponent();
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            UserController.LoadUsers(dgvUsers);
            UserController.FormatDGV(dgvUsers);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            addEdit = 1;

            txtUserID.Text = dgvUsers.SelectedRows[0].Cells["user_id"].Value.ToString();
            txtFName.Text = dgvUsers.SelectedRows[0].Cells["first_name"].Value.ToString();
            txtLName.Text = dgvUsers.SelectedRows[0].Cells["last_name"].Value.ToString();
            txtEmail.Text = dgvUsers.SelectedRows[0].Cells["email"].Value.ToString();
            txtPhoneNumber.Text = dgvUsers.SelectedRows[0].Cells["phone"].Value.ToString();
            txtPassword.Text = dgvUsers.SelectedRows[0].Cells["password"].Value.ToString();
            txtRole.Text = dgvUsers.SelectedRows[0].Cells["user_role"].Value.ToString();

            // display "Active"/"Inactive" instead of 1 and 0
            string status = dgvUsers.SelectedRows[0].Cells["is_active"].Value.ToString();
            switch (status)
            {
                case "1":
                    txtStatus.Text = "Active";
                    break;
                case "0":
                    txtStatus.Text = "Inactive";
                    break;
                default:
                    MessageBox.Show("No status for this user");
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fname = txtFName.Text;
            string lname = txtLName.Text;
            string email = txtEmail.Text;
            string phone = txtPhoneNumber.Text;
            string password = txtPassword.Text;
            string role = txtRole.Text;
            int status = Convert.ToInt32(txtStatus.Text);

            switch (addEdit)
            {
                case 0:
                    UserController.AddNewUser(fname, lname, email, password, role, phone, status);
                    break;
                case 1:
                    // the code for editing user
                    break;
            }
        }
    }
}
