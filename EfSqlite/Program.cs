
using System;
using System.Linq;

namespace EfSqlite
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db=new TodoContext()){

            
            db.Add(new Todo{todo="Gezilecek",isCompleted=false});
            db.SaveChanges();

            Console.WriteLine("Todo Listesi");
                var todo = db.Todos;
                foreach (var item in todo)
                {
                    System.Console.WriteLine($"{item.id}-{item.todo}-{item.isCompleted}");
                }
            }
        }
    }
}
