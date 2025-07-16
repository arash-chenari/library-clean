using Library.Application.Categories;
using Library.Entities;

namespace Library.Persistence.EF.Categories
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private readonly EfDbContext _dbcontext;
        
        public EfCategoryRepository(EfDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Add(Category category)
        {
           _dbcontext.Categories.Add(category);
        }

        public List<GetCategoryDto> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
