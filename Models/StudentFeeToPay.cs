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
    public class StudentFeeToPay
    {
        [Key]
        public int StudentFeeToPayId { get; set; }
        public double Amount {get;set;}
        public double Paid {get;set;}
        [ForeignKey("ProgrammeApplication")]
        public int ProgrammeApplicationId {get;set;}
        public DateTime DateInitiated {get;set;}
        public string Type {get;set;}
        public IEnumerable<Payment> PaymentHistory {get;set;}
        public bool isremoved {get;set;}
    }
}