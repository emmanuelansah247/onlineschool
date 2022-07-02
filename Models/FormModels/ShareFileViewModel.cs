using Microsoft.AspNetCore.Http;

namespace bim_edu.Models
{
    public class ShareFileViewModel
    {
        public int CourseLecturerId { get; set; }
        public string Description { get; set; }
        public IFormFile IFormFile {get;set;}
    }
}