using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace bim_edu.Models
{
    public class ProgrammeApplication
    {
        [Key]
        public int ProgrammeApplicationId { get; set; }
        public Programme Programme {get;set;}
        public DateTime DateApplied {get;set;}
        [ForeignKey("ApplicationUser")]
        public string  applicationuserId {get;set;}
        public IEnumerable<UploadedDocument>  UploadedDocuments {get;set;}
        public IEnumerable<StudentFeeToPay> StudentFeesToPay {get;set;}
        public bool isRejected {get;set;}
        public bool isApproved {get;set;}
        public bool isremoved {get;set;}
    }
}