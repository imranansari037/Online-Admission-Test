using OnlineAdmision.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineAdmision.BusinessService.EF
{
    public class OnlineDbContext : DbContext
    {
        public OnlineDbContext() : base("OAConnSt")
        {

        }

        public DbSet<Candidate> Candidates { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Address> Addresses { get; set; }
    }
}