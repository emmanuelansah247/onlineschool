using System;
using System.ComponentModel.DataAnnotations;

namespace bim_edu.Models
{
    public class StudentPaymentViewModel
    {
        public int StudentFeeToPayId {get;set;}

        public double Amount {get;set;}
        public string userId {get;set;}
        public string Language {get;set;} = "fr";
        
    }
}
