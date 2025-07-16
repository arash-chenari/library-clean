using Library.Entities;

namespace Library.Application.Categories
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        List<GetCategoryDto> GetAll();
    }
}
