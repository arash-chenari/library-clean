using Library.Application.Categories.Contracts;
using Library.Application.Categories.Contracts.Dtos;
using Library.Application.Categories.Contracts.Exceptions;
using Library.Entities;

namespace Library.Application.Categories
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategoryRepository _repository;

        public CategoriesService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public int Add(AddCategoryDto dto)
        {
            //PreventToAddCategoryWithDuplicateTitle(dto);

            Category category = new Category
            {
                Title = dto.Title,
            };

            _repository.Add(category);

            return category.Id;
        }
        public List<GetCategoryDto> GetAll()
        {
            return _repository.GetAll();
        }



        private void PreventToAddCategoryWithDuplicateTitle(AddCategoryDto dto)
        {
            var DoesCategoryWithSameTitleExist =
                _repository.DoesCategoryTitleExist(dto.Title);

            if (DoesCategoryWithSameTitleExist)
            {
                throw new CategoryWithSameTitleIsAlreadyExistException();
            }
        }

      
    }
}
