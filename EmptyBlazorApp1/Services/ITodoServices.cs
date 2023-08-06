using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Services
{
    public interface ITodoServices
    {
        public void Add(TodoItem item); 
        public IEnumerable<TodoItem> GetAll();
    }
}

