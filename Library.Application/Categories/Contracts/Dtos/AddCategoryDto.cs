using Library.Entities;

namespace Library.Application.Categories.Contracts.Dtos
{
    public class AddCategoryDto
    {
        public string Title { get; set; }
        public AgeRange AgeRange { get; set; }
    }
}
