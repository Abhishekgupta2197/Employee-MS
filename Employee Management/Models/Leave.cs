using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    public class Leave
    {
        public int LeaveId { get; set; }
        public string LeaveTitle { get; set; }
        public string LeaveReason { get; set; }
        public string ReasonStatus { get; set; }
        public int LeaveEmployeeId { get; set; }

        [NotMapped]
        public string EmpName { get; set; }
        //public ICollection<Employee> EmployeesList { get; set; }
    }
}
