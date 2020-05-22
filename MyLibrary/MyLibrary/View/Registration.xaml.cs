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
using System.Windows.Shapes;
using MyLibrary.ViewModel;

namespace MyLibrary.View
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
            var reg = new RegistrationViewModel();
            DataContext = reg;
        }

        private void password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext != null)
                if (DataContext != null)
                { ((dynamic)DataContext).Password = ((PasswordBox)sender).Password; }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    
}
