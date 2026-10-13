using StudentManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagementSystem.Controller
{
    public static class RoomController
    {
        public static int GetRoomID(string roomNum)
        {
            string query = $@"SELECT room_id FROM rooms WHERE room_number = '{roomNum}'";

            DataTable dt = SQL.SQLPull(query);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["room_id"]);
            }
            return 0;
        }

        public static DataTable GetRoomTypes()
        {
            string query = @"
            SELECT room_type_id, room_name
            FROM room_types";

            return SQL.SQLPull(query);
        }

        public static DataTable GetAvailableRooms(int roomTypeId, DateTime checkin, DateTime checkout)
        {
            try
            {
                string query = $@"
                    SELECT r.room_id, r.room_number
                    FROM rooms r
                    WHERE r.room_type_id = {roomTypeId}
                    AND r.room_status = 'available'
                    AND r.room_id NOT IN
                    (
                        SELECT br.room_id
                        FROM booking_rooms br
                        INNER JOIN bookings b
                            ON br.booking_id = b.booking_id
                        WHERE b.booking_status != 'cancelled'
                          AND b.check_in_date < '{checkout:yyyy-MM-dd}'
                          AND b.check_out_date > '{checkin:yyyy-MM-dd}'
                    )";

                return SQL.SQLPull(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        public static int GetRoomCapacity(int roomTypeID)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
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

        public static int GetRoomTypePrice(int roomTypeID)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}
