
using Ninject;
using Ninject.Modules;



namespace NinjectExample
{
    class Program
    {
        static void Main(string[] args)
        {
           // Eski Yol DI
           /* 
            Iloglama log=new LoglaMongo();
            BaseLogla baseLogla=new BaseLogla(log);
            System.Console.WriteLine(baseLogla.sifreYap("sifre yap"));
            System.Console.WriteLine(baseLogla.sifreCoz("sifre coz")); 
            */
            // Ninject kullanarak :

            IKernel kernel=new StandardKernel();
            kernel.Load(new LogBaglamaModulu());
            Iloglama logn=kernel.Get<Iloglama>();
            BaseLogla baseLoglan=new BaseLogla(logn);
            System.Console.WriteLine(baseLoglan.sifreCoz("Ninja şifre yap "));
            System.Console.WriteLine(baseLoglan.sifreYap("Ninja şifre Yap "));

        }
    }
// Ninject Modulden türetilmiş 
    class LogBaglamaModulu : NinjectModule
    {
        public override void Load()
        {
            Bind<Iloglama>().To<LoglaSql>();
        }
    }

}
