using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagementApp.Model
{
    public static class SQL
    {

        public static string ConnectionString =
           "Server=localhost;" +
            "Port=;" +
            "Database=;" +
            "Uid=root;" +
            "Pwd=;";

        public static DataTable SQLPull(string sqlStatement)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                using (MySqlCommand cmd = new MySqlCommand(sqlStatement, conn))
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    conn.Open();
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public static bool SQLPush(string sqlStatement)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                using (MySqlCommand cmd = new MySqlCommand(sqlStatement, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static int SQLPushGetID(string sqlStatement)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                using (MySqlCommand cmd = new MySqlCommand(sqlStatement, conn))
                {
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}
