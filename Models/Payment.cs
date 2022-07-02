using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bim_edu.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public double Amount {get;set;}
        public DateTime PaymentDate {get;set;}
        public string PaymentType {get;set;}
        [ForeignKey("StudentFeeToPay")]
        public int StudentFeeToPayId {get;set;}
        public bool isremoved {get;set;}
    }
}