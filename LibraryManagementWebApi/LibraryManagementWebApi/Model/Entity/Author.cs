using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebApi.Model.Entity
{
    public class Author
    {   
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string AuthorName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
