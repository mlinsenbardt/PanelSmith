﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanelSmithDAL.Models;

namespace PanelSmithDAL.Repositories
{
    public interface IProjectRepository : IDisposable
    {
        IEnumerable<Project> GetProjects();
        IEnumerable<Project> GetProjectsByUserID(int projectId);
        IEnumerable<Project> GetProjectsByName(string projectName);
    }
}
