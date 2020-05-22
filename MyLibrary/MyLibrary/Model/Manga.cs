using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Model
{
    public class Manga
    {
        public int ID { get; set; }
        public string Title { get; set; }
       
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }


        public Manga() { }
        public Manga(int id, string title, string genre, int year, string description, bool status)
        {
            this.ID = id;
            this.Title = title;
            this.Genre = genre;
            this.Year = year;
            this.Description = description;
            this.Status = status;
        }
    }
}
