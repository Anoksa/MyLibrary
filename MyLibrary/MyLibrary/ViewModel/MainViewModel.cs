using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MyLibrary.Model;
using MyLibrary.View;
using System.Data.SqlClient;

namespace MyLibrary.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private Page currentPage;

        public Page CurrentPage
        {
            get { return currentPage; }
            set
            {
                currentPage = value;
                OnPropertyChanged();
            }
        }

        public ICommand BooksCommand => new RelayCommand(obj => OpenBooksPage());

        public ICommand FilmsCommand => new RelayCommand(obj => OpenFilmsPage());

        public ICommand SerialsCommand => new RelayCommand(obj => OpenSerialsPage());

        public ICommand MangaCommand => new RelayCommand(obj => OpenMangaPage());

        public ICommand InfoCommand => new RelayCommand(obj => OpenUserInfo());

        private void OpenBooksPage()
        {
            CurrentPage = new Books();
        }

        public void OpenFilmsPage()
        {
            CurrentPage = new Films();
        }
       
        private void OpenSerialsPage()
        {
            CurrentPage = new Serials();
        }

        private void OpenMangaPage()
        {
            CurrentPage = new Manga();
        }

        public ICommand RandomCommand => new RelayCommand(obj => RandomBook());

        private void RandomBook()
        {
            List<Book> list = new List<Book>();
            string sqlExpression = "SELECT * FROM Books where Status = 'Непрочитано'";

            if (DataBase.SqlConnection.State != System.Data.ConnectionState.Open)
            {
                DataBase.SqlConnection.Open();
            }

            if (DataBase.SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand(sqlExpression, DataBase.SqlConnection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные 
                {
                    while (reader.Read()) // построчно считываем данные 
                    {
                        object book_id = reader["Book_id"];
                        object title = reader["Title"];
                        object author = reader["Author"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        list.Add(new Book(Convert.ToInt32(book_id.ToString()), title.ToString(), author.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();

            MessageBox.Show(list[new Random().Next(list.Count)].Title);
        }

        private void OpenUserInfo()
        {
            CurrentPage = new UseInfoPage();
        }
    }
}
