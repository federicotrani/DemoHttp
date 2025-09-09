using DemoHttp.Models;

namespace DemoHttp.Services;

public interface ITodoService
{
    Task<List<Todo>> GetTodosAsync();

    Task<Todo?> GetTodoAsync(int id);
}
