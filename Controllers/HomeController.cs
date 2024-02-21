using GITPROJETOAPI.Data;
using GITPROJETOAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GITPROJETOAPI.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("/")]
        public List<TodoModel> Get([FromServices] AppDbContext context)
        {
            return context.Todos.ToList();
        }

        [HttpPost("/")]
        public TodoModel Post([FromBody] TodoModel todo, [FromServices] AppDbContext context)
        {   
            context.Add(todo);
            context.SaveChanges();

            return todo;
        }
    }
}