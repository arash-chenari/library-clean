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

        public void Add(AddCategoryDto dto)
        {
            Category category = new Category
            {
                Title = dto.Title,
            };

            _repository.Add(category);
        }
    }
}
