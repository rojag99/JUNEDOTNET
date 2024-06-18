namespace LibraryList.Models.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; } // Foreign key property

        public Author Author { get; set; } // Navigation property

        // Other properties if any
    }
}
