using Microsoft.AspNetCore.Http;

namespace bim_edu.Models
{
    public class ProgramDocumentViewModel
    {
        public int ProgrammeId { get; set; }
        public string Description { get; set; }
        public IFormFile IFormFile {get;set;}
    }
}