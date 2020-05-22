using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System.Windows;
using MyLibrary.Model;
using System.Data.SqlClient;
using System.Data;

namespace MyLibrary.ViewModel
{
    public class RegistrationViewModel : ViewModelBase
    {
        private string login;
        private string password;
        private string userName;

        public RegistrationViewModel()
        {

        }

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

        public string UserName
        {
            get => userName;
            set
            {
                userName = value;
                OnPropertyChanged("UserName");
            }
        }

        public ICommand SignUpCommand => new RelayCommand(obj => CanSignUp());

        private async void CanSignUp()
        {
            //if ()
            //{
            //проверка существования пользователя
            //}

            if (CheckField())
            {
                try {
                    SqlConnection sqlcon = new SqlConnection(@"Data Source = PC\SQLEXPRESS; Initial Catalog = MyLibrary; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                    sqlcon.Open();
                    string query = $"Insert into UserInfo(login, password, UserName) values( '" + Login + "', '" + Password + "','" + UserName + "')"; ;
                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    MessageBox.Show("Пользователь зарегистрирован");
                    sqlcon.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }

        }

        private bool CheckField()
        {
            Regex regexLogin = new Regex(@"^[A-zА-я\d]+$");
            Regex regexPassword = new Regex(@"^[A-Za-z\d]+$");

            if (!regexLogin.IsMatch(Login) || Login.Length < 4)
            {
                MessageBox.Show("Login is not validated");
                return false;
            }

            if(!regexPassword.IsMatch(Password) || Password.Length < 6)
            {
                MessageBox.Show("Password is not validated");
                return false;
            }

            return true;
        }
    }
}
