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
    public class TextosLibrosController : ControllerBase
    {
        private readonly ISVC_TextoLibro _servicio;
        public TextosLibrosController(ISVC_TextoLibro servicio)
        {
            _servicio = servicio;
        }
        // GET: api/<TextosLibrosController>
        [HttpGet]
        public async Task<IEnumerable<MDL_TextoLibro>> Get()
        {
            return await _servicio.Get();
        }

        // GET api/<TextosLibrosController>/5
        [HttpGet("{id}")]
        public async Task<MDL_TextoLibro> Get(int id)
        {
            return await _servicio.Get(id);
        }

        // POST api/<TextosLibrosController>
        [HttpPost]
        public async Task Post([FromBody] MDL_TextoLibro value)
        {
            await _servicio.Post(value);
        }

        // PUT api/<TextosLibrosController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] MDL_TextoLibro value)
        {
            await _servicio.Put(id, value);
        }

        // DELETE api/<TextosLibrosController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _servicio.Delete(id);
        }
    }
}
