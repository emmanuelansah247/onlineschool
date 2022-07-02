using System;
using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Http;

namespace bim_edu.Models
{
    public class ApplyDocumentsViewModel
    {
        public string Description { get; set; }
        public IFormFile IFormFile {get;set;}
    }
}