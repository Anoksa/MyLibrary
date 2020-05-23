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
    public class MangaViewModel : ViewModelBase
    {
        public MangaViewModel()
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
            Manga.Clear();

            string sqlExpression = "SELECT * FROM Manga where Genre ='Детектив' and user_id =" + User.user.ID;

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
                        object film_id = reader["Manga_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];


                        Manga.Add(new MangaM(Convert.ToInt32(film_id.ToString()), title.ToString(),
                             genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }

            DataBase.SqlConnection.Close();
        }

        private void SearchMelodrama()
        {
            Manga.Clear();
            string sqlExpression = "SELECT * FROM Manga where Genre ='Мелодрама' and user_id =" + User.user.ID;

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
                        object film_id = reader["Manga_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Manga.Add(new MangaM(Convert.ToInt32(film_id.ToString()), title.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchFantastic()
        {
            Manga.Clear();
            string sqlExpression = "SELECT * FROM Manga where Genre ='Фантастика' and user_id =" + User.user.ID;

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
                        object film_id = reader["Manga_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Manga.Add(new MangaM(Convert.ToInt32(film_id.ToString()), title.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchFantasy()
        {
            Manga.Clear();
            string sqlExpression = "SELECT * FROM Manga where Genre ='Фэнтези' and user_id =" + User.user.ID;

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
                        object film_id = reader["Manga_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Manga.Add(new MangaM(Convert.ToInt32(film_id.ToString()), title.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchAdventure()
        {
            Manga.Clear();
            string sqlExpression = "SELECT * FROM Manga where Genre ='Приключения' and user_id =" + User.user.ID;

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
                        object film_id = reader["Manga_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Manga.Add(new MangaM(Convert.ToInt32(film_id.ToString()), title.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchComedi()
        {
            Manga.Clear();
            string sqlExpression = "SELECT * FROM Manga where Genre ='Комедия' and user_id =" + User.user.ID;

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
                        object film_id = reader["Manga_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];


                        Manga.Add(new MangaM(Convert.ToInt32(film_id.ToString()), title.ToString(),
                             genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchAll()
        {
            Manga.Clear();
            string sqlExpression = "SELECT * FROM Manga  where user_id =" + User.user.ID;

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
                        object film_id = reader["Manga_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Manga.Add(new MangaM(Convert.ToInt32(film_id.ToString()), title.ToString(),
                            genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                    }
                }
                reader.Close();
            }
            DataBase.SqlConnection.Close();
        }

        private void SearchHorrors()
        {
            Manga.Clear();
            string sqlExpression = "SELECT * FROM Manga where Genre ='Ужасы' and user_id =" + User.user.ID;

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
                        object film_id = reader["Manga_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Manga.Add(new MangaM(Convert.ToInt32(film_id.ToString()), title.ToString(),
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
            if (selectedManga != null)
            {
                DataBase.SqlConnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"delete from Manga where Manga_id =" + selectedManga.ID;
                cmd.Connection = DataBase.SqlConnection;
                cmd.ExecuteNonQuery();
                Manga.Remove(selectedManga);
            }
            else
                MessageBox.Show("Выберите мангу");
        }

        private MangaM selectedManga;

        public MangaM SelectedManga
        {
            get => selectedManga;
            set
            {
                selectedManga = value;
                OnPropertyChanged("GetDescription");
            }
        }



        public ObservableCollection<MangaM> Manga { get; set; } = new ObservableCollection<MangaM>();

        private void Load()
        {

            string sqlExpression = "SELECT * FROM Manga where user_id="+User.user.ID;

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
                        object film_id = reader["Manga_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];



                        Manga.Add(new MangaM(Convert.ToInt32(film_id.ToString()), title.ToString(),
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
                if (selectedManga != null)
                    return selectedManga.Description;
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
            Manga.Clear();
            string sqlExpression = "SELECT Manga_id, Title,  Genre, Year, Description, Status FROM Manga Where   user_id =" + User.user.ID+ " and Title like '%" + SearchB + "%'";

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
                        object film_id = reader["Manga_id"];
                        object title = reader["Title"];
                        object genre = reader["Genre"];
                        object year = reader["Year"];
                        object description = reader["Description"];
                        object status = reader["Status"];


                        Manga.Add(new MangaM(Convert.ToInt32(film_id.ToString()), title.ToString(),
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

            if (selectedManga != null)
            {
                DataBase.SqlConnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"delete from Manga where Manga_id =" + selectedManga.ID;
                cmd.Connection = DataBase.SqlConnection;
                cmd.ExecuteNonQuery();
                if (selectedManga.Status == "Прочитано")
                {
                    cmd.CommandText = $"Insert into Manga(user_id, Title, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + SelectedManga.Title + "', '" + SelectedManga.Genre + "', " + SelectedManga.Year + ", '" + SelectedManga.Description + "', 'Непрочитано')";
                }
                else
                {
                    cmd.CommandText = $"Insert into Manga(user_id, Title, Genre, Year, Description, Status) values (" + User.user.ID + ",'" + selectedManga.Title + "', '" + selectedManga.Genre + "', " + selectedManga.Year + ", '" + SelectedManga.Description + "', 'Прочитано')";
                }
                cmd.ExecuteNonQuery();

                string sqlExpression = "SELECT * FROM Manga where Title='" + selectedManga.Title + "' and Description='" + selectedManga.Description + "'";

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
                            object film_id = reader["Manga_id"];
                            object title = reader["Title"];
                            object genre = reader["Genre"];
                            object year = reader["Year"];
                            object description = reader["Description"];
                            object status = reader["Status"];



                            Manga.Add(new MangaM(Convert.ToInt32(film_id.ToString()), title.ToString(),
                                genre.ToString(), Convert.ToInt32(year.ToString()), description.ToString(), status.ToString()));

                        }
                    }
                    reader.Close();
                }
                DataBase.SqlConnection.Close();

                Manga.Remove(selectedManga);
            }
            else
                MessageBox.Show("Выберите мангу");
        }
    }
}
