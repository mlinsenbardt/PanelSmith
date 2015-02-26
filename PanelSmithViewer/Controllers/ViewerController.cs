using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PanelSmithDAL.Models;
using PanelSmithDAL;

namespace PanelSmithViewer.Controllers
{
    public class ViewerController : Controller
    {
        //
        // GET: /Viewer/
        private PanelSmithContext db = new PanelSmithContext();
        public ActionResult Index()
        {
            return View(db.Projects.ToList());
        }

        //
        // GET: /Viewer/Details/5

        public ActionResult Details(int id)
        {
            Project project = db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        //
        // GET: /Viewer/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Viewer/Create

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
        // GET: /Viewer/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Viewer/Edit/5

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
        // GET: /Viewer/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Viewer/Delete/5

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
