using Library.Application.Books.Contracts;
using Library.Application.Books.Contracts.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.EndPoint.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _service;

        public BooksController(IBookService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<GetBookDto> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("{id:int}")]
        public GetBookDto GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public int Add([FromBody] AddBookDto dto)
        {
            var id = _service.Add(dto);
            return id;
        }

        [HttpDelete("{id:int}")]
        public void Delete([FromRoute] int id)
        {
            _service.Delete(id);
        }

        [HttpPatch("{id:int}")]
        public void Edit([FromBody] PatchBookDto dto, [FromRoute] int id)
        {
            _service.Edit(dto, id);
        }
    }
}
