using StudentManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagementSystem.Controller
{
    public static class DashboardController
    {
        public static void LoadDGV(DataGridView dgv)
        {
            try
            {
                if (LoginController.cAdFd == 1)
                {
                    string query = @"
                SELECT
                    CONCAT(g.first_name, ' ', g.last_name) AS Guest_Name,
                    r.room_number AS Room_Number,
                    b.check_in_date AS Checkin,
                    b.check_out_date AS Checkout,
                    b.booking_status AS Status
                FROM bookings b
                INNER JOIN guests g 
                    ON b.guest_id = g.guest_id
                INNER JOIN booking_rooms br
                    ON b.booking_id = br.booking_id
                INNER JOIN rooms r
                    ON br.room_id = r.room_id
                ORDER BY b.booking_id DESC
                LIMIT 10;";

                    dgv.DataSource = SQL.SQLPull(query);
                }
                else if (LoginController.cAdFd == 1)
                {
                    string query = @"SELECT * FROM users";
                    dgv.DataSource = SQL.SQLPull(query);
                }
                else
                {
                    MessageBox.Show("Error");
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

        public static int GetTotalBookings()
        {
            try
            {
                string query = "SELECT COUNT(*) AS bookingCount FROM bookings";

                DataTable dt = SQL.SQLPull(query);

                return Convert.ToInt32(dt.Rows[0]["bookingCount"]);
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public static int GetPendingsCount()
        {
            try
            {
                string query = "SELECT COUNT(*) as pendings FROM bookings WHERE booking_status = 'pending'";

                DataTable dt = SQL.SQLPull(query);

                return Convert.ToInt32(dt.Rows[0]["pendings"]);
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
                return 0;
            }
        }
    }
}
