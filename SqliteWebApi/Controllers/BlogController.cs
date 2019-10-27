using Microsoft.AspNetCore.Mvc;
using SqliteWebApi.Data;
using SqliteWebApi.Models;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SqliteWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController:ControllerBase
    {
        private readonly BlogDbContext _context;
        public BlogController(BlogDbContext context)
        {
            _context=context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Blog>>> GetBlogs(){
            return Ok(await _context.Blogs.ToListAsync());
        }
        // public ActionResult<IEnumerable<Blog>> GetBlogs()
        // {

        //     var result=_context.Blogs;
        //     if (result!=null){
        //         return Ok(result) ;
        //     }
        //     return NotFound();
        // }
        [HttpGet("{id:int}", Name = "Get")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Blog> Get(int id)
        {
            var result=_context.Blogs.Find(id);
            if(result==null){
                return NotFound();
            }
            return result;
            // try
            // {
            //     var result = _context.Blogs.Single(b => b.BlogId == id);
            //     return Ok(result);
            // }
            // catch (System.Exception)
            // {
            //     return NotFound();
            //     //throw;
            }
        
        [HttpPost]
        public ActionResult<Blog> PostBlogs(Blog blog)
        {
            _context.Blogs.Add(blog);
            _context.SaveChanges();
            
            // return CreatedAtAction(nameof(GetBlog),new Blog{BlogId=blog.BlogId},blog);
            //return "ok";
            return CreatedAtAction("Get","Blog",new {id=blog.BlogId},blog);
        }
        
    }
}
