using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_NET_MVC_ADM.Models;
using LectoresConGloria_SVC.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LectoresConGloria_NET_MVC_ADM.Controllers
{
    public class TextoLibroController : Controller
    {
        private readonly SVC_TextoLibro _servicio;
        public TextoLibroController()
        {
            _servicio = new SVC_TextoLibro();
        }
        // GET: TextoLibro
        public ActionResult TextosPorLibro(int id)
        {
            var modelo = _servicio.GetTextosPorLibro(id);
            return View(modelo);
        }

        [HttpPost]
        public ActionResult AsociarLibroATexto(V_Asociacion asociacion)

        {
            _servicio.Post(new MDL_TextoLibro()
            {
                IdTexto = asociacion.Derecha,
                IdLibro = asociacion.Izquierda
            });
            return View();
        }

        [HttpPost]
        public ActionResult AsociarTextoALibro(V_Asociacion asociacion)
        {
            _servicio.Post(new MDL_TextoLibro()
            {
                IdTexto = asociacion.Izquierda,
                IdLibro = asociacion.Derecha
            });
            return View();
        }

        [HttpGet]
        public ActionResult TextoDesdeLibro(int id)
        {
            var modelo = new VM_TextoDesdeLibro()
            {
                idLibro = id,
                Texto = new MDL_Texto()
            };
            return View(modelo);
        }
        [HttpPost]
        public ActionResult TextoDesdeLibro(VM_TextoDesdeLibro modelo)
        {
            _servicio.TextoDesdeLibro(modelo.idLibro, modelo.Texto);
            return View(modelo);
        }
    }
}