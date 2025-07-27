using Library.Application.Books.Contracts.Dtos;

namespace Library.Application.Books.Contracts
{
    public interface IBookService
    {
        public void Delete(int id);
        public GetBookDto GetById(int id);
        public List<GetBookDto> GetAll();
        public int Add(AddBookDto dto);
        public void Edit(PatchBookDto dto, int id);
    }
}
