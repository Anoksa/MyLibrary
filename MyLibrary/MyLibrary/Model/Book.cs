using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using MyLibrary.ViewModel;

namespace MyLibrary.Model
{


    public class Book 
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }


        public Book() { }
        public Book(int id, string title, string author, string genre, int year, string description, string status)
        {
            this.ID = id;
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
            this.Year = year;
            this.Description = description;
            this.Status = status;
        }

       

        
    }

}
