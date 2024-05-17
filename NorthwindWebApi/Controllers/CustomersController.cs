using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindWebApi.Models;

namespace NorthwindWebApi.Controllers
{
    [ApiController]
    [Route("/")]
    public class CustomersController : ControllerBase
    {
        NorthwindSQLitedbContext _context;
        public CustomersController(NorthwindSQLitedbContext db)
        {
            _context = db;
        }

        [HttpGet("Customers")]
        public IEnumerable<Customer> Get()
        {
            var customers = _context.Customers;
            return customers;
        }
    }
}
