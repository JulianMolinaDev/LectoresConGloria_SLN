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
    public class TextosCategoriasController : ControllerBase
    {
        private readonly ISVC_TextoCategoria _servicio;
        public TextosCategoriasController(ISVC_TextoCategoria servicio)
        {
            _servicio = servicio;
        }
        // GET: api/<TextosCategoriasController>
        [HttpGet]
        public IEnumerable<MDL_TextoCategoria> Get()
        {
            return _servicio.Get();
        }

        // GET api/<TextosCategoriasController>/5
        [HttpGet("{id}")]
        public MDL_TextoCategoria Get(int id)
        {
            return _servicio.Get(id);
        }

        // POST api/<TextosCategoriasController>
        [HttpPost]
        public void Post([FromBody] MDL_TextoCategoria value)
        {
            _servicio.Post(value);
        }

        // PUT api/<TextosCategoriasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MDL_TextoCategoria value)
        {
            _servicio.Put(id, value);
        }

        // DELETE api/<TextosCategoriasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _servicio.Delete(id);
        }
    }
}
