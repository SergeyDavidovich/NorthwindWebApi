using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindWebApi.Models;
using System.Collections.ObjectModel;

namespace NorthwindWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet("Categories")]
        public IEnumerable<Category> Get()
        {
            return new List<Category>();
        }
    }
}
