using StudentManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagementSystem.Controller
{
    public static class BookingController
    {
        public static DataTable GetRoomTypes()
        {
            string query = @"
            SELECT room_type_id, room_name
            FROM room_types";

            return SQL.SQLPull(query);
        }
        
        public static DataTable GetAvailableRooms(int roomTypeId)
        {
            string query = $@"
                SELECT room_number
                FROM rooms
                WHERE room_type_id = {roomTypeId}
                AND room_status = 'available'";

            return SQL.SQLPull(query);
        }

        public static int GetRoomCapacity(int roomTypeID)
        {
            string query = $@"
                SELECT max_occupancy 
                FROM room_types 
                WHERE room_type_id = {roomTypeID}";

            DataTable dt = SQL.SQLPull(query);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["max_occupancy"]);
            }
            return 0;
        }

        public static bool IsRoomCapacityValid(int roomTypeID, int guests)
        {
            int capacity = GetRoomCapacity(roomTypeID);

            if (guests <= capacity)
            {
                return true;
            }
            return false;
        }

        public static bool CheckDateConflicts(int roomID, int bookingID, DateTime checkin, DateTime checkout)
        {
            string query = $@"
                SELECT COUNT(1) AS ConflictCount
                FROM booking_rooms br
                INNER JOIN bookings b ON br.booking_id = b.booking_id
                WHERE br.room_id = @roomID
                AND b.booking_status != 'cancelled'
                AND b.booking_id != {bookingID}
                AND b.check_in_date < '{checkout:yyyy-MM-dd}' 
                AND b.check_out_date > '{checkin:yyyy-MM-dd}'";

            DataTable dt = SQL.SQLPull(query);

            if (dt.Rows.Count > 0)
            {
                int count = Convert.ToInt32(dt.Rows[0]["ConflictCount"]);
                return count > 0;
            }
            return false;
        }

        public static int GetRoomTypePrice(int roomTypeID)
        {
            string query = $@"
                SELECT base_price
                FROM room_types
                WHERE room_type_id = {roomTypeID}";

            DataTable dt = SQL.SQLPull(query);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["base_price"]);
            }
            return -1;
        }

        public static int GetBookingID()
        {
            string query = "SELECT booking_id FROM bookings";

            DataTable dt = SQL.SQLPull(query);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["booking_id"]);
            }
            return -1;
        }

        public static bool IsDateValid(DateTime checkin, DateTime checkout)
        {
            return checkin.Date < checkout.Date;
        }

        public static string GenerateReference()
        {
            return $"BK-{DateTime.Now:yyyyMMdd}-{Random.Shared.Next(1000, 9999)}";
        }

        public static string CheckBookingStatus(DateTime checkin)
        {
            if (checkin.Date > DateTime.Today)
                return "pending";
            return "checked_in";
        }

        public static int CreateBooking(int guestID, DateTime checkin, DateTime checkout, int createdBy, string bookingRef, string status, decimal totalAmount)
        {
            int bookingID;

            string query = $@"
                INSERT INTO bookings 
                    (guest_id, created_by_user_id, booking_reference, booking_status, check_in_date, check_out_date, total_amount)
                VALUES 
                    ({guestID}, {createdBy}, '{bookingRef}', '{status}', '{checkin:yyyy-MM-dd}', '{checkout:yyyy-MM-dd}', {totalAmount});
                SELECT LAST_INSERT_ID();";

            return bookingID = Convert.ToInt32(SQL.SQLPushGetID(query));
        }

        public static void CreateBookingRooms(int bookingID, int roomID, double rate, int guests)
        {
            string query = $@"
                INSERT INTO booking_rooms
                    (booking_id, room_id, rate_at_booking, num_guests)
                VALUES
                    ({bookingID}, {roomID}, {rate}, {guests})";

            SQL.SQLPush(query);
        }
        public static string CalculateGrandTotal(DataGridView dgv, string totalAmount)
        {
            double grandTotal = 0;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow)
                    continue;

                grandTotal += Convert.ToDouble(row.Cells["TotalAmount"].Value);
            }

            return totalAmount = $"{grandTotal:N2}";
        }

        public static int CalculateNights(DateTime checkIn, DateTime checkOut)
        {
            return (checkOut - checkIn).Days;
        }

        public static double CalculateLineTotal(double basePrice, int nights)
        {
            return basePrice * nights;
        }

        public static string CleanAmountString(string rawAmount)
        {
            if (string.IsNullOrWhiteSpace(rawAmount)) return "0.00";
            return rawAmount.Replace("$", "").Replace("₱", "").Trim();
        }

        public static decimal ParseTotalAmount(string rawAmount)
        {
            string cleaned = CleanAmountString(rawAmount);
            return decimal.TryParse(cleaned, out decimal result) ? result : 0m;
        }

        public static bool ProcessCompleteBooking(
            int guestId,
            int createdByUserId,
            string rawTotalAmount,
            DataGridView dgvBookings)
        {
            if (dgvBookings.Rows.Count == 0) return false;

            decimal totalAmount = ParseTotalAmount(rawTotalAmount);
            string bookingReference = GenerateReference();

            // Get check-in date from first row
            DateTime initialCheckin = Convert.ToDateTime(dgvBookings.Rows[0].Cells["CheckIn"].Value);
            DateTime finalCheckout = Convert.ToDateTime(dgvBookings.Rows[0].Cells["CheckOut"].Value);
            string status = CheckBookingStatus(initialCheckin);

            // Save main booking record
            int bookingID = CreateBooking(guestId, initialCheckin, finalCheckout, createdByUserId, bookingReference, status, totalAmount);

            if (bookingID <= 0) return false;

            // Loop through grid items and save room detail records
            foreach (DataGridViewRow row in dgvBookings.Rows)
            {
                if (row.IsNewRow) continue;

                int roomID = Convert.ToInt32(row.Cells["RoomID"].Value);
                int guests = Convert.ToInt32(row.Cells["Guests"].Value);
                int nights = Convert.ToInt32(row.Cells["Nights"].Value);
                double totalLineItem = Convert.ToDouble(row.Cells["TotalAmount"].Value);

                double rate = nights > 0 ? totalLineItem / nights : 0;

                CreateBookingRooms(bookingID, roomID, rate, guests);
            }

            return true;
        }

    }
}
