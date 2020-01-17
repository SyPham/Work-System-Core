using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Work_Management_System.Controllers
{
    public class DepartmentsController : Controller
    {
        [Route("Departments", Name = "Departments")]
        public IActionResult Index()
        {
            return View();
        }
    }
}