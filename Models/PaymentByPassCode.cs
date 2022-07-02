
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace bim_edu.Models
{
    public class PaymentByPassCode
    {
        [Key]
        public int PaymentByPassCodeId { get; set; }
        public string Code {get;set;}
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId {get;set;}
        public ApplicationUser ApplicationUser {get;set;}
        public DateTime date {get;set;}
        public bool isremoved {get;set;}
    }
}