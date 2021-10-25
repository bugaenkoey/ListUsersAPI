using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace ListUsersAPI.Controllers
{
    public class User
    {

        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }


    }
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
       
        [HttpGet]
        public async Task<User[]> Get()
        {
            using FileStream openStream = System.IO.File.OpenRead(@"C:\Users\asus\source\repos\ListUsersAPI\ListUserJson\users.json");
            User[] users = await JsonSerializer.DeserializeAsync<User[]>(openStream);

            return users;
        }
      
        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
           
            using FileStream openStream = System.IO.File.OpenRead(@"C:\Users\asus\source\repos\ListUsersAPI\ListUserJson\users.json");
            User[] users = await JsonSerializer.DeserializeAsync<User[]>(openStream);
            User oneUser= new User();
            foreach (var user in users)
            {
                if (user.id ==id)
                {
                    return user;
                }
            }
            
            return oneUser;
        }

        [HttpPost]
        public void Post()
        {
            
        }

        [HttpPut]
        public void Put()
        {
            
        }

        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            
        }

    }
}
