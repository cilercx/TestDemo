using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestDemo.API.Models;

namespace TestDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet(Name = "GetPerson")]
        public Person Get()
        {
            Person person = new Person();

            person.Id = 1;
            person.Name = "Ciler";
            person.SurName = "Coskun";
            person.Email = "cilerrsahin@gmail.com";
            person.Age = 35;


            return person;

            
        }

    }
}
