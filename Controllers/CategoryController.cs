using Microsoft.AspNetCore.Mvc;
using TemporalBoxApi.Interfaces;
using TemporalBoxApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TemporalBoxApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory _category;
        public CategoryController(ICategory category)
        {
             _category = category;
        }
        
        [HttpGet("GetAllCategory")]
        public List<Categories> GetCat()
        {
            var data = _category.GetCategorieDetails();
            return data;
        }


        [HttpPost("AddCategory")]
        public Categories AddCategory(Categories category)
        {
            var data = _category.AddCategory(category);
            return data;
        }




        // GET api/<Cat_SubController>/5
        [HttpGet("{id}")]
        public Categories GetCategory(int id)
        {
           var data = _category.GetCategory(id);
            return data;
        }

      

        // PUT api/<Cat_SubController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Cat_SubController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
