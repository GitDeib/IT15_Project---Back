using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace IT15_Project.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty; 
        public string VehicleType { get; set; } = string.Empty;
        public string VehicleModel { get; set; } = string.Empty;
        public string PlateNumber { get; set; } = string.Empty;

        public string DriverLicense { get; set; } = string.Empty;
        public string VehicleRegistration { get; set; } = string.Empty;

        public string WhyDriveWithUs { get; set; } = string.Empty;

    }
}
