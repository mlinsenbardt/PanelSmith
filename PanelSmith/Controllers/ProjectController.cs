using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;
using PanelSmithDAL.Models;
using PanelSmithDAL.Repositories;

namespace PanelSmith.Controllers
{
    public class ProjectController : Controller
    {
        //
        // GET: /Editor/
        private IProjectRepository projectRepository;

        public ProjectController()
        {
            this.projectRepository = new ProjectRepository(new UsersContext());
        }

        public ActionResult Index()
        {
            ViewBag.PanelCount = PanelCount();
            IEnumerable<Project> projects;
            projects = projectRepository.GetProjectsByUserID(WebSecurity.GetUserId(User.Identity.Name));
            return View(projects);
        }

        //this seems stupid but idk...
        private IEnumerable<SelectListItem> PanelCount()
        {
            List<SelectListItem> numPanelsList = new List<SelectListItem>();
            for (int count = 0; count < 4; count++)
            {
                numPanelsList.Add(new SelectListItem()
                {
                    Value = count.ToString(),
                    Text = count.ToString()
                });
            }
            return numPanelsList;
        }

        public ActionResult Details(int id = 0)
        {
            IEnumerable<Project> project = projectRepository.GetProjectsByUserID(id);
            if (project.Count() == 0)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        //
        // GET: /Editor/Create
        public ActionResult ProjectStringSearch(string projectName){
            IEnumerable<Project> projects = projectRepository.GetProjectsByName(projectName);
            ViewBag.Name = projectName;
            return View(projects);
        }

        public void GetProjectName(string projectName)
        {
            ViewBag.ProjectName = projectName;
        }

        public void GetPanelCount(int panelCount)
        {
            ViewBag.PanelCount = panelCount;
        }


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
