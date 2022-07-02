using System;
using System.ComponentModel.DataAnnotations;

namespace bim_edu.Models
{
    public class ApplicationError
    {
        [Key]
        public int Id {get;set;}
        public DateTime date {get;set;}
        public string where {get;set;}
        public string message {get;set;}
        public bool isremoved {get;set;}
    }
}