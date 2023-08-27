using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementWebApi.Model.Entity
{
    public class Borrow
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string UserName { get; set; }

        public virtual ICollection<BorrowingHistory> borrowinghistory { get; set; }
    }
}
