using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    public class Hour
    {
        public int HourId { get; set; }
        public DateTime DataofJob { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{hh:mm tt}")]
        public DateTime TimeIn { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{hh:mm tt}")]
        public DateTime TimeOut  { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{hh:mm tt}")]
        public DateTime BreakIn { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{hh:mm tt}")]
        public DateTime BreakOut { get; set; }

        public int HourEmployeeId { get; set; }
        [NotMapped]
        public string EmpName { get; set; }
    }
}
