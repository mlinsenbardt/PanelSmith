using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelSmithDAL.Models
{
    public class Project
    {
        public int ProjectID { get; set;}
        public string ProjectName { get; set; }

        public virtual ICollection<Page> Pages { get; set; }
        public virtual ICollection<Strip> Strips { get; set; }

    }
}
