using StudentManagementApp.Model;
using System;
using System.Collections.Generic;
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
                // Sukatam atuy NIGGA. DISPLAY ONLY WHAT IS NESCESSARY

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
    }
}
