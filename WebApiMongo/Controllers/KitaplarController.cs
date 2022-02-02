using WebApiMongo.Models;
using WebApiMongo.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApiMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitaplarController:ControllerBase
    {
        private readonly KitapService _kitapService;

        public KitaplarController(KitapService kitapService){
            _kitapService=kitapService;
        }

        [HttpGet]
         public ActionResult<List<Kitap>> Get()=>
            _kitapService.Get();
        [HttpGet("{id:length(24)}",Name="GetKitap")]
        public ActionResult<Kitap> Get(string id)
        {
            var kitap=_kitapService.Get(id);

            if(kitap==null){
                return NotFound();
            }
            return kitap;
        }
        
        [HttpPost]
        public ActionResult<Kitap> Create(Kitap kitap)
        {
            _kitapService.Create(kitap);
            return CreatedAtRoute("GetKitap",new{id =kitap.Id.ToString()},kitap);
        }
        
    }
}