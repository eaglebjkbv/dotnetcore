using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RestApiFromScratch.Fake;
using RestApiFromScratch.Models;

namespace RestApiFromScratch.Controllers
{
    [Route("api/[controller]")] // Controller ismi ne ise contoller kısmına gelecek Mesela (Users)
    public class UsersController: ControllerBase
    {
        private List<User> _users = FakeData.GetUsers(200);
        
        [HttpGet] // http://localhost:5000/api/users
        public List<User> Get(){
            return _users;
        }    
        [HttpGet("{id}")] // http://localhost:5000/api/users/1
        // HTTP get methoduna ID eklendiği zaman çağırılacak....
        public User GetUser(int id){
            var user = _users.FirstOrDefault(x => x.id == id);
            return user;
        }
        [HttpPost] // http://localhost:5000/api/users POST methodu ile veri ekleme
        public User Post([FromBody]User user){
            _users.Add(user);
            return user;
        }
        [HttpPut] // http://localhost:5000/api/users PUT methodu ile ver güncelleme
        public User Put([FromBody]User user){
            var editUser = _users.FirstOrDefault(x => x.id == user.id);
            editUser.FirstName = user.FirstName;
            editUser.LastName = user.LastName;
            editUser.Adress = user.Adress;
            return user;
        }
        [HttpDelete("{id}")] // http://localhost:5000/api/users/1 
        // HTTPDELETE methoduna ID eklendiği zaman çağırılacak....
        public void Delete(int id){
            var deleteUser = _users.FirstOrDefault(x => x.id == id);
            _users.Remove(deleteUser);
        }
    }
}