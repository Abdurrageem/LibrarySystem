using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class LibraryItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string YearPublished{ get; set; }

        public LibraryItem (int id , string title , string yearPublished)
        {
            Id = id;
            Title = title;
            YearPublished = yearPublished;

        }

        

    }
}
