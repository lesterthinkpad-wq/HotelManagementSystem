using StudentManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagementSystem.Controller
{
    public static class GuestController
    {
        public static void FormatSelectGuestDGV(DataGridView dgv)
        {
            dgv.Columns["guest_id"].Visible = false;
            dgv.Columns["first_name"].HeaderText = "First Name";
            dgv.Columns["last_name"].HeaderText = "Last Name";
            dgv.Columns["email"].HeaderText = "Email";
            dgv.Columns["phone"].HeaderText = "Phone";
        }
        public static void GuestSelection(DataGridView dgv)
        {
            string query = @"
                SELECT guest_id, first_name, last_name, email, phone
                FROM guests";

            dgv.DataSource = SQL.SQLPull(query);
        }
    }
}
