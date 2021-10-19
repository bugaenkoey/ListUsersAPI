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
            User[] users2 = await JsonSerializer.DeserializeAsync<User[]>(openStream);

            return users2;
        }
      
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "this id - " + id;
        }

        [HttpPost]
        public void Post()
        {
            
        }

        [HttpPut]
        public string Put()
        {
            return "**PUT**";
        }

        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            
        }

    }
}
