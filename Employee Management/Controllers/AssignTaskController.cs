using Employee_Management.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace Employee_Management.Controllers
{

    [AllowAnonymous]
    public class AssignTaskController : Controller
    {
        private readonly IAssignTaskRepository assignTaskRepository;        
        private readonly IEmployeeRepository employeeRepository;

        public AssignTaskController(IAssignTaskRepository _assignTaskRepository, IEmployeeRepository employeeRepository)
        {
            assignTaskRepository = _assignTaskRepository;
            this.employeeRepository = employeeRepository;
        }

        public IActionResult Index()
        {
            var pay = assignTaskRepository.GetAllAssignTask().ToList();
            var emp = employeeRepository.GetAllEmployee().ToList();
            foreach (var item in pay)
            {
                item.EmpName = emp.FirstOrDefault(x => x.ID == item.AssignTaskEmployeeId).Name;

            }
            var model = assignTaskRepository.GetAllAssignTask();

            return View(model);
        }

        public IActionResult EmpIndex()
        {
            Employee emp = new Employee();
            var idstring = HttpContext.Session.GetString("ID");
            var id = Int32.Parse(idstring);
            var model = assignTaskRepository.GetAllAssignTask().Where(emp => emp.AssignTaskEmployeeId == id);
            //ViewBag.Employee = employeeRepository.GetAllEmployee().ToString();

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
            var emps = employeeRepository.GetAllEmployee();
            ViewBag.Employee = emps.Select(x => new SelectListItem() { Text = x.Name.ToString(), Value = x.ID.ToString() });
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
