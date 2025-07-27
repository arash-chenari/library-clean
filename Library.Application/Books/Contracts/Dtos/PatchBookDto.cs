using System.ComponentModel.DataAnnotations;

namespace Library.Application.Books.Contracts.Dtos
{
    public class PatchBookDto
    {
        public int? Quantity { get; set; }
        public int? PageCount { get; set; }
        public DateTime? PublishDate { get; set; }
        [MaxLength(125)] public string? Title { get; set; }
        [MaxLength(500)] public string? Description { get; set; }

        public int? CategoryId { get; set; }
    }
}
