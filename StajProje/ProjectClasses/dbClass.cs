using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Configuration;

namespace StajProje.ProjectClasses
{
    public class dbClass : DbContext
    {
        public dbClass() 
        {
            string connString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            this.Database.Connection.ConnectionString = connString;
        }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Failure> Failures { get; set; }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<dbClass>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}