namespace OnlineAdmision.WebUI.Migrations
{
    using OnlineAdmision.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OnlineAdmision.BusinessService.EF.OnlineDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OnlineAdmision.BusinessService.EF.OnlineDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Courses.Add(new Models.Course(){
                Candidates=new List<Candidate>(),
                CreatedBy="Seed",
                CreatedOn=DateTime.Now,
                Duration=5,
                Fees=30000,
                isActive= true,
                Name="ASP.NET MVC"
            });

            context.SaveChanges();
        }
    }
}
