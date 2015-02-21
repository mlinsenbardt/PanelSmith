using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;

namespace PanelSmithDAL.Models
{
    public class Page
    {
        public int PageID { get; set; }
        public virtual ICollection<Image<Bgr, Byte>> images {get; set; }
    }
}
