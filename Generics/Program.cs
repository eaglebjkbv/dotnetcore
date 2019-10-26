using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            var liste=new List<int>(){10,20,30,40};
            
            foreach (var eleman in liste)
            {
                System.Console.WriteLine($"Liste laman : {eleman}");
            }
            var liste2=ogrenciler.Listele();
            foreach (var eleman in liste2)
            {
                System.Console.WriteLine($"Liste2 Elaman : {eleman}");
            }
            // linq sorgusu
            var listedensec=(from den in liste
                             where den>10
                             select den);

            foreach (var item in listedensec){
                System.Console.WriteLine(item);
            }
            
            
            

        }
    }
    abstract class ogrenciler
    {
        public static List<int> Listele(){
            return new List<int>{10,40,90};
        }

    }
    class deneEnumerable : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
