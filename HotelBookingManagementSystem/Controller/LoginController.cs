using StudentManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagementSystem.Controller
{
    public static class LoginController
    {
        public static int userID;
        public static string? userRole;
        public static int cAdFd = 0;

        public static bool CheckUserRole(string user_id, string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(user_id) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show(
                        "Please enter your password and userID",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }                

                string query = $@"
                    SELECT user_id, 
                    password,
                    user_role
                    FROM users WHERE user_id = '{user_id}'";

                DataTable dt = SQL.SQLPull(query);

                //takes the user id and store it in a global variable
                userID = Convert.ToInt32(user_id);

                if (dt.Rows.Count > 0)
                {
                    string checkPassword = dt.Rows[0]["password"].ToString();
                    if (checkPassword == password)
                    {
                        userRole = dt.Rows[0]["user_role"].ToString();

                        // check if it is a admin or staff
                        if (userRole == "admin")
                        {
                            cAdFd = 1;
                        }
                        else if (userRole == "front_desk")
                        {
                            cAdFd = 2;
                        }
                        else if (userRole == "cashier")
                        {
                            cAdFd = 3;
                        }
                        MessageBox.Show(
                            "Login successful",
                            "Authentication successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        
                        return true;
                    }
                    else
                    {
                        MessageBox.Show(
                            "Password Incorrect!",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(
                         "User ID does not exist!",
                         "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK); 
                return false;
            }
        }
    }
}
