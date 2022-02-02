using System;
using System.Threading.Tasks;

namespace AsyncAwait4
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string Mesaj=await BekleAsync();
            System.Console.WriteLine($"Bitti {Mesaj}");


        }

        static Task<string> BekleAsync(){
            return Task.Run(()=>{
               System.Threading.Thread.Sleep(1500);
                return "Arkadaş...";
            });
        }
    }
}
