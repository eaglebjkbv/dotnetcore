using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SqlWebApi2.Models;
using Microsoft.EntityFrameworkCore;

namespace SqlWebApi2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly BlogDbContext _context;
        public BlogController(BlogDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Blog>> GetBlogs(){
            return Ok(await _context.Blogs.ToListAsync());
        } 
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Blog>> GetBlog(int id){
            return Ok(await _context.Blogs.FindAsync(id));
        } 


        [HttpPost]
        public async Task<ActionResult<Blog>> PostTodoItem(Blog blog)

        {
            _context.Blogs.Add(blog);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBlog), new { id = blog.Id }, blog);
        }

    }
}