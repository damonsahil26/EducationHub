using Microsoft.AspNetCore.Identity;
using System;

namespace EduHub.Models
{
    public class ApplicationUser:IdentityUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int UserType { get; set; }
        public int ZipCode { get; set; }
        
    }
}
