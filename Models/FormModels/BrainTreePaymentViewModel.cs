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
    public class BrainTreePaymentViewModel
    {
        public int Id {get;set;}
        public decimal amount {get;set;}
        public string nonce {get;set;}
        public string type {get;set;}
        public string userId {get;set;}
        
    }
}
