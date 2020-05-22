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
    }
}
