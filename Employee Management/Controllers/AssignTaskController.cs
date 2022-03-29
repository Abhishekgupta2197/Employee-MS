using Employee_Management.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace Employee_Management.Controllers
{
    public class AssignTaskController : Controller
    {
        private readonly IAssignTaskRepository assignTaskRepository;        
        private readonly IEmployeeRepository employeeRepository;

        public AssignTaskController(IAssignTaskRepository _assignTaskRepository, IEmployeeRepository employeeRepository)
        {
            assignTaskRepository = _assignTaskRepository;
            this.employeeRepository = employeeRepository;
        }

        //public AssignTaskController(IAssignTaskRepository assignTaskRepository)
        //{
        //    this.assignTaskRepository = assignTaskRepository;
        //}

        public IActionResult Index()
        {
            ViewBag.Employee = employeeRepository.GetAllEmployee().ToString();
            var model = assignTaskRepository.GetAllAssignTask();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var emps = employeeRepository.GetAllEmployee();
            ViewBag.Employee = emps.Select(x => new SelectListItem() { Text = x.Name.ToString(), Value = x.ID.ToString() });

            AssignTask po = new AssignTask();
            return PartialView("Create", po);
            //return View();
        }

        [HttpPost]
        public IActionResult Create(AssignTask assignTask)
        {
            if (ModelState.IsValid)
            {
                assignTaskRepository.Add(assignTask);
                //return PartialView("Create", position);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var assignTask = assignTaskRepository.GetAssignTask(id);
            return PartialView("Edit", assignTask);
        }

        [HttpPost]
        public IActionResult Edit(AssignTask po)
        {
            assignTaskRepository.Update(po);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            assignTaskRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
