using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindWebApi.Models;

namespace NorthwindWebApi.Controllers
{
    [ApiController]
    [Route("/")]
    public class EmployeesController : ControllerBase
    {
        NorthwindSQLitedbContext _context;
        public EmployeesController(NorthwindSQLitedbContext db)
        {
            _context = db;
        }

        [HttpGet("Employees")]
        public IEnumerable<Employee> Get()
        {
            var employees = _context.Employees.ToList();
            return employees;
        }
    }
}
