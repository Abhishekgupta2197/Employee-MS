using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string AssignTaskStatus { get; set; }
        [NotMapped]
        public string EmpName { get; set; }

    }
}
