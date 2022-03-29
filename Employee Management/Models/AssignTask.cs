using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    public class AssignTask
    {
        public int AssignTaskId { get; set; }
        public string AssignTaskName { get; set; }
        public string AssignTaskDec { get; set; }
        public int AssignTaskEmployeeId { get; set; }
        public string Priority { get; set; }
        //public Employee Employee { get; set; }

        public ICollection<Employee> EmployeesList { get; set; }

    }
}
