using System;
using System.ComponentModel.DataAnnotations;

namespace bim_edu.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage="Username Is Required")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage="Password Is Required")]
        public string Password {get;set;}

        [Display(Name = "Remember Me")]
        public bool RememberMe {get;set;}
        public string returnUrl {get;set;}
        
    }
}