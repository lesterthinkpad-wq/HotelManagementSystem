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
    public partial class AccountsControl : UserControl
    {
        private bool addEdit = false;

        public AccountsControl()
        {
            InitializeComponent();
        }

        private void AccountsControl_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            UserController.LoadUsers(dgvUsers);
            UserController.FormatDGV(dgvUsers);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to save changes?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SaveAddUser();
                LoadUsers();
                ClearControls();
            }
        }

        private void SaveAddUser()
        {
            string fname = txtFName.Text;
            string lname = txtLName.Text;
            string email = txtEmail.Text;
            string phone = txtPhoneNumber.Text;
            string password = txtPassword.Text;
            string role = cboRole.SelectedItem.ToString();
            string status = txtStatus.Text;

            if (addEdit)
            {
                int userId = Convert.ToInt32(txtUserID.Text);

                UserController.UpdateUser(userId, fname, lname, email, password, role, phone, status);
            }
            else
            {
                UserController.AddNewUser(fname, lname, email, password, role, phone, status);
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            txtUserID.Text = dgvUsers.SelectedRows[0].Cells["user_id"].Value.ToString();
            txtFName.Text = dgvUsers.SelectedRows[0].Cells["first_name"].Value.ToString();
            txtLName.Text = dgvUsers.SelectedRows[0].Cells["last_name"].Value.ToString();
            txtEmail.Text = dgvUsers.SelectedRows[0].Cells["email"].Value.ToString();
            txtPhoneNumber.Text = dgvUsers.SelectedRows[0].Cells["phone"].Value.ToString();
            txtPassword.Text = dgvUsers.SelectedRows[0].Cells["password"].Value.ToString();
            cboRole.SelectedItem = dgvUsers.SelectedRows[0].Cells["user_role"].Value.ToString();
            txtStatus.Text = dgvUsers.SelectedRows[0].Cells["status"].Value.ToString();

            addEdit = true;
        }

        private void ClearControls()
        {
            txtUserID.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtPassword.Clear();
            cboRole.SelectedIndex = -1;
            txtStatus.Clear();
            addEdit = false;
        }
    }
}
