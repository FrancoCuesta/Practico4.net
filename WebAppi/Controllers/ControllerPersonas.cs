using BusinessLayer.Implementations;
using BusinessLayer.Interfaces;
using DataAccessLayer.Implementations;
using DataAccessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerPersonas : ControllerBase
    {

        private IBL_Personas _bl;

        private IDAL_Personas _dal;
        
        public ControllerPersonas()
        {
            _dal = new DAL_Personas_EF();
            _bl = new BL_Personas(_dal);
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            return _bl.GetPersonas();
        }
        
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Persona Get(String documento)
        {
            return _bl.Get(documento);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public Persona Post([FromBody] Persona value)
        {
            return _bl.AddPersona(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
