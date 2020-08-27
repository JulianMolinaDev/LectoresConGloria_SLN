using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LectoresConGloria_MVC_ADM.Controllers
{
    public class TextoCategoriaController : Controller
    {
        // GET: TextoCategoriaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TextoCategoriaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TextoCategoriaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
