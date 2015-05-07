using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using WebMatrix.WebData;
using PanelSmith.ViewModels;
using PanelSmithDAL.Models;
using PanelSmithDAL.Repositories;

namespace PanelSmith.Controllers
{
    public class ProjectController : Controller
    {
        //
        // GET: /Editor/
        private IProjectRepository projectRepository;
        private IUserProfileRepository profileRepository;

        public ProjectController()
        {
            this.projectRepository = new ProjectRepository(new UsersContext());
            this.profileRepository = new UserProfileRepository(new UsersContext());
        }

        public ActionResult Index()
        {
            ViewBag.PanelCount = PanelCount();
            IList<ProjectViewModel> projectViewModels = new List<ProjectViewModel>();
            IEnumerable<Project> projects;
            projects = projectRepository.GetProjectsByUserID(WebSecurity.GetUserId(User.Identity.Name));
            foreach (var project in projects)
            {
                ProjectViewModel projectViewModel = new ProjectViewModel();
                projectViewModel.project = project;
                projectViewModel.profile = profileRepository.GetProfileByID(WebSecurity.GetUserId(User.Identity.Name));
                projectViewModels.Add(projectViewModel);
            }
            return View(projectViewModels);
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
            IList<ProjectViewModel> projectViewModels = new List<ProjectViewModel>();
            IEnumerable<Project> projects = projectRepository.GetProjectsByName(projectName);
            ViewBag.Name = projectName;
            foreach(var project in projects){
                ProjectViewModel projectViewModel = new ProjectViewModel();
                projectViewModel.project = project;
                projectViewModel.profile = profileRepository.GetProfileByID(project.UserID);
                projectViewModels.Add(projectViewModel);
            }
            return View(projectViewModels);
        }

        [HttpPost]
        public ActionResult Create(string projectName, int panelCount)
        {
            //TODO add logic for creating project
            Project newProject = new Project();
            newProject.ProjectName = projectName;
            newProject.PanelCount = panelCount;
            newProject.UserID = WebSecurity.GetUserId(User.Identity.Name);
            profileRepository.UpdateProfileProjects(newProject);
            projectRepository.InsertProject(newProject);
            ViewBag.PanelCount = panelCount;
            ViewBag.ProjectName = projectName;
            ViewBag.ProjectID = newProject.ProjectID;

            return View(newProject);
        }

        [HttpPost]
        public ActionResult UpdateProject(string id, string imageData)
        {
            byte[] data = Convert.FromBase64String(imageData);

            Project oldProject = projectRepository.GetProjectByProjectId(Convert.ToInt32(id));
            oldProject.image = data;
            projectRepository.UpdateProject(oldProject);
            return RedirectToAction("Index");
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
