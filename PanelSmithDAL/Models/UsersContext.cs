using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace PanelSmithDAL.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("UsersContext")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<LoginModel> LoginModels { get; set; }
        public DbSet<RegisterModel> Registrations { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Strip> Strips { get; set; }

    }
}
