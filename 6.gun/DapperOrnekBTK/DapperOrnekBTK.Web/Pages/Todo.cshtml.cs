using DapperOrnekBTK.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoOrnekBTK.Application;

namespace DapperOrnekBTK.Web.Pages
{
    public class TodoModel : PageModel
    {
        public class Todos : PageModel
        {
            public List<TodoItemDto> TodoItems { get; set; }

            private readonly ITodoItemAppService _todoItemAppService;

            public Todos(ITodoItemAppService todoItemAppService)
            {
                _todoItemAppService = todoItemAppService;
            }

            public async Task OnGetAsync()
            {
                TodoItems = await _todoItemAppService.GetTodosAsync();
            }
        }
    }
}
