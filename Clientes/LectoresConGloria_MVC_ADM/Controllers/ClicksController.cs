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
    public class ClicksController : Controller
    {
        private Database_Context db = new Database_Context();

        // GET: TBL_Clicks
        public ActionResult Index()
        {
            var tBL_Clicks = db.TBL_Clicks.Include(t => t.TBL_Lectores).Include(t => t.TBL_Textos);
            return View(tBL_Clicks.ToList());
        }

        // GET: TBL_Clicks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_Clicks tBL_Clicks = db.TBL_Clicks.Find(id);
            if (tBL_Clicks == null)
            {
                return HttpNotFound();
            }
            return View(tBL_Clicks);
        }

        // GET: TBL_Clicks/Create
        public ActionResult Create()
        {
            ViewBag.IdLector = new SelectList(db.TBL_Lectores, "Id", "Nombre");
            ViewBag.IdTexto = new SelectList(db.TBL_Textos, "Id", "Titulo");
            return View();
        }

        // POST: TBL_Clicks/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdTexto,IdLector,TipoClick,FechaAlta")] TBL_Clicks tBL_Clicks)
        {
            if (ModelState.IsValid)
            {
                db.TBL_Clicks.Add(tBL_Clicks);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdLector = new SelectList(db.TBL_Lectores, "Id", "Nombre", tBL_Clicks.IdLector);
            ViewBag.IdTexto = new SelectList(db.TBL_Textos, "Id", "Titulo", tBL_Clicks.IdTexto);
            return View(tBL_Clicks);
        }

        // GET: TBL_Clicks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_Clicks tBL_Clicks = db.TBL_Clicks.Find(id);
            if (tBL_Clicks == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdLector = new SelectList(db.TBL_Lectores, "Id", "Nombre", tBL_Clicks.IdLector);
            ViewBag.IdTexto = new SelectList(db.TBL_Textos, "Id", "Titulo", tBL_Clicks.IdTexto);
            return View(tBL_Clicks);
        }

        // POST: TBL_Clicks/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdTexto,IdLector,TipoClick,FechaAlta")] TBL_Clicks tBL_Clicks)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tBL_Clicks).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdLector = new SelectList(db.TBL_Lectores, "Id", "Nombre", tBL_Clicks.IdLector);
            ViewBag.IdTexto = new SelectList(db.TBL_Textos, "Id", "Titulo", tBL_Clicks.IdTexto);
            return View(tBL_Clicks);
        }

        // GET: TBL_Clicks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_Clicks tBL_Clicks = db.TBL_Clicks.Find(id);
            if (tBL_Clicks == null)
            {
                return HttpNotFound();
            }
            return View(tBL_Clicks);
        }

        // POST: TBL_Clicks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TBL_Clicks tBL_Clicks = db.TBL_Clicks.Find(id);
            db.TBL_Clicks.Remove(tBL_Clicks);
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
