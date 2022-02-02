using System;
using dataDal;

namespace ana
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person=new Person();
            person.id=100;
            person.ad="Bülent";
            Console.WriteLine($"Hello {person.ad} ");
        }
    }
}
