using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class TodoItem
    {
        public TodoItem(string text)
        {
            Text = text;        
        }
        public string Text { get; set; }
        public bool Completed { get; set; }

    }
}
