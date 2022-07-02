using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bim_edu.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        public string Description {get;set;}
        public string FilePath {get;set;}
        [ForeignKey("Programme")]

        public int ProgrammeId {get;set;}
        [ForeignKey("Course")]
        public int CourseId {get;set;}

        public virtual IEnumerable<QuestionStudentProvidedSolution> QuestionStudentProvidedSolutions {get;set;}

        public bool isremoved {get;set;}
    }
}