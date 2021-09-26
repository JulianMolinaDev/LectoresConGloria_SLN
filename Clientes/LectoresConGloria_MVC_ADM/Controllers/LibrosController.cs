using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LectoresConGloria_MVC_ADM.Models;

namespace LectoresConGloria_MVC_ADM.Controllers
{
    public class LibrosController : Controller
    {
        private Database_Context db = new Database_Context();

        // GET: Libros
        public ActionResult Index()
        {
            return View(db.TBL_Libros.ToList());
        }

        // GET: Libros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_Libros tBL_Libros = db.TBL_Libros.Find(id);
            if (tBL_Libros == null)
            {
                return HttpNotFound();
            }
            return View(tBL_Libros);
        }

        // GET: Libros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Libros/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Imagen")] TBL_Libros tBL_Libros)
        {
            if (ModelState.IsValid)
            {
                db.TBL_Libros.Add(tBL_Libros);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tBL_Libros);
        }

        // GET: Libros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_Libros tBL_Libros = db.TBL_Libros.Find(id);
            if (tBL_Libros == null)
            {
                return HttpNotFound();
            }
            return View(tBL_Libros);
        }

        // POST: Libros/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Imagen")] TBL_Libros tBL_Libros)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tBL_Libros).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tBL_Libros);
        }

        // GET: Libros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_Libros tBL_Libros = db.TBL_Libros.Find(id);
            if (tBL_Libros == null)
            {
                return HttpNotFound();
            }
            return View(tBL_Libros);
        }

        // POST: Libros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TBL_Libros tBL_Libros = db.TBL_Libros.Find(id);
            db.TBL_Libros.Remove(tBL_Libros);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
