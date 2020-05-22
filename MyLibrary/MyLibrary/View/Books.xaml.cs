using MyLibrary.Model;
using MyLibrary.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace MyLibrary.View
{
    /// <summary>
    /// Логика взаимодействия для Books.xaml
    /// </summary>
    public partial class Books : Page
    {
        public Books()
        {
            InitializeComponent();
            var books = new BooksViewModel();
            DataContext = books;
        }

       

       
    }
}
