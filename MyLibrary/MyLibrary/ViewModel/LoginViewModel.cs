using MyLibrary.Model;
using MyLibrary.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.IO.Packaging;

namespace MyLibrary.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        private string login;
        private string password;

        


        public string Login
        {
            get => login;
            set
            {
                login = value;
                OnPropertyChanged("Login");
            }
        }

        public string Password
        {
            private get => password;
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        public ICommand LoginCommand => new RelayCommand(obj => CanLogin());
        
        private void CanLogin()
        {
            DataBase.getInstance();
            string query = "select * from UserInfo where login = '" + Login + "' and password = '" + Password + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, DataBase.SqlConnection);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            if (dtbl.Rows.Count >= 1)
            {
                string Uquery = "select user_id from UserInfo where login = '" + Login + "' and password = '" + Password + "'";
                SqlCommand cmd = new SqlCommand(Uquery, DataBase.SqlConnection);
                var temp = cmd.ExecuteScalar();
                User.user.ID = int.Parse(temp.ToString());
                User.user.Login = Login;
                User.user.Password = Password;
                
                
                
                string Nqueri = $"Select UserName from UserInfo where user_id = " + User.user.ID;
                SqlCommand command = new SqlCommand(Nqueri, DataBase.SqlConnection);
                temp = command.ExecuteScalar();
                User.user.Name = temp.ToString();
                DataBase.SqlConnection.Close();
                
                //открытие главного окна
                var main = new Main();
                main.Show();
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }

        public ICommand RegistrationCommand => new RelayCommand(obj => CanRegistrate());
        

        public void CanRegistrate()
        {
            var registrate = new Registration();
            var login = new Autorization();
            login.Hide();

            registrate.Show();
            
        }
    
    }
}
