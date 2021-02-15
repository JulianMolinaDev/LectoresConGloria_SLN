using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LectoresConGloria_NET_MVC_ADM.Controllers
{
    public class CategoriaTextoController : Controller
    {
        readonly SVC_TextoCategoria _servicio;
        public CategoriaTextoController()
        {
            _servicio = new SVC_TextoCategoria();
        }
        public ActionResult CategoriasPorTexto(int id)
        {
            var modelo = _servicio.GetCategoriaPorTexto(id);
            return PartialView(modelo);
        }

        // GET: TextoCategoria/Delete/5
        public ActionResult Delete(int id)
        {
            var modelo = _servicio.GetAsociacionDetalle(id);
            return View(modelo);
        }

        // POST: TextoCategoria/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, V_AsociacionDetalle reg)
        {
            try
            {
                _servicio.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(reg);
            }
        }
    }
}