using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace ListUsersAPI.Controllers
{
    public class User
    {
        /* id: number;
  name: string;
  username: string;
  email?: string;
          */
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }

        
    }
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
       static  User[] users = new User[] { 
           new User { id = 111, name = "Jekky", username = "Jekson", email = "JJ@gmaik.com" },
        new User { id = 112, name = "Bob", username = "Bobik", email = "BB@gmaik.com" },
         new User { id = 113, name = "Janet", username = "Jekson", email = "JanetJekson@gmaik.com" }
       };
        // new User( 112, "Bob", "Bobik", "BB@gmaik.com"),
        // new User( 113, "Janet", "Jekson", "JanetJekson@gmaik.com"),
        //     };
        string json = JsonSerializer.Serialize<User[]>(users);

        public string Json { get => json; set => json = value; }

    

        // string listUserStr = "[{'id': 1,'username': 'Vasa','name':'Vasiliev','email': 'Vasa@email.com'  }, {    'id': 2,    'username': 'Kolya',    'name': 'Nikolaev',    'email': 'Kolya@email.com'  },  {    'id': 3,    'username': 'Petya',    'name': 'Petrov',    'email': 'Petya@email.com'  },  {    'id': 4,       'username': 'Zina',       'name': 'Zinger',       'email': 'Zina@email.com'     }]";
        [HttpGet]
        public string Get()
        {

             string jsonString = System.IO.File.ReadAllText(@"C:\Users\asus\source\repos\ListUsersAPI\ListUserJson\users.json");
 /*           User[] user5 = JsonSerializer.Deserialize<User[]>(jsonString);
            Console.WriteLine(user5);
            Console.WriteLine(json);
 */
            return jsonString;
        }
     /*   public IEnumerable<string> Get()
        {
            string[] list = new string[] { "Value 1", "Value 2", "Value 3", "Value 4", "Value 5" };
            return list;
        }
     */
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "this id - " + id;
        }


    }
}
