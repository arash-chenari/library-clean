using Library.Application.Books.Contracts.Dtos;
using Library.Entities;

namespace Library.Application.Books.Contracts
{
    public interface IBookRepository
    {
        public void Patch();
        public bool Exists(int id);
        public Book GetById(int id);
        public void Post(Book book);
        public List<GetBookDto> GetAll();
        public void Delete(Book book);
    }
}
