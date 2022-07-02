using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bim_edu.Models
{
    public class CourseLecturer
    {
        [Key]
        public int CourseLecturerId { get; set; }

        [ForeignKey("Programme")]
        public int ProgrammeId { get; set; }
        [ForeignKey("Lecturer")]
        public int LecturerId { get; set; }
        public Lecturer Lecturer {get;set;}
        public int CourseId { get; set; }
        public Course Course {get;set;}

        public bool isremoved {get;set;}
    }
}