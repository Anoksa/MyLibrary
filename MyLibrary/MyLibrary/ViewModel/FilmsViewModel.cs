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
using System.Windows;

namespace MyLibrary.ViewModel
{
    public class FilmsViewModel : ViewModelBase
    {
        public FilmsViewModel()
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
            Films.Clear();

            string sqlExpression = "SELECT * FROM Films where Genre ='Детектив'";

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
                        object film_id = reader["Film_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];


                        Films.Add(new Film(Convert.ToInt32(film_id.ToString()), title.ToString(),
                             genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }

            DataBase.SqlConnection.Close();
        }

        private void SearchMelodrama()
        {
            Films.Clear();
            string sqlExpression = "SELECT * FROM Films where Genre ='Мелодрама'";

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
                        object film_id = reader["Film_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Films.Add(new Film(Convert.ToInt32(film_id.ToString()), title.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchFantastic()
        {
            Films.Clear();
            string sqlExpression = "SELECT * FROM Films where Genre ='Фантастика'";

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
                        object film_id = reader["Film_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Films.Add(new Film(Convert.ToInt32(film_id.ToString()), title.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchFantasy()
        {
            Films.Clear();
            string sqlExpression = "SELECT * FROM Films where Genre ='Фэнтези'";

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
                        object film_id = reader["Film_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Films.Add(new Film(Convert.ToInt32(film_id.ToString()), title.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchAdventure()
        {
            Films.Clear();
            string sqlExpression = "SELECT * FROM Films where Genre ='Приключения'";

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
                        object film_id = reader["Film_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Films.Add(new Film(Convert.ToInt32(film_id.ToString()), title.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchComedi()
        {
            Films.Clear();
            string sqlExpression = "SELECT * FROM Films where Genre ='Комедия'";

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
                        object film_id = reader["Film_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];


                        Films.Add(new Film(Convert.ToInt32(film_id.ToString()), title.ToString(),
                             genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchAll()
        {
            Films.Clear();
            string sqlExpression = "SELECT * FROM Films ";

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
                        object film_id = reader["Film_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Films.Add(new Film(Convert.ToInt32(film_id.ToString()), title.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchHorrors()
        {
            Films.Clear();
            string sqlExpression = "SELECT * FROM Films where Genre ='Ужасы'";

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
                        object film_id = reader["Film_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Films.Add(new Film(Convert.ToInt32(film_id.ToString()), title.ToString(),
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
            if (selectedFilm != null)
            { 
                DataBase.SqlConnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"delete from Films where Film_id =" + selectedFilm.ID;
                cmd.Connection = DataBase.SqlConnection;
                cmd.ExecuteNonQuery();
                Films.Remove(selectedFilm);
            }
            else
                MessageBox.Show("Выберите фильм");
        }

        private Film selectedFilm;

        public Film SelectedFilm
        {
            get => selectedFilm;
            set
            {
                selectedFilm = value;
                OnPropertyChanged("GetDescription");
            }
        }



        public ObservableCollection<Film> Films { get; set; } = new ObservableCollection<Film>();

        private void Load()
        {

            string sqlExpression = "SELECT * FROM Films where user_id =" + User.user.ID;

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
                        object film_id = reader["Film_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Films.Add(new Film(Convert.ToInt32(film_id.ToString()), title.ToString(), 
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
                if (selectedFilm != null)
                    return selectedFilm.Description;
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
            Films.Clear();
            string sqlExpression = "SELECT Film_id, Title, Genre, Year, Description, Status FROM Films Where user_id ="+User.user.ID +" and Title like '%" + SearchB + "%'";

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
                        object film_id = reader["Film_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Films.Add(new Film(Convert.ToInt32(film_id.ToString()), title.ToString(),
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
            if (selectedFilm != null)
            {

                DataBase.SqlConnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"delete from Films where Film_id =" + selectedFilm.ID;
                cmd.Connection = DataBase.SqlConnection;
                cmd.ExecuteNonQuery();
                if (selectedFilm.Status == "Просмотрено")
                {
                    cmd.CommandText = $"Insert into Films(user_id, Title, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + SelectedFilm.Title + "', '" + SelectedFilm.Genre + "', " + SelectedFilm.Year + ", '" + SelectedFilm.Description + "', 'Непросмотрено')";
                }
                else
                {
                    cmd.CommandText = $"Insert into Films(user_id, Title, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + selectedFilm.Title + "', '" + selectedFilm.Genre + "', " + selectedFilm.Year + ", '" + SelectedFilm.Description + "', 'Просмотрено')";
                }
                cmd.ExecuteNonQuery();

                string sqlExpression = "SELECT * FROM Films where Title='" + selectedFilm.Title + "' and Description='" + selectedFilm.Description + "'";

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
                            object film_id = reader["Film_id"];
                            object title = reader["Title"];
                            object genre = reader["Genre"];
                            object year = reader["Year"];
                            object description = reader["Description"];
                            object status = reader["Status"];



                            Films.Add(new Film(Convert.ToInt32(film_id.ToString()), title.ToString(),
                                genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                        }
                    }
                    reader.Close();
                }
                DataBase.SqlConnection.Close();

                Films.Remove(selectedFilm);
            }
            else
                MessageBox.Show("Выберите фильм");
        }
    }
}
