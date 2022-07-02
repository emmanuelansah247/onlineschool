
using System.ComponentModel.DataAnnotations;

namespace bim_edu.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string Name {get;set;}
        public bool isremoved {get;set;}
    }
}