
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bim_edu.Models
{
    public class Lecturer
    {
        [Key]
        public int LecturerId { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser {get;set;}
        public string Qualifications {get;set;}
        public string MoreBiography {get;set;}

        public bool isremoved {get;set;}
    }
}