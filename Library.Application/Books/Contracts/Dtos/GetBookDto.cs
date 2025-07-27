using System.ComponentModel.DataAnnotations;

namespace Library.Application.Books.Contracts.Dtos
{
    public class GetBookDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
        [MaxLength(500)] public string? Description { get; set; }
        [MaxLength(125)] public required string Title { get; set; }

        public int CategoryId { get; set; }
    }
}
