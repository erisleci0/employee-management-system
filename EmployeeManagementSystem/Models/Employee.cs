using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public virtual int EmployeeId { get; set; }
        public virtual string Name { get; set; }
        public virtual string LastName { get; set; }
        public virtual int PhoneNumber { get; set; }
    }
}