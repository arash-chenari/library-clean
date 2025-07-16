using Library.Application.Categories.Contracts.Dtos;
using Library.Entities;

namespace Library.Application.Categories.Contracts
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        bool DoesCategoryTitleExist(string title);
        List<GetCategoryDto> GetAll();
    }
}
