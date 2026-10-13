using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementApp.Model;

namespace HotelBookingManagementSystem.Controller
{
    public static class CheckoutController
    {
        public static void LoadDGV(DataGridView dgv)
        {
            try
            {
                string query = @"
                SELECT
                    b.booking_id AS BookingID,
                    b.booking_reference AS Reference,
                    CONCAT(g.first_name, ' ', g.last_name) AS Guest,
                    g.phone AS Phone,
                    r.room_number AS Room,
                    b.check_in_date AS `Check-in`,
                    b.check_out_date AS Checkout,
                    DATEDIFF(b.check_out_date, b.check_in_date) AS Nights,
                    br.num_guests AS `No. of Guests`,
                    b.total_amount AS `Total Amount`
                FROM bookings b
                INNER JOIN guests g
                    ON b.guest_id = g.guest_id
                INNER JOIN booking_rooms br
                    ON b.booking_id = br.booking_id
                INNER JOIN rooms r
                    ON br.room_id = r.room_id
                WHERE b.booking_status = 'checked_in'
                ORDER BY b.booking_id DESC
                LIMIT 10;";

                dgv.DataSource = SQL.SQLPull(query);
                dgv.Columns["BookingID"].Visible = false;
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

        public static void ProcessCheckout(int bookingId, decimal amount, string paymentMethod, string transactionReference, int userId)
        {
            try
            {
                string paymentQuery = $@"
                INSERT INTO payments
                    (booking_id, amount, payment_method, payment_status, transaction_reference, processed_by_user_id)
                VALUES
                    ({bookingId}, {amount}, '{paymentMethod}', 'completed', '{transactionReference}', {userId})";

                if (SQL.SQLPush(paymentQuery))
                {
                    string bookingQuery = $@"
                    UPDATE bookings
                    SET booking_status = 'checked_out'
                    WHERE booking_id = {bookingId}
                    AND booking_status = 'checked_in'";

                    if (SQL.SQLPush(bookingQuery))
                    {
                        MessageBox.Show(
                            "Guest checked out successfully.",
                            "Checkout Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
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
    }
}
