using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    public class HourRepository: IHourRepository
    {
        private readonly AppDbContext context;

        public HourRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Hour Add(Hour hour)
        {
            context.Hours.Add(hour);
            context.SaveChanges();
            return hour;
        }

        public IEnumerable<Hour> GetAllHour()
        {
            return context.Hours;
        }

        public Hour GetHour(int id)
        {
            return context.Hours.Find(id);
        }

        public Hour Update(Hour hourChange)
        {
            var hour = context.Hours.Attach(hourChange);
            hour.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return hourChange;
        }

        public Hour Delete(int id)
        {
            Hour hour = context.Hours.Find(id);
            if (hour != null)
            {
                context.Hours.Remove(hour);
                context.SaveChanges();
            }
            return hour;
        }
    }
}
