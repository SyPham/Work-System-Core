﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Work_Management_System.Controllers
{
    public class TeamsController : Controller
    {
        [Route("Teams", Name = "Teams")]
        public IActionResult Index()
        {
            return View();
        }
    }
}