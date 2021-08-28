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
    public class FormatosController : ControllerBase
    {
        private readonly ISVC_Formato _servicio;
        public FormatosController(ISVC_Formato servicio)
        {
            _servicio = servicio;
        }
        // GET: api/<FormatosController>
        [HttpGet]
        public IEnumerable<MDL_Formato> Get()
        {
            return _servicio.Get();
        }

        // GET api/<FormatosController>/5
        [HttpGet("{id}")]
        public MDL_Formato Get(int id)
        {
            return _servicio.Get(id);
        }

        // POST api/<FormatosController>
        [HttpPost]
        public void Post([FromBody] MDL_Formato value)
        {
            _servicio.Post(value);
        }

        // PUT api/<FormatosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MDL_Formato value)
        {
            _servicio.Put(id, value);
        }

        // DELETE api/<FormatosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _servicio.Delete(id);
        }
    }
}
