using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace ListUsersAPI.Controllers
{
    /*export interface Ilink {
  name: string;
  link: string;
}
     */
    public class linkList
    {
     //   public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
      
    }
    [Route("api/[controller]")]
    [ApiController]
    public class LinksController  : ControllerBase
    {
        [HttpGet]
        public async Task<linkList[]> Get()
        {
            using FileStream openStream = System.IO.File.OpenRead(@"C:\Users\asus\source\repos\ListUsersAPI\ListUserJson\links.json");
            linkList[] users = await JsonSerializer.DeserializeAsync<linkList[]>(openStream);

            return users;
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
