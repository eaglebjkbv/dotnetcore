using Microsoft.EntityFrameworkCore;
using SqliteWebApi.Models;
namespace SqliteWebApi.Data
{
    public class BlogDbContext :DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
        : base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        
    }
}