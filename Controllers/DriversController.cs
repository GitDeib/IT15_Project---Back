using IT15_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;

namespace IT15_Project.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DriversController: Controller
    {
  
       
            private readonly ILogger<DriversController> _logger;

            public DriversController(ILogger<DriversController> logger)
            {
                _logger = logger;
            }

            public IActionResult Drivers()
            {
                return View("~/Views/User/Admin/Drivers.cshtml");
            }

        }

    }
