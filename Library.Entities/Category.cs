namespace Library.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public required AgeRange AgeRange { get; set; }
        public List<Book> Books { get; set; } = new();
    }

    public enum AgeRange
    {
        Children,
        Teenager,
        Adult,
    }
}
