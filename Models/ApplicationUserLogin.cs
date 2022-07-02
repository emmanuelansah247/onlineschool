using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace bim_edu.Models
{
    public class ApplicationUserLogin
    {
        public int ApplicationUserLoginId {get;set;}
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId {get;set;}
        public ApplicationUser ApplicationUser {get;set;}
        public DateTime date {get;set;}

        public bool isremoved {get;set;}
        
    }
}