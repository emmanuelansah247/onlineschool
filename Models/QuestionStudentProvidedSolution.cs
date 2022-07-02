using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bim_edu.Models
{
    public class QuestionStudentProvidedSolution
    {
        [Key]
        public int QuestionStudentProvidedSolutionId { get; set; }
        public string FilePath {get;set;}
        [ForeignKey("Question")]

        public int QuestionId {get;set;}

        [ForeignKey("ApplicationUser")]

        public string ApplicationUserId {get;set;}

        public virtual ApplicationUser ApplicationUser {get;set;}

        public virtual IEnumerable<QuestionLecturerEvaluateStudentSolution> QuestionLecturerEvaluateStudentSolutions {get;set;}

        public bool isremoved {get;set;}
    }
}