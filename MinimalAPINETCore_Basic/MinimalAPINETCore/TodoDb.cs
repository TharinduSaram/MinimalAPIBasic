
using Microsoft.EntityFrameworkCore;

namespace MinimalAPINETCore
{
    public class TodoDb :DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
       : base(options) { }

        public DbSet<ToDo> Todos => Set<ToDo>();

    }
}
