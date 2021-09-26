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
    public class TextosCategoriasController : Controller
    {
        private Database_Context db = new Database_Context();

        // GET: TextosCategorias
        public ActionResult Index()
        {
            var tBL_TextosCategorias = db.TBL_TextosCategorias.Include(t => t.TBL_Categorias).Include(t => t.TBL_Textos);
            return View(tBL_TextosCategorias.ToList());
        }

        // GET: TextosCategorias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_TextosCategorias tBL_TextosCategorias = db.TBL_TextosCategorias.Find(id);
            if (tBL_TextosCategorias == null)
            {
                return HttpNotFound();
            }
            return View(tBL_TextosCategorias);
        }

        // GET: TextosCategorias/Create
        public ActionResult Create()
        {
            ViewBag.IdCategoria = new SelectList(db.TBL_Categorias, "Id", "Nombre");
            ViewBag.IdTexto = new SelectList(db.TBL_Textos, "Id", "Titulo");
            return View();
        }

        // POST: TextosCategorias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdTexto,IdCategoria")] TBL_TextosCategorias tBL_TextosCategorias)
        {
            if (ModelState.IsValid)
            {
                db.TBL_TextosCategorias.Add(tBL_TextosCategorias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCategoria = new SelectList(db.TBL_Categorias, "Id", "Nombre", tBL_TextosCategorias.IdCategoria);
            ViewBag.IdTexto = new SelectList(db.TBL_Textos, "Id", "Titulo", tBL_TextosCategorias.IdTexto);
            return View(tBL_TextosCategorias);
        }

        // GET: TextosCategorias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_TextosCategorias tBL_TextosCategorias = db.TBL_TextosCategorias.Find(id);
            if (tBL_TextosCategorias == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCategoria = new SelectList(db.TBL_Categorias, "Id", "Nombre", tBL_TextosCategorias.IdCategoria);
            ViewBag.IdTexto = new SelectList(db.TBL_Textos, "Id", "Titulo", tBL_TextosCategorias.IdTexto);
            return View(tBL_TextosCategorias);
        }

        // POST: TextosCategorias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdTexto,IdCategoria")] TBL_TextosCategorias tBL_TextosCategorias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tBL_TextosCategorias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCategoria = new SelectList(db.TBL_Categorias, "Id", "Nombre", tBL_TextosCategorias.IdCategoria);
            ViewBag.IdTexto = new SelectList(db.TBL_Textos, "Id", "Titulo", tBL_TextosCategorias.IdTexto);
            return View(tBL_TextosCategorias);
        }

        // GET: TextosCategorias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_TextosCategorias tBL_TextosCategorias = db.TBL_TextosCategorias.Find(id);
            if (tBL_TextosCategorias == null)
            {
                return HttpNotFound();
            }
            return View(tBL_TextosCategorias);
        }

        // POST: TextosCategorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TBL_TextosCategorias tBL_TextosCategorias = db.TBL_TextosCategorias.Find(id);
            db.TBL_TextosCategorias.Remove(tBL_TextosCategorias);
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
