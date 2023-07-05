using Eshop.Application.Common.Mappings;
using Eshop.Domain.Entities;

namespace Eshop.Application.TodoLists.Queries.ExportTodos;
public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
