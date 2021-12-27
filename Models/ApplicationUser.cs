using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOK.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int PESEL { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public int PostalCode { get; set; }

        public byte[] ProfilePicture { get; set; }


    }
}
