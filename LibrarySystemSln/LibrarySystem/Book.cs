using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Book : LibraryItem
    {
        public string Author { get; set; }
        public string Genre { get; set; }

        public Book(int id, string title, string yearPublished, string author, string genre) : base( id,  title, yearPublished)
        {
            Author = author;
            Genre = genre;
        }

    }
}
