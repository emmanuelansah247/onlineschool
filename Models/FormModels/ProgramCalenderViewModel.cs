using Microsoft.AspNetCore.Http;

namespace bim_edu.Models
{
    public class ProgramCalenderViewModel
    {
        
        public int ProgramCalenderId { get; set; }
        public int ProgramId {get;set;}
        public string Description {get;set;}
        public IFormFile IFormFile {get;set;}
    }
}