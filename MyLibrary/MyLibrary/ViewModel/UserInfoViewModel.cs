using MaterialDesignThemes.Wpf;
using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.ViewModel
{
    public class UserInfoViewModel : ViewModelBase
    {
        public UserInfoViewModel()
        {
            Load();
        }

        private string username;
        private string login;
        private int kolBooks;
        private int kolFilms;
        private int kolSerials;
        private int kolManga;

        public int KolBooks
        {
            get => kolBooks;
            set
            {
                kolBooks = value;
                OnPropertyChanged("KolBooks");
            }
        }
        public int KolFilms
        {
            get => kolFilms;
            set
            {
                kolFilms = value;
                OnPropertyChanged("KolFilms");
            }
        }
        public int KolSerials
        {
            get => kolSerials;
            set
            {
                kolSerials = value;
                OnPropertyChanged("KolSerials");
            }
        }
        public int KolManga
        {
            get => kolManga;
            set
            {
                kolManga = value;
                OnPropertyChanged("KolManga");
            }
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

        public string Username
        {
            get => username;
            set
            {
                username = value;
                OnPropertyChanged("Username");
            }
        }


        private void Load()
        {
            Login = User.user.Login;
            Username = User.user.Name;

            DataBase.SqlConnection.Open();

            SqlCommand sql = new SqlCommand();
            sql.Connection = DataBase.SqlConnection;

            sql.CommandText = "Select Count( *) from Books where user_id = " + User.user.ID;
            var books = sql.ExecuteScalar();
            KolBooks = int.Parse(books.ToString());

            sql.CommandText = "Select Count( *) from Films where user_id = " + User.user.ID;
            var film = sql.ExecuteScalar();
            KolFilms = int.Parse(film.ToString());

            sql.CommandText = "Select Count( *) from Serials where user_id = " + User.user.ID;
            var serials = sql.ExecuteScalar();
            KolSerials = int.Parse(serials.ToString());

            sql.CommandText = "Select Count( *) from Manga where user_id = " + User.user.ID;
            var manga = sql.ExecuteScalar();
            KolManga = int.Parse(manga.ToString());

            DataBase.Close();
        }
    }
}
