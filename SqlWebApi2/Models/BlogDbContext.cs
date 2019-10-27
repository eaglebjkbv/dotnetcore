using Microsoft.EntityFrameworkCore;
namespace SqlWebApi2.Models
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