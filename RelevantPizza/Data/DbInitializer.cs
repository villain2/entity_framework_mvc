using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using RelevantPizza.Models;

namespace RelevantPizza.Data
{
    /// <summary>
    /// Initialize database. If it doesn't exist, create it
    /// </summary>
    public static class DbInitializer
    {
        /// <summary>
        /// Initialize using dependency injection
        /// </summary>
        /// <param name="context"></param>
        public static void Initialize(PizzaContext context)
        {
            // ensures database created. remove later to use migrations
            context.Database.EnsureCreated();

            // check to see if there are any roles in employees table
            if (context.Employees.Any())
            {
                return;
            }

            Employee[] employees = new Employee[]
            {
                new Employee{ FirstName = "Jesse", LastName = "Pinkman", PhoneNumber = "123-333-444", Role = Roles.Manager, Salary=100000M},
                new Employee{ FirstName = "Skylar", LastName = "White", PhoneNumber = "123-333-444", Role = Roles.AssistantManager, Salary=75000M},
                new Employee{ FirstName = "Walter", LastName = "White", PhoneNumber = "123-333-444", Role = Roles.Cashier, Salary=25000M}
            };

            // addRange takes in collectionn and adds it
            context.Employees.AddRange(employees);

            //save changes
            context.SaveChanges();
        }
    }
}
