using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using PanelSmithDAL.Models;

namespace PanelSmithDAL
{
    public class PanelSmithContext : DbContext
    {
        public PanelSmithContext()
            : base("PanelSmithContext")
        {

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Strip> Strips { get; set; }

        //Omit pluralization of table names
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
