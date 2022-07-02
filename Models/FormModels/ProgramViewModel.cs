
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace bim_edu.Models
{
    public class ProgramViewModel
    {
        public int ProgramId { get; set; }
        [Required]
        public string Name {get;set;}
        [Required]
        public string Description {get;set;}
        public string Url {get;set;}
        [Required]
        [DataType(DataType.Currency)]
        public double ApplicationFee {get;set;}
        [Required]
        [DataType(DataType.Currency)]
        public double Fee {get;set;}
        public int CertificationId {get;set;}
        public string Language {get;set;}
    }
}