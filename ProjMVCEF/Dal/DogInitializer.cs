using ProjMVCEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjMVCEF.Dal
{
    public class DogInitializer : DropCreateDatabaseIfModelChanges<DogContext>
    {
        protected override void Seed(DogContext context)
        {
            var dogs = new List<Dog>
            {
                new Dog{Id = 1, Name = "Mel" },
                new Dog{Id = 2, Name = "Java" }
            };

            dogs.ForEach(d => context.Dogs.Add(d));
            context.SaveChanges();
        }
    }
}