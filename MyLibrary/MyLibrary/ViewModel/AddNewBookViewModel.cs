using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using MyLibrary.Model;
using MyLibrary.View;
using System.Text.RegularExpressions;


namespace MyLibrary.ViewModel
{
    class AddNewBookViewModel : ViewModelBase
    {
        private string title;
        private string author;
        private int year;
        private string description;
        private bool status;
        private int genre;

        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public string Author
        {
            get => author;
            set
            {
                author = value;
                OnPropertyChanged("Author");
            }
        }

        public int Year
        {
            get => year;
            set
            {
                year = value;
                OnPropertyChanged("Year");
            }
        }

        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        public bool Status
        {
            get => status;
            set
            {
                status = value;
                OnPropertyChanged("Status");
            }
        }

        public int Genre
        {
            get => genre;
            set
            {
                genre = value;
                OnPropertyChanged("Genre");
            }
        }

        public ICommand AddCommand => new RelayCommand(obj => AddBook());

        private void AddBook()
        {
            if (CheckField()) { 
                try
                {
                    SqlCommand command = new SqlCommand();
                    DataBase.SqlConnection.Close();
                    string genre0 = "Детектив";
                    string genre1 = "Романтика";
                    string genre2 = "Фантастика";
                    string genre3 = "Фэнтези";
                    string genre4 = "Приключения";
                    string genre5 = "Драма";
                    string genre6 = "Роман";
                    string status;


                    #region Выбор переменных
                    if (Genre == 0)
                    {
                        if (Status)
                        {
                            status = "Прочитано";
                            command.CommandText = $"Insert into Books(user_id, Title, Author, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "','" + Author + "', '" + genre0 + "', " + Year + ", '" + Description + "', '" + status + "')";

                        }
                        else
                        {
                            status = "Непрочитано";
                            command.CommandText = $"Insert into Books(user_id, Title, Author, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "','" + Author + "', '" + genre0 + "', " + Year + ", '" + Description + "', '" + status + "')";
                        }
                    }
                    else if(Genre == 1)
                    {
                        if (Status)
                        {
                            status = "Прочитано";
                            command.CommandText = $"Insert into Books(user_id, Title, Author, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "','" + Author + "', '" + genre1 + "', " + Year + ", '" + Description + "', '" + status + "')";

                        }
                        else
                        {
                            status = "Непрочитано";
                            command.CommandText = $"Insert into Books(user_id, Title, Author, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "','" + Author + "', '" + genre1 + "', " + Year + ", '" + Description + "', '" + status + "')";
                        }
                    }
                    else if (Genre == 2)
                    {
                        if (Status)
                        {
                            status = "Прочитано";
                            command.CommandText = $"Insert into Books(user_id, Title, Author, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "','" + Author + "', '" + genre2 + "', " + Year + ", '" + Description + "', '" + status + "')";

                        }
                        else
                        {
                            status = "Непрочитано";
                            command.CommandText = $"Insert into Books(user_id, Title, Author, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "','" + Author + "', '" + genre2 + "', " + Year + ", '" + Description + "', '" + status + "')";
                        }
                    }
                    else if (Genre == 3)
                    {
                        if (Status)
                        {
                            status = "Прочитано";
                            command.CommandText = $"Insert into Books(user_id, Title, Author, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "','" + Author + "', '" + genre3 + "', " + Year + ", '" + Description + "', '" + status + "')";

                        }
                        else
                        {
                            status = "Непрочитано";
                            command.CommandText = $"Insert into Books(user_id, Title, Author, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "','" + Author + "', '" + genre3 + "', " + Year + ", '" + Description + "', '" + status + "')";
                        }
                    }
                    else if (Genre == 4)
                    {
                        if (Status)
                        {
                            status = "Прочитано";
                            command.CommandText = $"Insert into Books(user_id, Title, Author, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "','" + Author + "', '" + genre4 + "', " + Year + ", '" + Description + "', '" + status + "')";

                        }
                        else
                        {
                            status = "Непрочитано";
                            command.CommandText = $"Insert into Books(user_id, Title, Author, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "','" + Author + "', '" + genre4 + "', " + Year + ", '" + Description + "', '" + status + "')";
                        }
                    }
                    else if (Genre == 5)
                    {
                        if (Status)
                        {
                            status = "Прочитано";
                            command.CommandText = $"Insert into Books(user_id, Title, Author, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "','" + Author + "', '" + genre5 + "', " + Year + ", '" + Description + "', '" + status + "')";

                        }
                        else
                        {
                            status = "Непрочитано";
                            command.CommandText = $"Insert into Books(user_id, Title, Author, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "','" + Author + "', '" + genre5 + "', " + Year + ", '" + Description + "', '" + status + "')";
                        }
                    }
                    else if (Genre == 6)
                    {
                        if (Status)
                        {
                            status = "Прочитано";
                            command.CommandText = $"Insert into Books(user_id, Title, Author, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "','" + Author + "', '" + genre6 + "', " + Year + ", '" + Description + "', '" + status + "')";

                        }
                        else
                        {
                            status = "Непрочитано";
                            command.CommandText = $"Insert into Books(user_id, Title, Author, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "','" + Author + "', '" + genre6 + "', " + Year + ", '" + Description + "', '" + status + "')";
                        }
                    }
                    #endregion


                    DataBase.SqlConnection.Open();
                    command.Connection = DataBase.SqlConnection;
                    int number = command.ExecuteNonQuery();
                    MessageBox.Show("Книга добавлена.");
                    DataBase.SqlConnection.Close();
                    Title = "";
                    Description = "";
                    Author = "";
                    Year = 0;
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private bool CheckField()
        {
            
            Regex rTitle = new Regex(@"[А-Яа-я]");
            Regex rAuthor = new Regex(@"[А-Яа-я]");
            Regex rYear = new Regex(@"\d{4}");
            Regex rDescription = new Regex(@"[А-Яа-я]");
            
            if (Title == null || Title.Length > 50)
            {
                MessageBox.Show("Проверьте название");
                return false;
            }
            if(Author == null || Author.Length > 50)
            {
                MessageBox.Show("Проверьте поле Автор");
            }


                if (!rTitle.IsMatch(Title) )
                {
                    MessageBox.Show("Название должно быть на русском\n");
                    return false;
                }
                if(!rAuthor.IsMatch(Author)|| Author.Length > 50 || Author.Length <0)
                {
                    MessageBox.Show("Проверьте поле Автор\n");
                    return false;
                }
                if (!rYear.IsMatch(Year.ToString()))
                {
                    MessageBox.Show("Неверно введён год\n");
                    return false;
                }
                if (!rDescription.IsMatch(Description))
                {
                    MessageBox.Show("Описание должно быть на русском языке");
                    return false;
                }
           
            return true;

        }
    }
}
