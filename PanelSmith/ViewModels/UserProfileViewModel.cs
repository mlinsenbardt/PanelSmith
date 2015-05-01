using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PanelSmithDAL.Models;

namespace PanelSmith.ViewModels
{
    public class UserProfileViewModel
    {
        public virtual UserProfile profile { get; set; }

        public virtual Avatar avatar { get; set; }

        public virtual LocalPasswordModel passwordModel { get; set; }
    }
}