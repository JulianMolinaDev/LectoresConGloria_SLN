using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_FWK.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LectoresConGloria_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectoresController : ControllerBase
    {
        private readonly ISVC_Lector _servicio;
        public LectoresController(ISVC_Lector servicio)
        {
            _servicio = servicio;
        }
        // GET: api/<LectoresController>
        [HttpGet]
        public IEnumerable<MDL_Lector> Get()
        {
            return _servicio.Get();
        }

        // GET api/<LectoresController>/5
        [HttpGet("{id}")]
        public MDL_Lector Get(int id)
        {
            return _servicio.Get(id);
        }

        // POST api/<LectoresController>
        [HttpPost]
        public void Post([FromBody] MDL_Lector value)
        {
            _servicio.Post(value);
        }

        // PUT api/<LectoresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MDL_Lector value)
        {
            _servicio.Put(id, value);
        }

        // DELETE api/<LectoresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _servicio.Delete(id);
        }
    }
}
