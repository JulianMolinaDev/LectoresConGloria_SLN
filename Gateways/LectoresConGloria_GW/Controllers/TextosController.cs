using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_FWK.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LectoresConGloria_GW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextosController : ControllerBase
    {
        private readonly ISVC_Texto _servicio;
        public TextosController(ISVC_Texto servicio)
        {
            _servicio = servicio;
        }
        // GET: api/<TextosController>
        [HttpGet]
        public IEnumerable<MDL_Texto> Get()
        {
            return _servicio.Get();
        }

        // GET api/<TextosController>/5
        [HttpGet("{id}")]
        public MDL_Texto Get(int id)
        {
            return _servicio.Get(id);
        }

        // POST api/<TextosController>
        [HttpPost]
        public void Post([FromBody] MDL_Texto value)
        {
            _servicio.Post(value);
        }

        // PUT api/<TextosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MDL_Texto value)
        {
            _servicio.Put(id, value);
        }

        // DELETE api/<TextosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _servicio.Delete(id);
        }
    }
}
