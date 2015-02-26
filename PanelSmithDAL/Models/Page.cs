using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;

namespace PanelSmithDAL.Models
{
    public class Page
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int PageID { get; set; }
        public int ProjectID { get; set; }
        public virtual ICollection<Image<Bgr, Byte>> images {get; set; }
    }
}
