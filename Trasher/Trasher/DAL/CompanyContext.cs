using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Trasher.Models;

namespace Trasher.DAL
{
    public class CompanyContext : DbContext
    {
        public CompanyContext() : base("CompanyContext")
        {
            Database.SetInitializer<CompanyContext>(new CompanyInitializer());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PickupDay> PickupDays { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}