using Library.Application.Categories;
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
            /* var result = Categories.Select(c => new GetCategoryDto
             {
                 Title = c.Title,
             }).ToList();

             return result;*/

            throw new NotImplementedException();
        }

        [HttpPost]
        public void Add(AddCategoryDto dto)
        {
            _service.Add(dto);
        }
    }





  



    
}
