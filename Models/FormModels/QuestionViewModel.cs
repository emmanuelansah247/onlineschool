

using Microsoft.AspNetCore.Http;

namespace bim_edu.Models
{
    public class QuestionViewModel
    {
        public int QuestionId { get; set; }
        public string Description { get; set; }
        public IFormFile IFormFile {get;set;}
        public string FilePath {get;set;}
        public int ProgramId {get;set;}
        public int CourseId {get;set;}
    }
}