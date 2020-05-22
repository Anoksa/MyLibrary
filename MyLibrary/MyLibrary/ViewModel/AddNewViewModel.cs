using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using MyLibrary.View;

namespace MyLibrary.ViewModel
{
    public class AddNewViewModel : ViewModelBase
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

        public ICommand AddBooksCommand => new RelayCommand(obj => AddNewBookPage());
        public ICommand AddFilmsCommand => new RelayCommand(obj => AddNewFilmPage());
        public ICommand AddSerialsCommand => new RelayCommand(obj => AddNewSerialPage());
        public ICommand AddMangaCommand => new RelayCommand(obj => AddNewMangaPage());

        
        public void AddNewBookPage()
        {
            CurrentPage = new AddBookPage();
        }

        public void AddNewFilmPage()
        {
            CurrentPage = new AddFilmPage();
        }

        public void AddNewSerialPage()
        {
           CurrentPage = new AddSerialPage();
        }
        
        public void AddNewMangaPage()
        {
            CurrentPage = new AddMangaPage();
        }

    }
}
