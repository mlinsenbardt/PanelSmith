using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Globalization;
using System.Web.Security;

namespace PanelSmithDAL.Models
{
    public class UsersContext : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public UsersContext()
            : base("UsersContext")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Avatar> Avatars { get; set; }
        public DbSet<LoginModel> LoginModels { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Strip> Strips { get; set; }
    }
}
