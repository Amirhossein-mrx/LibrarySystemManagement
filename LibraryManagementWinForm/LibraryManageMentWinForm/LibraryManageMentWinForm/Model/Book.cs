using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManageMentWinForm.Model
{
   public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Genre { get; set; }
        public int AuthorId { get; set; }
    }
}
