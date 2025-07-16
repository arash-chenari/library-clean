using Library.Application.Categories.Contracts;
using Library.Application.Categories.Contracts.Dtos;
using Library.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Library.EndPoint.Api.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService _service;

        public CategoriesController(ICategoriesService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<GetCategoryDto> GetAll()
        {
            return _service.GetAll();
        }

        [HttpPost]
        public int Add(AddCategoryDto dto)
        {
            var id =  _service.Add(dto);
            return id;
        }
    }
}
