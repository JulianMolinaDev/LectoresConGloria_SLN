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
    public class TextosLibrosController : Controller
    {
        private Database_Context db = new Database_Context();

        // GET: TextosLibros
        public ActionResult Index()
        {
            var tBL_TextosLibros = db.TBL_TextosLibros.Include(t => t.TBL_Libros).Include(t => t.TBL_Textos);
            return View(tBL_TextosLibros.ToList());
        }

        // GET: TextosLibros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_TextosLibros tBL_TextosLibros = db.TBL_TextosLibros.Find(id);
            if (tBL_TextosLibros == null)
            {
                return HttpNotFound();
            }
            return View(tBL_TextosLibros);
        }

        // GET: TextosLibros/Create
        public ActionResult Create()
        {
            ViewBag.IdLibro = new SelectList(db.TBL_Libros, "Id", "Nombre");
            ViewBag.IdTexto = new SelectList(db.TBL_Textos, "Id", "Titulo");
            return View();
        }

        // POST: TextosLibros/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdLibro,IdTexto")] TBL_TextosLibros tBL_TextosLibros)
        {
            if (ModelState.IsValid)
            {
                db.TBL_TextosLibros.Add(tBL_TextosLibros);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdLibro = new SelectList(db.TBL_Libros, "Id", "Nombre", tBL_TextosLibros.IdLibro);
            ViewBag.IdTexto = new SelectList(db.TBL_Textos, "Id", "Titulo", tBL_TextosLibros.IdTexto);
            return View(tBL_TextosLibros);
        }

        // GET: TextosLibros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_TextosLibros tBL_TextosLibros = db.TBL_TextosLibros.Find(id);
            if (tBL_TextosLibros == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdLibro = new SelectList(db.TBL_Libros, "Id", "Nombre", tBL_TextosLibros.IdLibro);
            ViewBag.IdTexto = new SelectList(db.TBL_Textos, "Id", "Titulo", tBL_TextosLibros.IdTexto);
            return View(tBL_TextosLibros);
        }

        // POST: TextosLibros/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdLibro,IdTexto")] TBL_TextosLibros tBL_TextosLibros)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tBL_TextosLibros).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdLibro = new SelectList(db.TBL_Libros, "Id", "Nombre", tBL_TextosLibros.IdLibro);
            ViewBag.IdTexto = new SelectList(db.TBL_Textos, "Id", "Titulo", tBL_TextosLibros.IdTexto);
            return View(tBL_TextosLibros);
        }

        // GET: TextosLibros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_TextosLibros tBL_TextosLibros = db.TBL_TextosLibros.Find(id);
            if (tBL_TextosLibros == null)
            {
                return HttpNotFound();
            }
            return View(tBL_TextosLibros);
        }

        // POST: TextosLibros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TBL_TextosLibros tBL_TextosLibros = db.TBL_TextosLibros.Find(id);
            db.TBL_TextosLibros.Remove(tBL_TextosLibros);
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
