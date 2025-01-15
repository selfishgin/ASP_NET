using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using MVCPracticeLesson1.Entities;
using MVCPracticeLesson1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace MVCPracticeLesson1.Controllers
{
    public class HomeController : Controller
    {

        public string Index()
        {
            return "Hello From Index action";
        }

        public IActionResult Index2()
        {
            return View();
        }

        public ViewResult Employee1()
        {
            List<Employee> employees = new()
            {
                new Employee
                {
                    Id=1,
                    Firstname="Vagif",
                    Lastname="Qasimov",
                    CityId=1
                },
                new Employee
                {
                    Id=2,
                    Firstname="Ahmad",
                    Lastname="Huseynli",
                    CityId=2
                },
                new Employee
                {
                    Id=3,
                    Firstname="Mirtalib",
                    Lastname="Amirli",
                    CityId=1
                }

            };

            return View(employees);
        }

        //public ViewResult Employee2()
        //{
        //	List<Employee> employees = new()
        //	{
        //		new Employee
        //		{
        //			Id=1,
        //			Firstname="Vagif",
        //			Lastname="Qasimov",
        //			CityId=1
        //		},
        //		new Employee
        //		{
        //			Id=2,
        //			Firstname="Ahmad",
        //			Lastname="Huseynli",
        //			CityId=2
        //		},
        //		new Employee
        //		{
        //			Id=3,
        //			Firstname="Mirtalib",
        //			Lastname="Amirli",
        //			CityId=1
        //		}

        //	};

        //	return View(employees);
        //}

        public ViewResult Employee2()
        {
            List<Employee> employees = new()
            {
                new Employee
                {
                    Id=1,
                    Firstname="Vagif",
                    Lastname="Qasimov",
                    CityId=1
                },
                new Employee
                {
                    Id=2,
                    Firstname="Ahmad",
                    Lastname="Huseynli",
                    CityId=2
                },
                new Employee
                {
                    Id=3,
                    Firstname="Mirtalib",
                    Lastname="Amirli",
                    CityId=1
                }

            };

            List<string> cities = new() { "Baku", "Berlin", "Toronto" };

            var vm = new EmployeeViewModel
            {
                Cities = cities,
                Employees = employees
            };

            return View(vm);
        }

        public IActionResult Index4()
        {
            return Ok();
        }

        public IActionResult Index5()
        {
            return NotFound();
        }

        public IActionResult Index6()
        {
            return BadRequest();
        }

        public IActionResult Index7()
        {
            return Redirect("/home/index"); // /home/index7 yazsaq dovr edecek, amma request limit olacaq: 302 Found
        }

        public IActionResult Index8()
        {
            return RedirectToAction("employee1");
        }

        public IActionResult Index9()
        {
            var routeValue = new RouteValueDictionary(
                new { action = "Employee1", controller = "Home" });

            return RedirectToRoute(routeValue);
        }

        public JsonResult Index10()
        {

            List<Employee> employees = new()
            {
                new Employee
                {
                    Id=1,
                    Firstname="Vagif",
                    Lastname="Qasimov",
                    CityId=1
                },
                new Employee
                {
                    Id=2,
                    Firstname="Ahmad",
                    Lastname="Huseynli",
                    CityId=2
                },
                new Employee
                {
                    Id=3,
                    Firstname="Mirtalib",
                    Lastname="Amirli",
                    CityId=1
                }

            };

            return Json(employees);

        }

        //Root param
        public JsonResult Index11(int id = -1)
        {
            List<Employee> employees = new()
            {
                new Employee
                {
                    Id=1,
                    Firstname="Vagif",
                    Lastname="Qasimov",
                    CityId=1
                },
                new Employee
                {
                    Id=2,
                    Firstname="Ahmad",
                    Lastname="Huseynli",
                    CityId=2
                },
                new Employee
                {
                    Id=3,
                    Firstname="Mirtalib",
                    Lastname="Amirli",
                    CityId=1
                }

            };
            if (id == -1)           
                return Json(employees);
            else
            {
                var data = employees.FirstOrDefault(e => e.Id == id);
                return Json(data);
            }

        }

        //Query param
        public JsonResult Index12(string key, int id = -1)
        {
            List<Employee> employees = new()
            {
                new Employee
                {
                    Id=1,
                    Firstname="Vagif",
                    Lastname="Qasimov",
                    CityId=1
                },
                new Employee
                {
                    Id=2,
                    Firstname="Ahmad",
                    Lastname="Huseynli",
                    CityId=2
                },
                new Employee
                {
                    Id=3,
                    Firstname="Mirtalib",
                    Lastname="Amirli",
                    CityId=1
                }

            };
                
            if(id == -1)
            {
                var data = employees.Where(e => e.Firstname.Contains(key));
                return Json(data);
            }
            else
            {
                var data = employees.Where(e => e.Id==id || e.Firstname.Contains(key));
                return Json(data) ;
            }
        }
    }

}
