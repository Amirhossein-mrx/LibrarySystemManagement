namespace LibraryManagementWebApi.Model.Entity
{
    public class BookInPublisher
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int PublisherId { get; set; }


        public Publisher Publishers { get; set; }
        public Book Books { get; set; }
    }
}
