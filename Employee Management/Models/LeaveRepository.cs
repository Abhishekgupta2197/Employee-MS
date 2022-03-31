using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    public class LeaveRepository: ILeaveRepository
    {
        private readonly AppDbContext context;

        public LeaveRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Leave Add(Leave leave)
        {
            context.Leaves.Add(leave);
            context.SaveChanges();
            return leave;
        }

        public IEnumerable<Leave> GetAllLeave()
        {
            return context.Leaves;
        }

        public Leave GetLeave(int id)
        {
            return context.Leaves.Find(id);
        }

        public Leave Update(Leave leaveChange)
        {
            var leave = context.Leaves.Attach(leaveChange);
            leave.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return leaveChange;
        }

        public Leave Delete(int id)
        {
            Leave leave = context.Leaves.Find(id);
            if (leave != null)
            {
                context.Leaves.Remove(leave);
                context.SaveChanges();
            }
            return leave;
        }
    }
}
