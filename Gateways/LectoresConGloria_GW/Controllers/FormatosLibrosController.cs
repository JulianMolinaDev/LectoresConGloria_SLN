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
        public IEnumerable<MDL_FormatoLibro> Get()
        {
            return _servicio.Get();
        }

        // GET api/<FormatosLibrosController>/5
        [HttpGet("{id}")]
        public MDL_FormatoLibro Get(int id)
        {
            return _servicio.Get(id);
        }

        // POST api/<FormatosLibrosController>
        [HttpPost]
        public void Post([FromBody] MDL_FormatoLibro value)
        {
            _servicio.Post(value);
        }

        // PUT api/<FormatosLibrosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MDL_FormatoLibro value)
        {
            _servicio.Put(id, value);
        }

        // DELETE api/<FormatosLibrosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _servicio.Delete(id);
        }
    }
}
