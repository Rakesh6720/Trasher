using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trasher.Models;

namespace Trasher.DAL
{
    public class CompanyInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            var customers = new List<Customer>
            {
                new Customer{LastName="Alexander", FirstMidName="Carson", Address="1234 Coppertone Way", Zip=11111, PickupDay="Thursday"},
                new Customer{LastName="Alonso", FirstMidName="Meredith", Address="5454 Pine Road", Zip=22222, PickupDay="Friday" },
                new Customer{LastName="Norman", FirstMidName="Laura", Address="6890 Elmer Avenue", Zip=22222, PickupDay="Friday"},
                new Customer{LastName="Li", FirstMidName="Yan", Address="4323 Lime Street", Zip=33333, PickupDay="Monday"}
        };

            customers.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();
            var employees = new List<Employee>
            {
                new Employee{LastName="Olivetto", FirstMidName="Nino", Zip=11111},
                new Employee{LastName="Barzdukas", FirstMidName="Gytis", Zip=22222},
                new Employee{LastName="Anand", FirstMidName="Arturo", Zip=33333}
            };

            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
        }
    }
}