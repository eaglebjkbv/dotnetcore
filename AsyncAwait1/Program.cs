using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait1
{
    class Program
    {
        static  async Task Main(string[] args)
        {
            System.Console.WriteLine("Merhaba");
        
            await oyalaBiraz();
           
            Console.WriteLine("Hello World!");
            string yaz=await oyala2();
            System.Console.WriteLine(yaz);

            await Task.Run(()=>System.Console.WriteLine("Deneme"));
            string yazi2=await Task.Run(()=>"Deneme 2");
            System.Console.WriteLine(yazi2);

           
            

        }
       

        static async Task oyalaBiraz(){

           await Task.Run(()=>{
                Thread.Sleep(4000);
                
            });   
        }

        static async Task<string> oyala2(){

            string donus= await Task.Run(()=>{
                Thread.Sleep(2000);
                return "Selamlar";
            });
            return donus;

        }
    }
}
