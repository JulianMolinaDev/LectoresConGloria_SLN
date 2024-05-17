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
    public class FormatosLibrosController : ControllerBase
    {
        private readonly ISVC_FormatoLibro _servicio;
        public FormatosLibrosController(ISVC_FormatoLibro servicio)
        {
            _servicio = servicio;
        }
        // GET: api/<FormatosLibrosController>
        [HttpGet]
        public async Task<IEnumerable<MDL_FormatoLibro>> Get()
        {
            return await _servicio.Get();
        }

        // GET api/<FormatosLibrosController>/5
        [HttpGet("{id}")]
        public async Task<MDL_FormatoLibro> Get(int id)
        {
            return await _servicio.Get(id);
        }

        // POST api/<FormatosLibrosController>
        [HttpPost]
        public async Task Post([FromBody] MDL_FormatoLibro value)
        {
            await _servicio.Post(value);
        }

        // PUT api/<FormatosLibrosController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] MDL_FormatoLibro value)
        {
            await _servicio.Put(id, value);
        }

        // DELETE api/<FormatosLibrosController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _servicio.Delete(id);
        }
    }
}
