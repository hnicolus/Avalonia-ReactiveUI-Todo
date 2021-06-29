using System;

namespace Todo.Models
{
    public class TodoItem
    {
        public string Description { get; set; } = String.Empty;
        public bool IsChecked { get; set; }= false;
    }
}