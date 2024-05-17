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
        public async Task<IEnumerable<MDL_Texto>> Get()
        {
            return await _servicio.Get();
        }

        // GET api/<TextosController>/5
        [HttpGet("{id}")]
        public async Task<MDL_Texto> Get(int id)
        {
            return await _servicio.Get(id);
        }

        // POST api/<TextosController>
        [HttpPost]
        public async Task Post([FromBody] MDL_Texto value)
        {
            await _servicio.Post(value);
        }

        // PUT api/<TextosController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] MDL_Texto value)
        {
            await _servicio.Put(id, value);
        }

        // DELETE api/<TextosController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _servicio.Delete(id);
        }
    }
}
