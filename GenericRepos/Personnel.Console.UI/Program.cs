using Personnel.DAL;

namespace Personnel.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork=new UnitOfWork(new PersonnelDbContext());
            
            unitOfWork.PersonnelRepository.Add(new Personnel.Domains.Personnel{Name="Filiz",LastName="Ünal",isActive=true});
            unitOfWork.Complete();
            
            var sonuc =unitOfWork.PersonnelRepository.GetAll();
            foreach (var item in sonuc)
            {   
                System.Console.WriteLine($"Ad : {item.Name} Soyad : {item.LastName}");
            }
            
            // var db=new PersonnelDbContext();
            // db.Add(new Personnel.Domains.Personnel{Name="Serap",LastName="Vardal",isActive=true});
            // db.SaveChanges();
            // System.Console.WriteLine("İşlem Tamam");
            // var sonuc=db.Personnels;
            // //Personnel[] sonuc =db.Personnels;

            
            // foreach (var item in sonuc)
            // {   
            //     System.Console.WriteLine($"Ad : {item.Name}");
            // }


        }
    }
}
