using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace bim_edu.Models
{
    public class RegisterViewModel
    {
        [Key]
        public int Id {get;set;}
        [Display(Name = "First Name")]
        public string FirstName {get;set;}
        [Display(Name = "Last Name")]
        public string LastName {get;set;}
        [Display(Name = "Phone Number")]
        public string PhoneNumber {get;set;}
        public string Country {get;set;}
        [Display(Name = "Postal Address")]
        public string PostalAddress {get;set;}
        public string LevelOfEducation {get;set;}
        public IFormFile IFormFile {get;set;}
        public string photofilepath {get;set;}

        [Required(ErrorMessage="Username Is Required")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage="Password Is Required")]
        public string Password {get;set;}
        [Compare("Password",ErrorMessage= "Password and Confirmation do not match")]
        public string ConfirmPassword {get;set;}

        public string Language {get;set;} = "fr";
        public bool isremoved {get;set;}
        public bool isStaff {get;set;}
        
    }
}
