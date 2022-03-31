using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    public interface IPayRepository
    {
        Pay GetPay(int id);
        IEnumerable<Pay> GetAllPay();
        Pay Add(Pay pay);
        Pay Update(Pay payChange);
        Pay Delete(int id);
    }
}
