using Employee_Management.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Employee_Management.Controllers
{
    [AllowAnonymous]
    public class HourController : Controller
    {
        private readonly IHourRepository hourRepository;        
        private readonly IEmployeeRepository employeeRepository;

        public HourController(IHourRepository _hourRepository, IEmployeeRepository employeeRepository)
        {
            hourRepository = _hourRepository;
            this.employeeRepository = employeeRepository;
        }

        public IActionResult Index()
        {
            var hour = hourRepository.GetAllHour().ToList();
            var emp = employeeRepository.GetAllEmployee().ToList();
            foreach (var item in hour)
            {
                item.EmpName = emp.FirstOrDefault(x => x.ID == item.HourEmployeeId).Name;    
          
            }
           
            var model = hourRepository.GetAllHour();
            
            return View(model);
        }

        public IActionResult EmpIndex()
        {
            Employee emp = new Employee();
            var idstring = HttpContext.Session.GetString("ID");
            var id = Int32.Parse(idstring);
            var model = hourRepository.GetAllHour().Where(emp => emp.HourEmployeeId == id);
           
            return View(model);
        }


        [HttpGet]
        public IActionResult Create()
        {
            var emps = new List<Employee>();
            if (HttpContext.Session.GetString("Role") == "Emp")
            {
                emps = employeeRepository.GetAllEmployee().Where(x => x.ID == Convert.ToInt32(HttpContext.Session.GetString("ID"))).ToList();
            }
            else
            {
                emps = employeeRepository.GetAllEmployee().ToList();
            }
            ViewBag.Employee = emps.Select(x => new SelectListItem() { Text = x.Name.ToString(), Value = x.ID.ToString() });

            Hour po = new Hour();
            po.DataofJob = DateTime.Today;
            return PartialView("Create", po);
            //return View();
        }

        [HttpPost]
        public IActionResult Create(Hour hour)
        {
            if (ModelState.IsValid)
            {
                hourRepository.Add(hour);
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
            var pay = hourRepository.GetHour(id);
            return PartialView("Edit", pay);
        }

        [HttpPost]
        public IActionResult Edit(Hour po)
        {
            hourRepository.Update(po);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            hourRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
