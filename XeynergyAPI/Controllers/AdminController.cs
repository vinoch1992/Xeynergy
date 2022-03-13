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
    public class AdminController : Controller
    {
        private PersonContext _personContext;

        public AdminController(PersonContext personContext)
        {
            _personContext = personContext;
        }

        // GET: api/<AdminController>
        [HttpGet]
        public IEnumerable<Admin> Get()
        {
            return _personContext.Admins;
        }

        // GET api/<AdminController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return _personContext.Admins.FirstOrDefault(a => a.PersonId == id);
        }

        // POST api/<AdminController>
        [HttpPost]
        public void Post([FromBody] Admin value)
        {
            _personContext.Admins.Add(value);
            _personContext.SaveChanges();
        }

        // PUT api/<AdminController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Admin value)
        {
            var admin = _personContext.Admins.FirstOrDefault(a => a.PersonId == id);
            if (admin != null)
            {
                _personContext.Entry<Admin>(admin).CurrentValues.SetValues(value);
                _personContext.SaveChanges();
            }
        }

        // DELETE api/<AdminController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var admin = _personContext.Admins.FirstOrDefault(a => a.PersonId == id);
            if (admin != null)
            {
                _personContext.Admins.Remove(admin);
                _personContext.SaveChanges();
            }
        }
    }
}
