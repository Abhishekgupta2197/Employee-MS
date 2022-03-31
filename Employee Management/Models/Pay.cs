using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    public class Pay
    {
        public int PayId { get; set; }
        public double Amount { get; set; }
        public int PayEmployeeId { get; set; }
        [NotMapped]
        public string EmpName { get; set; }
        //public ICollection<Employee> EmployeesList { get; set; }

    }
}
