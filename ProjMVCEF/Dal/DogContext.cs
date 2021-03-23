using ProjMVCEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ProjMVCEF.Dal
{
    public class DogContext : DbContext
    {
        public DogContext() : base("DogContext")
        {
        }

        public DbSet<Dog> Dogs { set; get; }

       /* protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }*/
    }
}