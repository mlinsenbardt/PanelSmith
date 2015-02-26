using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PanelSmithDAL.Models;
using PanelSmithDAL;

namespace PanelSmith.Controllers
{
    public class EditorController : Controller
    {
        //
        // GET: /Editor/
        private PanelSmithContext db = new PanelSmithContext();
        public ActionResult Index()
        {
            return View(db.Projects.ToList());
        }

        public ActionResult Details(int id = 0)
        {
            Project project = db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        //
        // GET: /Editor/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Editor/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Editor/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Editor/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Editor/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Editor/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
