using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    public class AssignTaskRepository: IAssignTaskRepository
    {
        private readonly AppDbContext context;

        public AssignTaskRepository(AppDbContext context)
        {
            this.context = context;
        }

        public AssignTask Add(AssignTask assignTask)
        {
            context.AssignTasks.Add(assignTask);
            context.SaveChanges();
            return assignTask;
        }

        public IEnumerable<AssignTask> GetAllAssignTask()
        {
            return context.AssignTasks;
        }

        public AssignTask GetAssignTask(int id)
        {
            return context.AssignTasks.Find(id);
        }

        public AssignTask Update(AssignTask assignTaskChange)
        {
            var assignTask = context.AssignTasks.Attach(assignTaskChange);
            assignTask.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return assignTaskChange;
        }

        public AssignTask Delete(int id)
        {
            AssignTask assignTask = context.AssignTasks.Find(id);
            if (assignTask != null)
            {
                context.AssignTasks.Remove(assignTask);
                context.SaveChanges();
            }
            return assignTask;
        }
    }
}
