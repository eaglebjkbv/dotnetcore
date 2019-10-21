using Microsoft.AspNetCore.Mvc;

namespace WebApiMain.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SehirlerController:ControllerBase
    {
        [HttpGet]
        public string Get(){
            return "Merhaba";
        }
        
    }
}