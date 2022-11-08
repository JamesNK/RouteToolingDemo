using Microsoft.AspNetCore.Mvc;

namespace RouteToolingDemo.Controllers;

[Route("api/[controller]")]
public class TodoController
{
    private readonly DbContext _dbContext;

    public TodoController(DbContext dbContext) => _dbContext = dbContext;

    [HttpGet("{id}")]
    public Todo Get(int id) => _dbContext.Todos.Find(id);

    [HttpPut]
    public void Create([FromBody] Todo todo) => _dbContext.Todos.Add(todo);

    [HttpGet("[action]/{page:int?}")]
    public IEnumerable<Todo> Search(int? page, [FromQuery] string text)
    {
        return _dbContext.Todos
            .Where(t => t.Text.Contains(text))
            .Skip((page ?? 0) * 10)
            .Take(10);
    }
}
