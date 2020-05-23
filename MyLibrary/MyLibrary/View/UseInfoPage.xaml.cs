﻿using System;
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
using MyLibrary.Model;
using MyLibrary.ViewModel;

namespace MyLibrary.View
{
    /// <summary>
    /// Логика взаимодействия для UseInfoPage.xaml
    /// </summary>
    public partial class UseInfoPage : Page
    {
        public UseInfoPage()
        {
            InitializeComponent();
            var user = new UserInfoViewModel();
            DataContext = user;
        }
    }
}
