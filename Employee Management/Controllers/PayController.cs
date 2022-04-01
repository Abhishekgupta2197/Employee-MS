using Employee_Management.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Controllers
{
    [AllowAnonymous]
    public class PayController : Controller
    {
        private readonly IPayRepository payRepository;        
        private readonly IEmployeeRepository employeeRepository;

        public PayController(IPayRepository _payRepository, IEmployeeRepository employeeRepository)
        {
            payRepository = _payRepository;
            this.employeeRepository = employeeRepository;
        }

        public IActionResult Index()
        {
            var pay = payRepository.GetAllPay().ToList();
            var emp = employeeRepository.GetAllEmployee().ToList();
            foreach (var item in pay)
            {
                item.EmpName = emp.FirstOrDefault(x => x.ID == item.PayEmployeeId).Name;    
          
            }
           
            var model = payRepository.GetAllPay();
            
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var emps = employeeRepository.GetAllEmployee();
            ViewBag.Employee = emps.Select(x => new SelectListItem() { Text = x.Name.ToString(), Value = x.ID.ToString() });

            Pay po = new Pay();
            return PartialView("Create", po);
            //return View();
        }

        [HttpPost]
        public async Task<ActionResult> PostToPaypall(Pay pay)
        {
            if (ModelState.IsValid)
            {
              //  using var client = new HttpClient();

                string url = "https://www.sandbox.paypal.com/cgi-bing/webscr?cmd=_xclick&amount=" + pay.Amount
                    + "&business=sb-kpmax15511933@personal.example.com&item_name=Paycheck_From_EMS&return=https://localhost:44324/Pay/Create";

                Response.Redirect(url);

              //  var result = await client.GetAsync(url);

              //  payRepository.Add(pay);
                //return PartialView("Create", position);
              //  return RedirectToAction("Index");
            }
            return View();
        }


        [HttpPost]
        public IActionResult Create(Pay pay)
        {
            if (ModelState.IsValid)
            {
                payRepository.Add(pay);
                //return PartialView("Create", position);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var emps = employeeRepository.GetAllEmployee();
            ViewBag.Employee = emps.Select(x => new SelectListItem() { Text = x.Name.ToString(), Value = x.ID.ToString() });
            var pay = payRepository.GetPay(id);
            return PartialView("Edit", pay);
        }

        [HttpPost]
        public IActionResult Edit(Pay po)
        {
            payRepository.Update(po);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            payRepository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult CheckOut()
        {
            return View();
        }
    }
}
