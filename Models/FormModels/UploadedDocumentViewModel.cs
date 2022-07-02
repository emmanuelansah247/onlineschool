using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace bim_edu.Models
{
    public class UploadedDocumentViewModel
    {
        
        public int UploadedDocumentId { get; set; }
        public string ApplicationUserId { get; set; }
        public string Description { get; set; }
        public int ProgrammeApplicationId {get;set;}
        public IFormFile IFormFile {get;set;}
    }
}