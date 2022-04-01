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
        private readonly IAssignTaskRepository assignTaskRepository;
        private readonly ILeaveRepository leaveRepository;
        private readonly IHourRepository hourRepository;

        public DashboardController(IEmployeeRepository employeeRepository,
                                IPositionRepository positionRepository, IScheduleRepository scheduleRepository,
                                IDepartmentRepository departmentRepository,
                                UserManager<ApplicationUser> userManager,
                                IAssignTaskRepository assignTaskRepository,
                                 ILeaveRepository leaveRepository,
                                  IHourRepository hourRepository)
        {
            this.employeeRepository = employeeRepository;
            this.positionRepository = positionRepository;
            this.scheduleRepository = scheduleRepository;
            this.departmentRepository = departmentRepository;
            this.userManager = userManager;
            this.assignTaskRepository = assignTaskRepository;  
            this.leaveRepository = leaveRepository;
            this.hourRepository = hourRepository;
        }

        public IActionResult Index()
        {
            var ID =  HttpContext.Session.GetString("ID");
            var Name =  HttpContext.Session.GetString("Name");

            var id = Convert.ToInt32(ID);

            var assignTaskEmp = assignTaskRepository.GetAllAssignTask().Where(emp => emp.AssignTaskEmployeeId == id);
            var empAssignTask = assignTaskEmp.Count();

            var leaveEmp = leaveRepository.GetAllLeave().Where(emp => emp.LeaveEmployeeId == id);
            var empLeave = leaveEmp.Count();

            var hourEmp = hourRepository.GetAllHour().Where(emp => emp.HourEmployeeId == id);
            var empHour = hourEmp.Count();

            dashboardClass model = new dashboardClass
            {
                DepartmentList = departmentRepository.GetAllDepartment(),
                EmployeeList = employeeRepository.GetAllEmployee(),
                PositionList = positionRepository.GetAllPosition(),
                ScheduleList = scheduleRepository.GetAllSchedule(),
                EmpAssignTaskList = empAssignTask,
                EmpLeaveList = empLeave,
                EmpHourList = empHour
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