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

        public static void LoadGuests(DataGridView dgv)
        {
            try
            {
                string query = @"
                SELECT 
                    guest_id, first_name, last_name, email, phone, date_of_birth, id_document_type, id_document_number, updated_at
                FROM guests";

                dgv.DataSource = SQL.SQLPull(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AddGuest(string fname, string lname, string email, string phone, DateTime dob, string idType, string idNum)
        {
            try
            {
                string query = @$"
                    INSERT INTO guests
                        (first_name, last_name, email, phone, date_of_birth, id_document_type, id_document_number)
                    VALUES
                        ('{fname}', '{lname}', '{email}', '{phone}', '{dob:yyyy-MM-dd}', '{idType}', '{idNum}')";

                if (SQL.SQLPush(query))
                {
                    MessageBox.Show(
                        "Guest added successfully",
                        "Guest added",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void EditGuest(int guestd, string fname, string lname, string email, string phone, DateTime dob, string idType, string idNum)
        {
            try
            {
                string query = @$"
                    UPDATE guests
                    SET 
                        first_name = '{fname}', last_name = '{lname}', email = '{email}', phone = '{phone}', date_of_birth = '{dob:yyyy-MM-dd}', id_document_type = '{idType}', id_document_number = '{idNum}'
                    WHERE guest_id = {guestd}";

                DialogResult result = MessageBox.Show(
                    "Confirm changes this guest?",
                    "Update guest?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (SQL.SQLPush(query))
                    {
                        MessageBox.Show(
                            "Guest updated successfully",
                            "Guest updated",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }else
                    {
                        MessageBox.Show(
                            "Guest unable to update guest information",
                            "Edit failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }else
                {
                    return;
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
