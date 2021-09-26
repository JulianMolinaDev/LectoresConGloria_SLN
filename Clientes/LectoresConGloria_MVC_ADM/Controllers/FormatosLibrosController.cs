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
    public class FormatosLibrosController : Controller
    {
        private Database_Context db = new Database_Context();

        // GET: FormatosLibros
        public ActionResult Index()
        {
            var tBL_FormatosLibros = db.TBL_FormatosLibros.Include(t => t.TBL_Formatos).Include(t => t.TBL_Libros);
            return View(tBL_FormatosLibros.ToList());
        }

        // GET: FormatosLibros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_FormatosLibros tBL_FormatosLibros = db.TBL_FormatosLibros.Find(id);
            if (tBL_FormatosLibros == null)
            {
                return HttpNotFound();
            }
            return View(tBL_FormatosLibros);
        }

        // GET: FormatosLibros/Create
        public ActionResult Create()
        {
            ViewBag.IdFormato = new SelectList(db.TBL_Formatos, "Id", "Nombre");
            ViewBag.IdLibro = new SelectList(db.TBL_Libros, "Id", "Nombre");
            return View();
        }

        // POST: FormatosLibros/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdLibro,IdFormato,Archivo")] TBL_FormatosLibros tBL_FormatosLibros)
        {
            if (ModelState.IsValid)
            {
                db.TBL_FormatosLibros.Add(tBL_FormatosLibros);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdFormato = new SelectList(db.TBL_Formatos, "Id", "Nombre", tBL_FormatosLibros.IdFormato);
            ViewBag.IdLibro = new SelectList(db.TBL_Libros, "Id", "Nombre", tBL_FormatosLibros.IdLibro);
            return View(tBL_FormatosLibros);
        }

        // GET: FormatosLibros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_FormatosLibros tBL_FormatosLibros = db.TBL_FormatosLibros.Find(id);
            if (tBL_FormatosLibros == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdFormato = new SelectList(db.TBL_Formatos, "Id", "Nombre", tBL_FormatosLibros.IdFormato);
            ViewBag.IdLibro = new SelectList(db.TBL_Libros, "Id", "Nombre", tBL_FormatosLibros.IdLibro);
            return View(tBL_FormatosLibros);
        }

        // POST: FormatosLibros/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdLibro,IdFormato,Archivo")] TBL_FormatosLibros tBL_FormatosLibros)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tBL_FormatosLibros).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdFormato = new SelectList(db.TBL_Formatos, "Id", "Nombre", tBL_FormatosLibros.IdFormato);
            ViewBag.IdLibro = new SelectList(db.TBL_Libros, "Id", "Nombre", tBL_FormatosLibros.IdLibro);
            return View(tBL_FormatosLibros);
        }

        // GET: FormatosLibros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_FormatosLibros tBL_FormatosLibros = db.TBL_FormatosLibros.Find(id);
            if (tBL_FormatosLibros == null)
            {
                return HttpNotFound();
            }
            return View(tBL_FormatosLibros);
        }

        // POST: FormatosLibros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TBL_FormatosLibros tBL_FormatosLibros = db.TBL_FormatosLibros.Find(id);
            db.TBL_FormatosLibros.Remove(tBL_FormatosLibros);
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
