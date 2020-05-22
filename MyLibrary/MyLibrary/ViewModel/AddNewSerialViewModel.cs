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

namespace MyLibrary.ViewModel
{
    public class AddNewSerialViewModel : ViewModelBase
    {
        private string title;

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

        public ICommand AddCommand => new RelayCommand(obj => AddSerial());

        private void AddSerial()
        {
            try
            {
                SqlCommand command = new SqlCommand();
                DataBase.SqlConnection.Close();
                string genre0 = "Детектив";
                string genre1 = "Мелодрама";
                string genre2 = "Фантастика";
                string genre3 = "Фэнтези";
                string genre4 = "Приключения";
                string genre5 = "Комедия";
                string genre6 = "Ужасы";
                string status;


                #region Выбор переменных
                if (Genre == 0)
                {
                    if (Status)
                    {
                        status = "Проcмотрено";
                        command.CommandText = $"Insert into Serials(user_id, Title,  Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "', '" + genre0 + "', " + Year + ", '" + Description + "', '" + status + "')";

                    }
                    else
                    {
                        status = "Непросмотрено";
                        command.CommandText = $"Insert into Serials(user_id, Title,  Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "', '" + genre0 + "', " + Year + ", '" + Description + "', '" + status + "')";
                    }
                }
                else if (Genre == 1)
                {
                    if (Status)
                    {
                        status = "Просмотрено";
                        command.CommandText = $"Insert into Serials(user_id, Title,  Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "', '" + genre1 + "', " + Year + ", '" + Description + "', '" + status + "')";

                    }
                    else
                    {
                        status = "Непросмотрено";
                        command.CommandText = $"Insert into Serials(user_id, Title,  Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "', '" + genre1 + "', " + Year + ", '" + Description + "', '" + status + "')";
                    }
                }
                else if (Genre == 2)
                {
                    if (Status)
                    {
                        status = "Просмотрено";
                        command.CommandText = $"Insert into Serials(user_id, Title,  Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "', '" + genre2 + "', " + Year + ", '" + Description + "', '" + status + "')";

                    }
                    else
                    {
                        status = "Непросмотрено";
                        command.CommandText = $"Insert into Serials(user_id, Title,  Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "', '" + genre2 + "', " + Year + ", '" + Description + "', '" + status + "')";
                    }
                }
                else if (Genre == 3)
                {
                    if (Status)
                    {
                        status = "Просмотрено";
                        command.CommandText = $"Insert into Serials(user_id, Title,  Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "', '" + genre3 + "', " + Year + ", '" + Description + "', '" + status + "')";

                    }
                    else
                    {
                        status = "Непросмотрено";
                        command.CommandText = $"Insert into Serials(user_id, Title,  Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "', '" + genre3 + "', " + Year + ", '" + Description + "', '" + status + "')";
                    }
                }
                else if (Genre == 4)
                {
                    if (Status)
                    {
                        status = "Просмотрено";
                        command.CommandText = $"Insert into Serials(user_id, Title,  Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "', '" + genre4 + "', " + Year + ", '" + Description + "', '" + status + "')";

                    }
                    else
                    {
                        status = "Непросмотрено";
                        command.CommandText = $"Insert into Serials(user_id, Title,  Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "', '" + genre4 + "', " + Year + ", '" + Description + "', '" + status + "')";
                    }
                }
                else if (Genre == 5)
                {
                    if (Status)
                    {
                        status = "Просмотрено";
                        command.CommandText = $"Insert into Serials(user_id, Title,  Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "', '" + genre5 + "', " + Year + ", '" + Description + "', '" + status + "')";

                    }
                    else
                    {
                        status = "Непросмотрено";
                        command.CommandText = $"Insert into Serials(user_id, Title,  Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "', '" + genre5 + "', " + Year + ", '" + Description + "', '" + status + "')";
                    }
                }
                else if (Genre == 6)
                {
                    if (Status)
                    {
                        status = "Просмотрено";
                        command.CommandText = $"Insert into Serials(user_id, Title,  Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "', '" + genre6 + "', " + Year + ", '" + Description + "', '" + status + "')";

                    }
                    else
                    {
                        status = "Непросмотрено";
                        command.CommandText = $"Insert into Serials(user_id, Title,  Genre, Year, Description, Status) values (" + User.user.ID + ",'" + Title + "', '" + genre6 + "', " + Year + ", '" + Description + "', '" + status + "')";
                    }
                }
                #endregion


                DataBase.SqlConnection.Open();
                command.Connection = DataBase.SqlConnection;
                int number = command.ExecuteNonQuery();
                
                
                MessageBox.Show(number.ToString() + " сериал добавлен.");
                DataBase.SqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
