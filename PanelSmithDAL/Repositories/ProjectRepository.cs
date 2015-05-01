using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanelSmithDAL.Models;

namespace PanelSmithDAL.Repositories
{
    public class ProjectRepository : IProjectRepository, IDisposable
    {
        private UsersContext context;

        public ProjectRepository(UsersContext context)
        {
            this.context = context;
        }

        public IEnumerable<Project> GetProjects()
        {
            return context.Projects.ToList();
        }

        public Project GetProjectByProjectId(int projectId)
        {
            return context.Projects.Find(projectId);
        }

        public IEnumerable<Project> GetProjectsByUserID(int id)
        {
            return context.Projects.Where(a => a.UserID == id).ToList();
        }

        public IEnumerable<Project> GetProjectsByName(string projectName)
        {
            return context.Projects.Where(a => a.ProjectName.ToLower().Contains(projectName.ToLower()));
        }

        public void InsertProject(Project project)
        {
            context.Projects.Add(project);
        }

        public void DeleteProject(int projectID)
        {
            Project project = context.Projects.Find(projectID);
            context.Projects.Remove(project);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
