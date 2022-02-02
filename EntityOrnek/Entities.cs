using Microsoft.EntityFrameworkCore;

namespace Entities
{
    class Ogrenci{
        public int ogrenciId { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
    }
    class OgrenciContext: DbContext
    {
        public DbSet<Ogrenci> ogrenciler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlite("Data Source=Deneme.db"));
        }
    }


    
}