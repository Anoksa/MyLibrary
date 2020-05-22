using MyLibrary.View;
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

namespace MyLibrary.ViewModel
{
    public class SerialsViewModel : ViewModelBase
    {
        public SerialsViewModel()
        {
            Load();
        }

        public ICommand DetectiveCommand => new RelayCommand(obj => SearchDetective());
        public ICommand MelodramaCommand => new RelayCommand(obj => SearchMelodrama());
        public ICommand FantasticCommand => new RelayCommand(obj => SearchFantastic());
        public ICommand FantasyCommand => new RelayCommand(obj => SearchFantasy());
        public ICommand AdventureCommand => new RelayCommand(obj => SearchAdventure());
        public ICommand ComediCommand => new RelayCommand(obj => SearchComedi());
        public ICommand AllCommand => new RelayCommand(obj => SearchAll());
        public ICommand HorrosCommand => new RelayCommand(obj => SearchHorrors());
        public ICommand AddCommand => new RelayCommand(obj => AddNew());
        public ICommand DeleteCommand => new RelayCommand(obj => Delete());



        private void SearchDetective()
        {
            Serials.Clear();

            string sqlExpression = "SELECT * FROM Serials where Genre ='Детектив'";

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
                        object film_id = reader["Serial_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];


                        Serials.Add(new Serial(Convert.ToInt32(film_id.ToString()), title.ToString(),
                             genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }

            DataBase.SqlConnection.Close();
        }

        private void SearchMelodrama()
        {
            Serials.Clear();
            string sqlExpression = "SELECT * FROM Serials where Genre ='Мелодрама'";

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
                        object film_id = reader["Serial_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Serials.Add(new Serial(Convert.ToInt32(film_id.ToString()), title.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchFantastic()
        {
            Serials.Clear();
            string sqlExpression = "SELECT * FROM Serials where Genre ='Фантастика'";

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
                        object film_id = reader["Serial_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Serials.Add(new Serial(Convert.ToInt32(film_id.ToString()), title.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchFantasy()
        {
            Serials.Clear();
            string sqlExpression = "SELECT * FROM Serials where Genre ='Фэнтези'";

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
                        object film_id = reader["Serial_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Serials.Add(new Serial(Convert.ToInt32(film_id.ToString()), title.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchAdventure()
        {
            Serials.Clear();
            string sqlExpression = "SELECT * FROM Serials where Genre ='Приключения'";

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
                        object film_id = reader["Serial_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Serials.Add(new Serial(Convert.ToInt32(film_id.ToString()), title.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchComedi()
        {
            Serials.Clear();
            string sqlExpression = "SELECT * FROM Serials where Genre ='Комедия'";

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
                        object film_id = reader["Serial_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];


                        Serials.Add(new Serial(Convert.ToInt32(film_id.ToString()), title.ToString(),
                             genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchAll()
        {
            Serials.Clear();
            string sqlExpression = "SELECT * FROM Serials ";

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
                        object film_id = reader["Serial_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Serials.Add(new Serial(Convert.ToInt32(film_id.ToString()), title.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchHorrors()
        {
            Serials.Clear();
            string sqlExpression = "SELECT * FROM Serials where Genre ='Ужасы'";

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
                        object film_id = reader["Serial_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Serials.Add(new Serial(Convert.ToInt32(film_id.ToString()), title.ToString(),
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
            DataBase.SqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"delete from Serials where Serial_id =" + selectedSerial.ID;
            cmd.Connection = DataBase.SqlConnection;
            cmd.ExecuteNonQuery();
            Serials.Remove(selectedSerial);
        }

        private Serial selectedSerial;

        public Serial SelectedSerial
        {
            get => selectedSerial;
            set
            {
                selectedSerial = value;
                OnPropertyChanged("GetDescription");
            }
        }



        public ObservableCollection<Serial> Serials { get; set; } = new ObservableCollection<Serial>();

        private void Load()
        {

            string sqlExpression = "SELECT * FROM Serials";

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
                        object film_id = reader["Serial_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Serials.Add(new Serial(Convert.ToInt32(film_id.ToString()), title.ToString(),
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
                if (selectedSerial != null)
                    return selectedSerial.Description;
                return "";
            }
        }
    }
}
