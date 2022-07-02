using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace bim_edu.Models
{
    public class Certification
    {
        [Key]
        public int CertificationId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name {get;set;}

        public bool isremoved {get;set;}
    }
}