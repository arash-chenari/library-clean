using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Books.Contracts.Dtos
{
    public class AddBookDto
    {
        [MaxLength(125)] public required string Title { get; set; }
        public required int Quantity { get; set; }
        public required int PageCount { get; set; }
        public required DateTime PublishDate { get; set; }
        [MaxLength(500)] public string? Description { get; set; }

        public required int CategoryId { get; set; }
    }
}
