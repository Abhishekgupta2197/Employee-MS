using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    public interface IHourRepository
    {
        Hour GetHour(int id);
        IEnumerable<Hour> GetAllHour();
        Hour Add(Hour hour);
        Hour Update(Hour hourChange);
        Hour Delete(int id);
    }
}
