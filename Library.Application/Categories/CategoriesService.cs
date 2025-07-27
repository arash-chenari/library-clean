using Library.Application.Categories.Contracts;
using Library.Application.Categories.Contracts.Dtos;
using Library.Application.Categories.Contracts.Exceptions;
using Library.Entities;
using Library.Entities.Abstraction;

namespace Library.Application.Categories
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategoryRepository _repository;
        private readonly IUnitOfWork _uow;

        public CategoriesService(ICategoryRepository repository, IUnitOfWork uow)
        {
            _repository = repository;
            _uow = uow;
        }

        public int Add(AddCategoryDto dto)
        {
            PreventToAddCategoryWithDuplicateTitle(dto);

            Category category = new Category
            {
                AgeRange = dto.AgeRange,
                Title = dto.Title,
            };

            _repository.Add(category);

            return category.Id;
        }
        public List<GetCategoryDto> GetAll()
        {
            return _repository.GetAll();
        }


        public void AddCategoryWithBooks()
        {
            //create category -> add with repository
            //crate book -> add with book repository
            _uow.Save();
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
