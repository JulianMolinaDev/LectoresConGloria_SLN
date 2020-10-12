﻿using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LectoresConGloria_NET_MVC_ADM.Controllers
{
    public class TextoCategoriaController : Controller
    {
        readonly SVC_TextoCategoria _servicio;
        public TextoCategoriaController()
        {
            _servicio = new SVC_TextoCategoria();
        }
        // GET: TextoCategoria
        public ActionResult Index()
        {
            return View();
        }

        // GET: TextoCategoria/Details/5
        public ActionResult Details(int id)
        {
            var modelo = _servicio.Get(id);
            return View(modelo);
        }

        // GET: TextoCategoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TextoCategoria/Create
        [HttpPost]
        public ActionResult Create(MDL_TextoCategoria reg)
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

        // GET: TextoCategoria/Edit/5
        public ActionResult Edit(int id)
        {
            var modelo = _servicio.Get(id);
            return View(modelo);
        }

        // POST: TextoCategoria/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MDL_TextoCategoria reg)
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

        // GET: TextoCategoria/Delete/5
        public ActionResult Delete(int id)
        {
            var modelo = _servicio.Get(id);
            return View(modelo);
        }

        // POST: TextoCategoria/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, MDL_TextoCategoria reg)
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
