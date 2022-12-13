using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schulprojekte.Resources;
using MySql.Data.MySqlClient;
using System.Runtime.CompilerServices;

namespace Schulprojekte.Handler {
    internal class DbConnectionHandler {
        static String userName;
        static String password;
        static MySqlConnection conn;

        public static MySqlDataReader useSql() {
            try {
                conn.Open();
                String sql = "select * from tbl_appointments";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
                return reader;

                //while (reader.Read()) {
                // Console.WriteLine("description: " + reader["description"]);
                //}
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
            }
            return null;
        }

        public static void connect() {
            try {
                String defaultConnectionString =
                    "server=" + Constants.DB_INFORMATION_DEFAULT_SERVER
                    + ";uid=" + Constants.DB_INFORMATION_DEFAULT_UID
                    + ";pwd=" + Constants.DB_INFORMATION_DEFAULT_PWD
                    + ";database=" + Constants.DB_INFORMATION_DEFAULT_DB;
                conn = new MySqlConnection();
                conn.ConnectionString = defaultConnectionString;
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void connect(String name, String pwd) {
            userName = name;
            password = pwd;

            String defaultConnectionString =
                "server=" + Constants.DB_INFORMATION_DEFAULT_SERVER
                + ";uid=" + name
                + ";pwd=" + pwd
                + ";database=" + Constants.DB_INFORMATION_DEFAULT_DB;
            conn = new MySqlConnection();
            conn.ConnectionString = defaultConnectionString;

        }
    }
}
