using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    public class PayRepository: IPayRepository
    {
        private readonly AppDbContext context;

        public PayRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Pay Add(Pay pay)
        {
            context.Pays.Add(pay);
            context.SaveChanges();
            return pay;
        }

        public IEnumerable<Pay> GetAllPay()
        {
            return context.Pays;
        }

        public Pay GetPay(int id)
        {
            return context.Pays.Find(id);
        }

        public Pay Update(Pay payChange)
        {
            var pay = context.Pays.Attach(payChange);
            pay.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return payChange;
        }

        public Pay Delete(int id)
        {
            Pay pay = context.Pays.Find(id);
            if (pay != null)
            {
                context.Pays.Remove(pay);
                context.SaveChanges();
            }
            return pay;
        }
    }
}
