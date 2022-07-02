

using Microsoft.AspNetCore.Http;

namespace bim_edu.Models
{
    public class QuestionLecturerEvaluateStudentSolutionViewModel
    {
        public int QuestionLecturerEvaluateStudentSolutionId { get; set; }
        public int QuestionStudentProvidedSolutionId { get; set; }
        public IFormFile IFormFile {get;set;}
        public string FilePath {get;set;}
    }
}