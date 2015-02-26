using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace PanelSmithDAL.Models
{
    public class UserProfile
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public Avatar UserAvatar { get; set; }


        public class Avatar
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [ForeignKey("UserProfile")]
            public int AvatarId { get; set; }
            public byte[] Image { get; set; }
        }
    }

}
