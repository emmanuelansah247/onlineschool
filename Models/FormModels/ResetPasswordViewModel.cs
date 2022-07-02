using System;
using System.ComponentModel.DataAnnotations;

namespace bim_edu.Models
{
    public class ResetPasswordViewModel
    {
        [Required]
        public string Id {get;set;}
        [Required]

        public string Password {get;set;}
        [Compare("Password",ErrorMessage= "Password and Confirmation do not match")]
        [Required]
        public string ConfirmPassword {get;set;}
        public string Language {get;set;} = "fr";
        
    }
}
