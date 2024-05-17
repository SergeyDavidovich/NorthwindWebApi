using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindWebApi.Models;

namespace NorthwindWebApi.Controllers
{
    [ApiController]
    [Route("/")]
    public class ProductController : ControllerBase
    {
        NorthwindSQLitedbContext _context;
        public ProductController(NorthwindSQLitedbContext db)
        {
            _context = db;
        }

        [HttpGet("Products")]
        public IEnumerable<Product> Get()
        {
            var products = _context.Products;
            return products;
        }
    }
}
