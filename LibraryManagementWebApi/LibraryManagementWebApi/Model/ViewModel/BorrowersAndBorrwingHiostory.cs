using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebApi.Model.ViewModel
{
    public class BorrowersAndBorrwingHiostory
    {
        public string BorrwerName { get; set; }
        public string BookName { get; set; }
        public string DeliveryDate { get; set; }
        public string ReturnDate { get; set; }
    }
}
