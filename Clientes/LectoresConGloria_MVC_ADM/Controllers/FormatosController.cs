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
    public class FormatosController : Controller
    {
        private Database_Context db = new Database_Context();

        // GET: Formatos
        public ActionResult Index()
        {
            return View(db.TBL_Formatos.ToList());
        }

        // GET: Formatos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_Formatos tBL_Formatos = db.TBL_Formatos.Find(id);
            if (tBL_Formatos == null)
            {
                return HttpNotFound();
            }
            return View(tBL_Formatos);
        }

        // GET: Formatos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Formatos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre")] TBL_Formatos tBL_Formatos)
        {
            if (ModelState.IsValid)
            {
                db.TBL_Formatos.Add(tBL_Formatos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tBL_Formatos);
        }

        // GET: Formatos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_Formatos tBL_Formatos = db.TBL_Formatos.Find(id);
            if (tBL_Formatos == null)
            {
                return HttpNotFound();
            }
            return View(tBL_Formatos);
        }

        // POST: Formatos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre")] TBL_Formatos tBL_Formatos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tBL_Formatos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tBL_Formatos);
        }

        // GET: Formatos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_Formatos tBL_Formatos = db.TBL_Formatos.Find(id);
            if (tBL_Formatos == null)
            {
                return HttpNotFound();
            }
            return View(tBL_Formatos);
        }

        // POST: Formatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TBL_Formatos tBL_Formatos = db.TBL_Formatos.Find(id);
            db.TBL_Formatos.Remove(tBL_Formatos);
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
