using StudentManagementApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagementSystem.Controller
{
    public static class UserController
    {
        public static void LoadUsers(DataGridView dgv)
        {
            try
            {
                string query = @"
                    SELECT user_id, first_name, last_name, email, password, user_role, phone, is_active
                    FROM users";

                dgv.DataSource = SQL.SQLPull(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unexpected error",
                    MessageBoxButtons.OK);
            }
        }

        public static void FormatDGV(DataGridView dgv)
        {
            dgv.Columns["user_id"].Visible = false;
            dgv.Columns["first_name"].HeaderText = "First name";   
            dgv.Columns["last_name"].HeaderText = "Last name";   
            dgv.Columns["email"].HeaderText = "Email";   
            dgv.Columns["password"].HeaderText = "Password";   
            dgv.Columns["user_role"].HeaderText = "Role";
            dgv.Columns["phone"].HeaderText = "Phone";
            dgv.Columns["is_active"].HeaderText = "Status";
        }

        public static void AddNewUser(string fname, string lname, string email, string password, string role, string phone, int status)
        {
            try
            {
                string query = @$"
                    INSERT INTO users
                        (first_name, last_name, email, password, user_role, phone, is_active)
                    VALUES
                        ('{fname}', '{lname}', '{email}', '{password}', '{role}', '{phone}', {status})";

                if (SQL.SQLPush(query))
                {
                    MessageBox.Show(
                        "User added successfully",
                        "Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unexpected error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void UpdateUser(int userID, string fname, string lname, string email, string password, string role, string phone, int status)
        {
            string query = @$"
                UPDATE users SET
                    first_name = '{fname}',
                    last_name = '{lname}',
                    email = '{email}',
                    password = '{password}',
                    user_role = '{role}',
                    phone = '{phone}',
                    is_active = {status}";
        }
    }
}
