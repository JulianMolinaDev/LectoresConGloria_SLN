using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LectoresConGloria_NET_MVC_ADM.Controllers
{
    public class TextoController : Controller
    {
        readonly SVC_Texto _servicio;
        public TextoController()
        {
            _servicio = new SVC_Texto();
        }
        // GET: Texto
        public ActionResult Index()
        {
            var modelo = _servicio.GetUltimos(10);
            return View(modelo);
        }

        // GET: Texto/Details/5
        public ActionResult Details(int id)
        {
            var modelo = _servicio.Get(id);
            return View(modelo);
        }

        // GET: Texto/Create
        public ActionResult Create()
        {
            var modelo = new MDL_Texto();
            return View(modelo);
        }

        // POST: Texto/Create
        [HttpPost]
        public ActionResult Create(MDL_Texto reg)
        {
            try
            {
                _servicio.Post(reg);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(reg);
            }
        }

        // GET: Texto/Edit/5
        public ActionResult Edit(int id)
        {
            var modelo = _servicio.Get(id);
            return View(modelo);
        }

        // POST: Texto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MDL_Texto reg)
        {
            try
            {
                _servicio.Put(id, reg);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(reg);
            }
        }

        // GET: Texto/Delete/5
        public ActionResult Delete(int id)
        {
            var modelo = _servicio.Get(id);
            return View(modelo);
        }

        // POST: Texto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, MDL_Texto reg)
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
        public ActionResult Busqueda(string titulo)
        {
            var modelo =_servicio.GetListaPorTitulo(titulo);
            return View(modelo);
        }
        [ChildActionOnly]
        public PartialViewResult Titulo(int id)
        {
            var modelo = _servicio.GetItem(id);
            return PartialView(modelo);
        }
    }
}
