namespace Library.Entities
{
    public class Category
    {
        public string Title { get; set; }
        public List<Book> Books { get; set; } = new();
    }
}
