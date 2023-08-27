using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebApi.Model.ViewModel
{
    public class AddnewBookViewModel
    {

        public string bookName { get; set; }
        public string genre { get; set; }
        public int AutherId { get; set; }
        public int publisherId { get; set; }
    }
}
