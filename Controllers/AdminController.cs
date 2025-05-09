﻿using IT15_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IT15_Project.Controllers
{
    [Authorize(Roles = "Admin" )]
    public class AdminController: Controller {
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("~/Views/User/Admin/Admin.cshtml");
        }

    }
}