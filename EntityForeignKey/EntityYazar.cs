using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityYazar
{
    // One to many ilişkisi var yazar ait birden fazla kitap olabilir.
    public class Yazar
    {
        public int YazarId { get; set; }
        public string YazarAdi  { get; set; }
        public ICollection<Kitap> Kitaplar { get; set; }
    // System.NullReferenceException hatasını engellemek için aşağıdaki kodlar eklenebilir.
    //  public Yazar()
    //  {
    //     Kitaplar = new List<Kitap>();
    //  }
    }
    public class Kitap
    {
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        // public int YazarId { get; set; }
        // public Yazar    yazar { get; set; }
    }

    public class KitapDbContext : DbContext
    {

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlite("Data Source=Kitap.db"));
        }
        public DbSet<Kitap> kitaplar { get; set; }
        public DbSet<Yazar> yazarlar { get; set; }

        
        
    }
}