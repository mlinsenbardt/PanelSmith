﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace PanelSmithDAL.Models
{
    public class Project
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set;}
        public int UserID { get; set; }
        public string ProjectName { get; set; }

        public virtual ICollection<Page> Pages { get; set; }
        public virtual ICollection<Strip> Strips { get; set; }
    }
}
