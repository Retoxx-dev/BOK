using System;
using System.ComponentModel.DataAnnotations;

namespace BOK.Models
{
    public class NewUser
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords don't match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string District { get; set; }

        [Required]
        public int PostalCode { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public Int64 PESEL { get; set; }
    }
}
