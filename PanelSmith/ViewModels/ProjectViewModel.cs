using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PanelSmithDAL.Models;
using PanelSmithDAL.Repositories;

namespace PanelSmith.ViewModels
{
    public class ProjectViewModel
    {
        public virtual Project project { get; set; }

        public virtual UserProfile profile { get; set; }
    }
}