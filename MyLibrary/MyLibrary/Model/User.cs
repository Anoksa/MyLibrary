using System;
using System.Collections.Generic;
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
    }
}
