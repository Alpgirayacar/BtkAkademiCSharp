using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperOrnekBTKDomain.Repository
{
    public interface ITodoItemRepository
    {
        Task<List<TodoItem>> GetListAsync();

        Task<TodoItem> GetAsync(Guid id);

        Task<TodoItem> InsertAsync(TodoItem todoItem);

        Task<TodoItem> UpdateAsync(Guid id, TodoItem todoItem);

        Task DeleteAsync(Guid id);
    }

}
