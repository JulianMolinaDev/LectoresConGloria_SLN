using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_FWK.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LectoresConGloria_MDL.Vistas;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LectoresConGloria_GW.Controllers
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
        public async Task<IEnumerable<MDL_TextoCategoria>> Get()
        {
            return await _servicio.Get();
        }

        // GET api/<TextosCategoriasController>/5
        [HttpGet("{id}")]
        public async Task<MDL_TextoCategoria> Get(int id)
        {
            return await _servicio.Get(id);
        }

        // POST api/<TextosCategoriasController>
        [HttpPost]
        public async Task Post([FromBody] MDL_TextoCategoria value)
        {
            await _servicio.Post(value);
        }

        // PUT api/<TextosCategoriasController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] MDL_TextoCategoria value)
        {
            await _servicio.Put(id, value);
        }

        // DELETE api/<TextosCategoriasController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _servicio.Delete(id);
        }
        // GET api/<TextosCategoriasController>/GetAsociacionDetalle/5
        [HttpGet("GetAsociacionDetalle/{id}")]
        public async Task<V_AsociacionDetalle> GetAsociacionDetalle(int id)
        {
            return await _servicio.GetAsociacionDetalle(id);
        }
        // GET api/<TextosCategoriasController>/GetCategoriaPorTexto/5
        [HttpGet("GetCategoriaPorTexto/{id}")]
        public async Task<IEnumerable<V_ListaRelacion>> GetCategoriaPorTexto(int id)
        {
            return await _servicio.GetCategoriaPorTexto(id);
        }
    }
}
