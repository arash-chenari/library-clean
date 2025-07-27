using Library.Application.Books.Contracts;
using Library.Entities.Abstraction;
using Library.Persistence.EF.Books;
using Library.Persistence.EF.Categories;

namespace Library.Persistence.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly EfDbContext _dbContext;
        public EFUnitOfWork(EfDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Commit()
        {
            _dbContext.Database.CommitTransaction();
        }


        public void RollBack()
        {
            _dbContext.Database.RollbackTransaction();
        }

        public void Begin()
        {
            _dbContext.Database.BeginTransaction();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }
    }

   /* public class Fakeunitofwork
    {
        private readonly EfDbContext dbContext;
        public Fakeunitofwork(EfDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public EfCategoryRepository CreateCategoryRepository()
        {
            return new EfCategoryRepository(dbContext);
        }

        public BookRepository CreateBookRepository()
        {
            return new BookRepository(dbContext);
        }

    }*/
}
