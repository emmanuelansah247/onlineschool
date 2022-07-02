using System;
using System.ComponentModel.DataAnnotations;

namespace bim_edu.Models
{
    public class PasswordResetEmailViewModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }  
        public string Language {get;set;} = "fr";
    }
}
