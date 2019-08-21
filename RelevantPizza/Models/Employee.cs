using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelevantPizza.Models
{
    /// <summary>
    /// List of roles for company
    /// </summary>
    public enum Roles {
        Driver,
        Insider,
        AssistantManager,
        Manager,
        Cashier

    }

    /// <summary>
    /// 
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// employee's first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// employee's last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The role assigned
        /// </summary>
        public Roles Role { get; set; }

        /// <summary>
        /// employee phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// empoyee salary
        /// </summary>
        public decimal Salary { get; set; }
    }
}
