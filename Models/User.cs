using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace BOK.Models
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "First name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Phone number")]
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email address")]
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Display(Name = "Date created")]
        [HiddenInput]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy H:mm:ss}")]
        public DateTime DateCreated { get; set; }
    }
}