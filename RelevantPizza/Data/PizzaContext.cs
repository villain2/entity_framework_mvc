using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RelevantPizza.Models;

namespace RelevantPizza.Data
{
    public class PizzaContext : DbContext
    {
        /// <summary>
        /// Constructor for Pizza Context Db
        /// </summary>
        /// <param name="options"></param>
        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Employee> Employees { get; set; }

        /// <summary>
        /// If you don't like Employees as table name you can override and specify what you want your table called.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
    }
}
