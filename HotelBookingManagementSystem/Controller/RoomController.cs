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
    }
}
