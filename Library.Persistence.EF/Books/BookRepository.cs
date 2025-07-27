using Library.Application.Books.Contracts;
using Library.Application.Books.Contracts.Dtos;
using Library.Entities;

namespace Library.Persistence.EF.Books
{
    public class BookRepository : IBookRepository
    {
        private readonly EfDbContext _context;

        public BookRepository(EfDbContext context)
        {
            _context = context;
        }

        public void Patch()
        {
            _context.SaveChanges();
        }

        public bool Exists(int id)
        {
            return _context.Books.Find(id) is not null;
        }

        public Book GetById(int id)
        {
            return _context.Books.Find(id)!;
        }

        public void Post(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public List<GetBookDto> GetAll()
        {
            return _context.Books.Select(book => new GetBookDto()
            {
                Id = book.Id,
                Title = book.Title,
                Quantity = book.Quantity,
                PageCount = book.PageCount,
                CategoryId = book.CategoryId,
                Description = book.Description,
                PublishDate = book.PublishDate,
            }).ToList();
        }

        public void Delete(Book book)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}
