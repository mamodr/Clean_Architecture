using Eshop.Application.TodoLists.Queries.ExportTodos;

namespace Eshop.Application.Common.Interfaces;
public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
