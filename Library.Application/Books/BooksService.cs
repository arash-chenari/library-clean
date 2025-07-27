using Library.Application.Books.Contracts;
using Library.Application.Books.Contracts.Dtos;
using Library.Application.Books.Contracts.Exceptions;
using Library.Entities;
using Library.Entities.Abstraction;

namespace Library.Application.Books
{
    public class BooksService
    {
        private readonly IBookRepository _repository;
        private readonly IUnitOfWork _uow;

        public BooksService(IBookRepository repository, IUnitOfWork uow)
        {
            _repository = repository;
            _uow = uow;
        }

        public void Delete(int id)
        {
            _checkBookExistence(id);
            var book = _repository.GetById(id);
            _repository.Delete(book);
        }

        public GetBookDto GetById(int id)
        {
            _checkBookExistence(id);
            var book = _repository.GetById(id);
            return new GetBookDto()
            {
                Id = book.Id,
                Title = book.Title,
                Quantity = book.Quantity,
                PageCount = book.PageCount,
                PublishDate = book.PublishDate,
                Description = book.Description,

                CategoryId = book.CategoryId,
            };
        }

        public List<GetBookDto> GetAll()
        {
            return _repository.GetAll();
        }

        public int Add(AddBookDto dto)
        {
            var book = new Book()
            {
                Title = dto.Title,
                Quantity = dto.Quantity,
                PageCount = dto.PageCount,
                PublishDate = dto.PublishDate,
                Description = dto.Description,

                CategoryId = dto.CategoryId,
            };
            _repository.Post(book);

            return book.Id;
        }

        public void Edit(PatchBookDto dto, int id)
        {
            _checkBookExistence(id);
            var book = _repository.GetById(id);
            book.Title = dto.Title ?? book.Title;
            book.Quantity = dto.Quantity ?? book.Quantity;
            book.PageCount = dto.PageCount ?? book.PageCount;
            book.CategoryId = dto.CategoryId ?? book.CategoryId;
            book.PublishDate = dto.PublishDate ?? book.PublishDate;
            book.Description = dto.Description ?? book.Description;
            _repository.Patch();
        }

        private void _checkBookExistence(int id)
        {
            var exists = _repository.Exists(id);
            if (!exists) throw new BookNotFoundException();
        }
    }
}



/*
  bookservice handle business for  Add book 
  categoryservice handle bussines for add category

  upperlayer book servce .addbok
  upperlayer category service .add category 


 */