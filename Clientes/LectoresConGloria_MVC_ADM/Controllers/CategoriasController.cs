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
    public class CategoriasController : Controller
    {
        private Database_Context db = new Database_Context();

        // GET: TBL_Categorias
        public ActionResult Index()
        {
            return View(db.TBL_Categorias.ToList());
        }

        // GET: TBL_Categorias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_Categorias tBL_Categorias = db.TBL_Categorias.Find(id);
            if (tBL_Categorias == null)
            {
                return HttpNotFound();
            }
            return View(tBL_Categorias);
        }

        // GET: TBL_Categorias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TBL_Categorias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre")] TBL_Categorias tBL_Categorias)
        {
            if (ModelState.IsValid)
            {
                db.TBL_Categorias.Add(tBL_Categorias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tBL_Categorias);
        }

        // GET: TBL_Categorias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_Categorias tBL_Categorias = db.TBL_Categorias.Find(id);
            if (tBL_Categorias == null)
            {
                return HttpNotFound();
            }
            return View(tBL_Categorias);
        }

        // POST: TBL_Categorias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre")] TBL_Categorias tBL_Categorias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tBL_Categorias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tBL_Categorias);
        }

        // GET: TBL_Categorias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_Categorias tBL_Categorias = db.TBL_Categorias.Find(id);
            if (tBL_Categorias == null)
            {
                return HttpNotFound();
            }
            return View(tBL_Categorias);
        }

        // POST: TBL_Categorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TBL_Categorias tBL_Categorias = db.TBL_Categorias.Find(id);
            db.TBL_Categorias.Remove(tBL_Categorias);
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
