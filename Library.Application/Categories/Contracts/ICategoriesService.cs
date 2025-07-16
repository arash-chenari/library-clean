using Library.Application.Categories.Contracts.Dtos;

namespace Library.Application.Categories.Contracts
{
    public interface ICategoriesService
    {
        int Add(AddCategoryDto dto);
        List<GetCategoryDto> GetAll();
    }
}