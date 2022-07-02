using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bim_edu.Models
{
    public class QuestionLecturerEvaluateStudentSolution
    {
        [Key]
        public int QuestionLecturerEvaluateStudentSolutionId { get; set; }
        public string FilePath {get;set;}
        [ForeignKey("QuestionStudentProvidedSolution")]

        public int QuestionStudentProvidedSolutionId {get;set;}

        public bool isremoved {get;set;}
    }
}