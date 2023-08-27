using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebApi.Model.ViewModel
{
    public class BorrowingHistoryViewModel
    {
        public int BookId { get; set; }
        public int BorrowId { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
