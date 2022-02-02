
using System;

namespace EfSqlite
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db=new TodoContext()){

            
            db.Add(new Todo{todo="Ders Çalışılacak",isCompleted=false});
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
