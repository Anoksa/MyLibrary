using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Model
{
    

    public class User
    {
        public int ID;
        public string Login;
        public string Password;
        public string Name;

        public User() { }
        
        public User(int id, string login, string password, string username)
        {
            this.ID = id;
            this.Login = username;
            this.Password = password;
            this.Name = username;
        }

        public static User user = new User();

        public void GetBooks()
        {
            DataBase.SqlConnection.Open();
            SqlCommand sql = new SqlCommand();
            sql.CommandText = "Select Count( *) from Books where user_id = " + user.ID;
            sql.Connection = DataBase.SqlConnection;
            int number = sql.ExecuteNonQuery();
        }
    }
}
