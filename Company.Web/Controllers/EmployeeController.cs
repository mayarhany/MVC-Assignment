using Company.Data.Entities;
using Company.Services.Interfaces;
using Company.Services.Interfaces.Employee.Dto;
using Company.Services.Services;
using Company.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Company.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;

        public EmployeeController(IEmployeeService employeeService, IDepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
        }
        
        public IActionResult Index(string searchInp)
        {
            //ViewBag.Message = "Hello from employee index (ViewBag)";

            //ViewData["TextMessage"] = "Hello from employee index (ViewData)";

            //TempData["TextTempMessage"] = "Hello from employee index (TempData)";

            IEnumerable<EmployeeDto> employees = new List<EmployeeDto>();

            if (string.IsNullOrEmpty(searchInp))
            {
                employees = _employeeService.GetAll();
            }
            else
            {
                employees = _employeeService.GetEmployeeByName(searchInp);
            }
            return View(employees);

        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Departments = _departmentService.GetAll();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmployeeDto employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _employeeService.Add(employee);

                    return RedirectToAction(nameof(Index));
                }

                return View(employee);
            }
            catch (Exception ex)
            {
                return View(employee);
            }

            //public IActionResult Details(int? id, string viewName = "Details")
            //{

            //}

            //[HttpGet]
            //public IActionResult Update(int id)
            //{

            //}

            //public IActionResult Delete(int id)
            //{

            //}
        }
    }
}
