
using System.ComponentModel.DataAnnotations;

namespace bim_edu.Models
{
    public class ApplyPaymentByPassCodeViewModel
    {
        public int ProgramId { get; set; }
        public string ApplicationUserId {get;set;}
        [Required]
        public string Code {get;set;}
        public string UploadedCVFileName {get;set;}
    }
}