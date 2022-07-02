
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bim_edu.Models
{
    public class ProgramCalender
    {
        [Key]
        public int ProgramCalenderId { get; set; }

        public string PathToCalender {get;set;}
        public string Description {get;set;}

        public bool isremoved {get;set;}
    }
}