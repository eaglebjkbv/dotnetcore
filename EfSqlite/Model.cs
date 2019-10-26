using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;



namespace EfSqlite
{
    public class TodoContext: DbContext
    {
        public DbSet<Todo> Todos{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=todos.db");
    }
    public class Todo
    {
        public int id { get; set; }
        public string todo { get; set; }
        public bool isCompleted { get; set; }    
    }
}