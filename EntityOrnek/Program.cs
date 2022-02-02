using System;
using System.Linq;
using Entities;
using ConsoleTables;

namespace EntityOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            var db=new Entities.OgrenciContext();

            db.Add(new Ogrenci{ad="Burak",soyad="Vardal"});
            db.SaveChanges();

            var ogrs=db.ogrenciler.ToList();
            
            var table=new ConsoleTable("Id","Ad","Soyad");
            foreach (var item in ogrs)
            {
               table.AddRow(item.ogrenciId,item.ad,item.soyad);
                // System.Console.WriteLine($"Ad :{item.ad} Soyad:{item.soyad}");
            }
            table.Write();
            //var say=db.ogrenciler.Count();
           //  System.Console.WriteLine("Kayıt Sayısı :{0}",say);
        }
    }
}
