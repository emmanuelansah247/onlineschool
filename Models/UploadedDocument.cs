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
    public class UploadedDocument
    {
        [Key]
        public int UploadedDocumentId { get; set; }
        public string Description {get;set;}
        public string FilePath {get;set;}
        [ForeignKey("ProgrammeApplication")]
        public int ProgrammeApplicationId {get;set;}

        public bool isremoved {get;set;}
    }
}