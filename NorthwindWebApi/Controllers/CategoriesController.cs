using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorthwindWebApi.Models;
using System.Collections.ObjectModel;

namespace NorthwindWebApi.Controllers
{
    [ApiController]
    [Route("/")]
    public class CategoriesController : ControllerBase
    {
        NorthwindSQLitedbContext _context;
        public CategoriesController(NorthwindSQLitedbContext db)
            {
             _context = db;
            }
        
        [HttpGet("Categories")]
        public IEnumerable<Category> Get()
        {
            var categories = _context.Categories;
            return categories;
        }
        //[HttpPost]
        //public async Task<ActionResult<Category>> PostTodoItem(Category todoItem)
        //{
        //    _context.TodoItems.Add(todoItem);
        //    await _context.SaveChangesAsync();

        //    //    return CreatedAtAction("PostTodoItem", new { id = todoItem.Id }, todoItem);
        //    return CreatedAtAction(nameof(PostTodoItem), new { id = todoItem.Id }, todoItem);
        //}
    }
}
