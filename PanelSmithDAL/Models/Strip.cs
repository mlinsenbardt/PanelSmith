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
    class Strip
    {
        public int StripID { get; set; }
        public virtual ICollection<Image<Bgr, Byte>> images { get; set; }
    }
}
