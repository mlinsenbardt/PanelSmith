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

        public IEnumerable<Project> GetProjectsByUserID(int id)
        {
            return context.Projects.Where(a => a.ProjectID == id).ToList();
        }

        public IEnumerable<Project> GetProjectsByName(string projectName)
        {
            return context.Projects.Where(a => a.ProjectName.Contains(projectName)).ToList();
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
