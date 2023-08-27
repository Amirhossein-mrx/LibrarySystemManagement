using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementWebApi.Model.Entity
{
    public class Publisher
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string PublisherName { get; set; }

        public virtual ICollection<BookInPublisher> bookinpublisher { get; set; }
    }
}
