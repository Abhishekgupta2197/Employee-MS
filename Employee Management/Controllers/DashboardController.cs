using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Employee_Management.Models;
using Employee_Management.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Http;

namespace Employee_Management.Controllers
{
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IPositionRepository positionRepository;
        private readonly IScheduleRepository scheduleRepository;
        private readonly IDepartmentRepository departmentRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public DashboardController(IEmployeeRepository employeeRepository,
                                IPositionRepository positionRepository, IScheduleRepository scheduleRepository,
                                IDepartmentRepository departmentRepository,
                                UserManager<ApplicationUser> userManager)
        {
            this.employeeRepository = employeeRepository;
            this.positionRepository = positionRepository;
            this.scheduleRepository = scheduleRepository;
            this.departmentRepository = departmentRepository;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var ID =  HttpContext.Session.GetString("ID");
            var Name =  HttpContext.Session.GetString("Name");

            dashboardClass model = new dashboardClass
            {
                DepartmentList = departmentRepository.GetAllDepartment(),
                EmployeeList = employeeRepository.GetAllEmployee(),
                PositionList = positionRepository.GetAllPosition(),
                ScheduleList = scheduleRepository.GetAllSchedule()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();
            //HttpContext.Session.Abandon();
            return RedirectToAction("Login", "Account");
        }
    }
}