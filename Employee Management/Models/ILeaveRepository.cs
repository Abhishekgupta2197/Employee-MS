using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    public interface ILeaveRepository
    {
        Leave GetLeave(int id);
        IEnumerable<Leave> GetAllLeave();
        Leave Add(Leave leave);
        Leave Update(Leave leaveChange);
        Leave Delete(int id);
    }
}
