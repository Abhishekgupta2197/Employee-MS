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
    public class LeaveController : Controller
    {
        private readonly ILeaveRepository leaveRepository;        
        private readonly IEmployeeRepository employeeRepository;

        public LeaveController(ILeaveRepository _leaveRepository, IEmployeeRepository employeeRepository)
        {
            leaveRepository = _leaveRepository;
            this.employeeRepository = employeeRepository;
        }

        public IActionResult Index()
        {
            var pay = leaveRepository.GetAllLeave().ToList();
            var emp = employeeRepository.GetAllEmployee().ToList();
            foreach (var item in pay)
            {
                item.EmpName = emp.FirstOrDefault(x => x.ID == item.LeaveEmployeeId).Name;

            }
            var model = leaveRepository.GetAllLeave();

            return View(model);
        }

        public IActionResult EmpIndex()
        {
            Employee emp = new Employee();
            var idstring= HttpContext.Session.GetString("ID");
            var id = Int32.Parse(idstring);
            var model = leaveRepository.GetAllLeave().Where(emp => emp.LeaveEmployeeId == id);
            //ViewBag.Employee = employeeRepository.GetAllEmployee().ToString();

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

            Leave po = new Leave();
            return PartialView("Create", po);
            //return View();
        }

        [HttpPost]
        public IActionResult Create(Leave leave)
        {
            var idstring = HttpContext.Session.GetString("ID");
            var id = Int32.Parse(idstring);
            if (id > 0)
            {
                if (ModelState.IsValid)
                {
                    leaveRepository.Add(leave);
                    //return PartialView("Create", position);
                    return RedirectToAction("EmpIndex");
                }
                return View();

            }
            else { 
            if (ModelState.IsValid)
            {
                leaveRepository.Add(leave);
                //return PartialView("Create", position);
                return RedirectToAction("Index");
            }
            return View();
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var emps = employeeRepository.GetAllEmployee();
            ViewBag.Employee = emps.Select(x => new SelectListItem() { Text = x.Name.ToString(), Value = x.ID.ToString() });
            var leave = leaveRepository.GetLeave(id);
            return PartialView("Edit", leave);
        }

        [HttpPost]
        public IActionResult Edit(Leave po)
        {
            leaveRepository.Update(po);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            leaveRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
