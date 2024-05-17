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
    public class CategoriasController : ControllerBase
    {
        private readonly ISVC_Categoria _servicio;
        public CategoriasController(ISVC_Categoria servicio)
        {
            _servicio = servicio;
        }
        // GET: api/<CategoriasController>
        [HttpGet]
        public async Task<IEnumerable<MDL_Categoria>> Get()
        {
            return await _servicio.Get();
        }

        // GET api/<CategoriasController>/5
        [HttpGet("{id}")]
        public async Task<MDL_Categoria> Get(int id)
        {
            return await _servicio.Get(id);
        }

        // POST api/<CategoriasController>
        [HttpPost]
        public async Task Post([FromBody] MDL_Categoria value)
        {
            await _servicio.Post(value);
        }

        // PUT api/<CategoriasController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] MDL_Categoria value)
        {
            await _servicio.Put(id, value);
        }

        // DELETE api/<CategoriasController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _servicio.Delete(id);
        }
    }
}
