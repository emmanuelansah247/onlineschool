using System;
using System.ComponentModel.DataAnnotations;

namespace bim_edu.Models
{
    public class TeachWithUsViewModel
    {

        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        [Display(Name="Level Of Education")]
        public string LevelOfEducation { get; set; }
        [Required]
        [Display(Name="Programme")]
        public string ProgrammeName { get; set; }
        [Required]
        [Display(Name="Tell Us More About You")]
        public string AboutYourself { get; set; }
        
    }
}