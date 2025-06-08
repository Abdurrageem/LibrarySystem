using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Magazine : LibraryItem

    {
        public string IssueNumber { get; set; }
        public string Month { get; set; }

        public Magazine (int id, string title , string yearPublished , string issueNumber , string month) : base (id,title,yearPublished)
        {
            IssueNumber = issueNumber;
            Month = month;
        }

        public override string ToString()
        {
            return $"\nTitle:{Title} \nMonth:{Month} \nYearPublished:{YearPublished} \nIssueNumber:{IssueNumber} \nId:{Id.ToString()}";            
        }
    }
}
