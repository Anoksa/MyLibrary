﻿using MyLibrary.View;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;
using MyLibrary.Model;
using System.Data.SqlClient;
using System.Windows;

namespace MyLibrary.ViewModel
{
    public class BooksViewModel  : ViewModelBase
    {
        public BooksViewModel()
        {
            Load();
        }

        public ICommand DetectiveCommand => new RelayCommand(obj => SearchDetective());
        public ICommand RomanticCommand => new RelayCommand(obj => SearchRomantic());
        public ICommand FantasticCommand => new RelayCommand(obj => SearchFantastic());
        public ICommand FantasyCommand => new RelayCommand(obj => SearchFantasy());
        public ICommand AdventureCommand => new RelayCommand(obj => SearchAdventure());
        public ICommand DramaCommand => new RelayCommand(obj => SearchDrama());
        public ICommand AllCommand => new RelayCommand(obj => SearchAll());
        public ICommand RomanCommand => new RelayCommand(obj => SearchRoman());
        public ICommand AddCommand => new RelayCommand(obj => AddNew());
        public ICommand DeleteCommand => new RelayCommand(obj => Delete());

       

        private void SearchDetective()
        {
            Books.Clear();
            
            string sqlExpression = "SELECT * FROM Books where Genre ='Детектив'";

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



                        Books.Add(new Book(Convert.ToInt32(book_id.ToString()), title.ToString(), author.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            
            DataBase.SqlConnection.Close();
        }

        private void SearchRomantic()
        {
            Books.Clear();
            string sqlExpression = "SELECT * FROM Books where Genre ='Романтика'";

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



                        Books.Add(new Book(Convert.ToInt32(book_id.ToString()), title.ToString(), author.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchFantastic()
        {
            Books.Clear();
            string sqlExpression = "SELECT * FROM Books where Genre ='Фантастика'";

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



                        Books.Add(new Book(Convert.ToInt32(book_id.ToString()), title.ToString(), author.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchFantasy()
        {
            Books.Clear();
            string sqlExpression = "SELECT * FROM Books where Genre ='Фэнтези'";

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



                        Books.Add(new Book(Convert.ToInt32(book_id.ToString()), title.ToString(), author.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchAdventure()
        {
            Books.Clear();
            string sqlExpression = "SELECT * FROM Books where Genre ='Приключения'";

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



                        Books.Add(new Book(Convert.ToInt32(book_id.ToString()), title.ToString(), author.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchDrama()
        {
            Books.Clear();
            string sqlExpression = "SELECT * FROM Books where Genre ='Драма'";

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



                        Books.Add(new Book(Convert.ToInt32(book_id.ToString()), title.ToString(), author.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchAll()
        {
            Books.Clear();
            string sqlExpression = "SELECT * FROM Books ";

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



                        Books.Add(new Book(Convert.ToInt32(book_id.ToString()), title.ToString(), author.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchRoman()
        {
            Books.Clear();
            string sqlExpression = "SELECT * FROM Books where Genre ='Роман'";

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



                        Books.Add(new Book(Convert.ToInt32(book_id.ToString()), title.ToString(), author.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void AddNew()
        {
            var addW = new AddNew();
            addW.Show();
        }

        private void Delete()
        {
            if (selectedBook != null)
            {
                DataBase.SqlConnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"delete from Books where book_id =" + selectedBook.ID;
                cmd.Connection = DataBase.SqlConnection;
                cmd.ExecuteNonQuery();
                Books.Remove(selectedBook);
            }
            else
                MessageBox.Show("Выберите книгу");
        }

        private Book selectedBook;

        public Book SelectedBook
        {
            get => selectedBook;
            set
            {
                selectedBook = value;
                OnPropertyChanged("GetDescription");
            }
        }
         
       

        public  ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book>();

        private  void Load()
        {
           
            string sqlExpression = "SELECT * FROM Books where user_id="+User.user.ID;

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



                        Books.Add(new Book(Convert.ToInt32(book_id.ToString()), title.ToString(), author.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        public string GetDescription
        {
            get
            {
                if (selectedBook != null)
                    return selectedBook.Description;
                return "";
            }
        }

        private string search_txt;

        public string SearchB
        {
            get => search_txt;
            set
            {
                search_txt = value;
                OnPropertyChanged("SearchB");
            }
        }

        public ICommand SearchCommand => new RelayCommand(obj => Search());

        private void Search()
        {
            Books.Clear();
            string sqlExpression = "SELECT Book_id, Title, Author, Genre, Year, Description, Status FROM Books Where user_id = " + User.user.ID +" and Title like '%"+SearchB + "%'";

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



                        Books.Add(new Book(Convert.ToInt32(book_id.ToString()), title.ToString(), author.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }


        public ICommand StatusCommand => new RelayCommand(obj => ChangeStatus());

        private void ChangeStatus()
        {
            if (selectedBook != null)
            {
                DataBase.SqlConnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"delete from Books where book_id =" + selectedBook.ID;
                cmd.Connection = DataBase.SqlConnection;
                cmd.ExecuteNonQuery();
                if (selectedBook.Status == "Прочитано")
                {
                    cmd.CommandText = $"Insert into Books(user_id, Title, Author, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + selectedBook.Title + "','" + selectedBook.Author + "', '" + selectedBook.Genre + "', " + selectedBook.Year + ", '" + SelectedBook.Description + "', 'Непрочитано')";
                }
                else
                {
                    cmd.CommandText = $"Insert into Books(user_id, Title, Author, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + selectedBook.Title + "','" + selectedBook.Author + "', '" + selectedBook.Genre + "', " + selectedBook.Year + ", '" + SelectedBook.Description + "', 'Прочитано')";
                }
                cmd.ExecuteNonQuery();

                string sqlExpression = "SELECT * FROM Books where Title='" + selectedBook.Title + "' and Description='" + selectedBook.Description + "'";

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

                            Books.Add(new Book(Convert.ToInt32(book_id.ToString()), title.ToString(), author.ToString(),
                                genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));
                        }
                    }
                    reader.Close();
                }
                DataBase.SqlConnection.Close();

                Books.Remove(selectedBook);
            }
            else
                MessageBox.Show("Выберите книгу");
        }
    }
}
