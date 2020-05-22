using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyLibrary.Model
{
    public class DataBase //Singleton
    {
        private static DataBase  instance;
        public static SqlConnection SqlConnection { get; set; }
        private DataBase()
        {
            SqlConnection = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=MyLibrary;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection.Open();
        }
        public static DataBase getInstance()
        {
            if (instance == null)
                instance = new DataBase();
            return instance;
        }
        public static void Close()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
                SqlConnection.Close();
        }
    }
}
