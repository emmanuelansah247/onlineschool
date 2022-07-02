

using Microsoft.AspNetCore.Http;

namespace bim_edu.Models
{
    public class QuestionStudentProvidedSolutionViewModel
    {
        public int QuestionStudentProvidedSolutionId { get; set; }
        public int QuestionId { get; set; }
        public IFormFile IFormFile {get;set;}
        public string FilePath {get;set;}
        public string ApplicatioinUserId {get;set;}
    }
}