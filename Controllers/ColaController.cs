using ColaAPI.Manager;
using ColaAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ColaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColaController : ControllerBase
    {
        private readonly ColaManager manager = new ColaManager();

        // GET: api/<ColaController>
        [HttpGet]
        public IEnumerable<Cola> Get()
        {
            return manager.GetAll();
        }

        // GET api/<ColaController>/5
        [HttpGet("{id}")]
        public Cola Get(int id)
        {
            return manager.GetByID(id);
        }

        // POST api/<ColaController>
        [HttpPost]
        public Cola Post([FromBody] Cola value)
        {
            return manager.Add(value);
        }

        // PUT api/<ColaController>/5
        [HttpPut("{id}")]
        public Cola Put(int id, [FromBody] Cola value)
        {
            return manager.Update(id, value);
        }

        // DELETE api/<ColaController>/5
        [HttpDelete("{id}")]
        public Cola Delete(int id)
        {
            return manager.Delete(id);
        }
    }
}
