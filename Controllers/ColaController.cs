using ColaAPI.Manager;
using ColaAPI.Model;
using Microsoft.AspNetCore.Http;
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<Cola> Get()
        {
            return manager.GetAll();
        }

        // GET api/<ColaController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public Cola GetById(int id)
        {
            return manager.GetByID(id);
        }

        // GET api/<ColaController>/brand/eks.
        [HttpGet("brand/{brand}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public Cola GetByBrand(string brand)
        {
            return manager.GetByBrand(brand);
        }
        
        [HttpGet("Producent/{Producent}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public Cola GetByProducent(string Producent)
        {
            return manager.GetByProducent(Producent);
        }

        // POST api/<ColaController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Cola Post([FromBody] Cola value)
        {
            return manager.Add(value);
        }

        // PUT api/<ColaController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public Cola Put(int id, [FromBody] Cola value)
        {
            return manager.Update(id, value);
        }

        // DELETE api/<ColaController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public Cola Delete(int id)
        {
            return manager.Delete(id);
        }
    }
}
