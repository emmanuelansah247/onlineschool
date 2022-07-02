
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace bim_edu.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Country {get;set;}
        [Display(Name = "Postal Address")]
        public string PostalAddress {get;set;}
        public string LevelOfEducation {get;set;}
        public string photofilepath {get;set;}

        [Required(ErrorMessage="Password Is Required")]
        public IEnumerable<ProgrammeApplication> ProgrammeApplications {get;set;}

        public bool isremoved {get;set;}
        public bool isStaff {get;set;}
        
    }
}