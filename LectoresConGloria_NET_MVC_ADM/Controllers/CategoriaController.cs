using LectoresConGloria_MDL.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LectoresConGloria_SVC.Servicios;
using System.Threading.Tasks;

namespace LectoresConGloria_NET_MVC_ADM.Controllers
{
    public class CategoriaController : Controller
    {
        readonly SVC_Categoria _servicio;
        public CategoriaController()
        {
            _servicio = new SVC_Categoria();
        }
        // GET: Categoria
        public ActionResult Index()
        {
            var modelo = _servicio.Get();
            return View(modelo);
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            var modelo = _servicio.Get(id);
            return View(modelo);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View(new MDL_Categoria());
        }

        // POST: Categoria/Create
        [HttpPost]
        public ActionResult Create(MDL_Categoria reg)
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

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            var modelo = _servicio.Get(id);
            return View(modelo);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MDL_Categoria reg)
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

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            var modelo = _servicio.Get(id);
            return View(modelo);
        }

        // POST: Categoria/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, MDL_Categoria reg)
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
