using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace Personnel.DAL
{
    public class PersonnelDbContext: DbContext
    {
        public DbSet<Personnel.Domains.Personnel> Personnels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=blog.db");
    }
    }
}
