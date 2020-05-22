using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Model
{
    public class Serial
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public string Genre { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }


        public Serial() { }
        public Serial(int id, string title, string genre, int year, string description, string status)
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
