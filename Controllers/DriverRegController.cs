using IT15_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT15_Project.Controllers
{
    public class DriverRegController : Controller
    {
        public IActionResult DriverDashboard()
        {
            var driver = new ApplicationUser
            {
                FirstName = "John",
                PhoneNumber = "09123456789",
                VehicleModel = "Toyota Vios 2022",
                VehicleType = "Sedan",
                PlateNumber = "ABC-1234"
            };

            return View(driver);
        }
    }
}
