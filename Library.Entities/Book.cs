namespace Library.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int PageCount { get; set; }
        public string? Description { get; set; }
        public required string Title { get; set; }
        public required DateTime PublishDate { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
