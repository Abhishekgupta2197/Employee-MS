using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    public interface IAssignTaskRepository
    {
        AssignTask GetAssignTask(int id);
        IEnumerable<AssignTask> GetAllAssignTask();
        AssignTask Add(AssignTask assignTask);
        AssignTask Update(AssignTask assignTaskChange);
        AssignTask Delete(int id);
    }
}
