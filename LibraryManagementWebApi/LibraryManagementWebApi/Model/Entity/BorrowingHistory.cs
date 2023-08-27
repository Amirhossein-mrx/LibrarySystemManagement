using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementWebApi.Model.Entity
{
    public class BorrowingHistory
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int BorrowId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime? ReturnDate { get; set; }


        public Book Books { get; set; }
        public Borrow Borrows { get; set; }
    }
}
