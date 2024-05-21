using Microsoft.EntityFrameworkCore;

namespace ToDoAPIDb.Models
{
    public class TodoItemContext : DbContext
    {
        public TodoItemContext(DbContextOptions<TodoItemContext> options) : base(options) { 
            
        }

        public DbSet<TodoItemDb> todoItems { get; set; } = null;
    }
}
