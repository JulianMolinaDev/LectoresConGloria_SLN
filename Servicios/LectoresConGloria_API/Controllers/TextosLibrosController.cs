using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_FWK.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LectoresConGloria_MDL.Vistas;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LectoresConGloria_API.Controllers
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
        public IEnumerable<MDL_TextoLibro> Get()
        {
            return _servicio.Get();
        }

        // GET api/<TextosLibrosController>/5
        [HttpGet("{id}")]
        public MDL_TextoLibro Get(int id)
        {
            return _servicio.Get(id);
        }

        // POST api/<TextosLibrosController>
        [HttpPost]
        public void Post([FromBody] MDL_TextoLibro value)
        {
            _servicio.Post(value);
        }

        // PUT api/<TextosLibrosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MDL_TextoLibro value)
        {
            _servicio.Put(id, value);
        }

        // DELETE api/<TextosLibrosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _servicio.Delete(id);
        }

        [HttpGet("GetAsociacionDetalle/{id}")]
        public V_AsociacionDetalle GetAsociacionDetalle(int id)
        {
            return _servicio.GetAsociacionDetalle(id);
        }

        [HttpGet("GetTextosPorLibro/{id}")]
        public IEnumerable<V_ListaRelacion> GetTextosPorLibro(int id)
        {
            return _servicio.GetTextosPorLibro(id);
        }
    }
}
