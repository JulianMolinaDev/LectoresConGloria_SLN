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

        // Get api/<FormatosLibrosController>/GetAsociacionDetalle/5
        [HttpGet("GetAsociacionDetalle/{id}")]
        public V_AsociacionDetalle GetAsociacionDetalle(int id)
        {
            return _servicio.GetAsociacionDetalle(id);
        }

        // Get api/<FormatosLibrosController>/GetContenido/5
        [HttpGet("GetContenido/{id}")]
        public V_LibroDescarga GetContenido(int id)
        {
            return _servicio.GetContenido(id);
        }
        // Get api/<FormatosLibrosController>/GetFaltantesFormatosByLibro/5
        [HttpGet("GetFaltantesFormatosByLibro/{id}")]
        public IEnumerable<V_Lista> GetFaltantesFormatosByLibro(int id)
        {
            return _servicio.GetFaltantesFormatosByLibro(id);
        }
        // Get api/<FormatosLibrosController>/GetFormatoAsItem/5
        [HttpGet("GetFormatoAsItem/{id}")]
        public V_Lista GetFormatoAsItem(int id)
        {
            return _servicio.GetFormatoAsItem(id);
        }
        // Get api/<FormatosLibrosController>/GetFormatosByLibro/5
        [HttpGet("GetFormatosByLibro/{id}")]
        public IEnumerable<V_ListaRelacion> GetFormatosByLibro(int id)
        {
            return _servicio.GetFormatosByLibro(id);
        }
        // Get api/<FormatosLibrosController>/GetLibroAsItem/5
        [HttpGet("GetLibroAsItem/{id}")]
        public V_Lista GetLibroAsItem(int id)
        {
            return _servicio.GetLibroAsItem(id);
        }
        // Get api/<FormatosLibrosController>/GetLibrosByFormato/5
        [HttpGet("GetLibrosByFormato/{id}")]
        public IEnumerable<V_ListaRelacion> GetLibrosByFormato(int id)
        {
            return _servicio.GetLibrosByFormato(id);
        }
        // Get api/<FormatosLibrosController>/CambiarContenido/5
        [HttpPut("CambiarContenido/{id}")]
        public void CambiarContenido(int id, [FromBody] string contenido)
        {
            _servicio.CambiarContenido(id, contenido);
        }
        // Get api/<FormatosLibrosController>/CambiarContenido/5
        [HttpPut("CambiarFormato/{idFormatoLibro}")]
        public void CambiarFormato(int idFormatoLibro, [FromBody] int idFormato)
        {
            _servicio.CambiarFormato(idFormatoLibro, idFormato);
        }
    }
}
