using DemoHttp.Models;
using System.Net.Http.Json;

namespace DemoHttp.Services;

public class TodoService : ITodoService
{
    private readonly HttpClient _httpClient;

    public TodoService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Todo?> GetTodoAsync(int id)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<Todo>($"todos/{id}");
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<List<Todo>> GetTodosAsync()
    {
        try
        {
            var response = await _httpClient.GetFromJsonAsync<List<Todo>>("todos");
            return response.Take(10).ToList() ?? new List<Todo>();
        }
        catch (Exception)
        {

            throw;
        }
        throw new NotImplementedException();
    }
}
