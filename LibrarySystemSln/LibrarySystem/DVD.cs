using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class DVD : LibraryItem
    {
        public string Director { get; set; }
        public string Duration { get; set; }

        public DVD (int id, string title , string yearPublished,string director , string duration)  : base (id,title,yearPublished)
        {
            Director = director;
            Duration = duration;
        }

        public override string ToString()
        {
            return $"\nTitle:{Title} \nYearPublished:{YearPublished} \nDuration:{Duration} \nDirector:{Director} \nID:{Id}";
        }
    }
}
