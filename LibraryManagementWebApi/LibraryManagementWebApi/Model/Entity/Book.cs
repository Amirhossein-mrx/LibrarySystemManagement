using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementWebApi.Model.Entity
{
    public class Book
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string BookName { get; set; }

        [MaxLength(100)]
        [Required]
        public string Genre { get; set; }
        public int AuthorId { get; set; }

        public Author authors { get; set; }

        public virtual ICollection<BorrowingHistory> borrowinghistory { get; set; }
        public virtual ICollection<BookInPublisher> bookinpublisher { get; set; }
    }
}
