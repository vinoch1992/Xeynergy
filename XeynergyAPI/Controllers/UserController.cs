using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XeynergyAPI.Contexts;
using XeynergyAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace XeynergyAPI.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private PersonContext _personContext;

        public UserController(PersonContext personContext)
        {
            _personContext = personContext;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _personContext.Users;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return _personContext.Users.FirstOrDefault(a => a.PersonId == id);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] User value)
        {
            _personContext.Users.Add(value);
            _personContext.SaveChanges();
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User value)
        {
            var User = _personContext.Users.FirstOrDefault(a => a.PersonId == id);
            if (User != null)
            {
                _personContext.Entry<User>(User).CurrentValues.SetValues(value);
                _personContext.SaveChanges();
            }
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var User = _personContext.Users.FirstOrDefault(a => a.PersonId == id);
            if (User != null)
            {
                _personContext.Users.Remove(User);
                _personContext.SaveChanges();
            }
        }
    }
}
