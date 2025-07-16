using Library.Application.Categories.Contracts;
using Library.Application.Categories.Contracts.Dtos;
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
            _dbcontext.SaveChanges();
        }

        public bool DoesCategoryTitleExist(string title)
        {
            return _dbcontext.Categories.Any(c => c.Title == title);
        }

        public List<GetCategoryDto> GetAll()
        {
            return _dbcontext.Categories.Select(_ => new GetCategoryDto
            {
                 Id = _.Id,
                Title = _.Title,
            }).ToList();
        }
    }
}
