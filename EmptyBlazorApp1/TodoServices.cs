using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Services;

namespace TodoApp
{
    public class TodoServices : ITodoServices
    {
        private readonly IList<TodoItem> _todoItem;

        public TodoServices ()
        {
            _todoItem = new List<TodoItem>
            {
                new TodoItem("Code Daily"),
                new TodoItem("Plan Daily")
            };
        }

        public void Add(TodoItem item)
        {
            _todoItem.Add(item);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _todoItem.ToList();
        }
    }
}
