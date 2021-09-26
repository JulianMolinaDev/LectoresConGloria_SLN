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
    public class LectoresController : Controller
    {
        private Database_Context db = new Database_Context();

        // GET: Lectores
        public ActionResult Index()
        {
            return View(db.TBL_Lectores.ToList());
        }

        // GET: Lectores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_Lectores tBL_Lectores = db.TBL_Lectores.Find(id);
            if (tBL_Lectores == null)
            {
                return HttpNotFound();
            }
            return View(tBL_Lectores);
        }

        // GET: Lectores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lectores/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Apellidos,FechaNacimiento,Correo,Password,FechaAlta")] TBL_Lectores tBL_Lectores)
        {
            if (ModelState.IsValid)
            {
                db.TBL_Lectores.Add(tBL_Lectores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tBL_Lectores);
        }

        // GET: Lectores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_Lectores tBL_Lectores = db.TBL_Lectores.Find(id);
            if (tBL_Lectores == null)
            {
                return HttpNotFound();
            }
            return View(tBL_Lectores);
        }

        // POST: Lectores/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Apellidos,FechaNacimiento,Correo,Password,FechaAlta")] TBL_Lectores tBL_Lectores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tBL_Lectores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tBL_Lectores);
        }

        // GET: Lectores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_Lectores tBL_Lectores = db.TBL_Lectores.Find(id);
            if (tBL_Lectores == null)
            {
                return HttpNotFound();
            }
            return View(tBL_Lectores);
        }

        // POST: Lectores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TBL_Lectores tBL_Lectores = db.TBL_Lectores.Find(id);
            db.TBL_Lectores.Remove(tBL_Lectores);
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
