namespace bim_edu.Models
{
    public class PaymentViewModel
    {
        public int ProgrammeId {get;set;}
        public string UserId {get;set;}
        public ApplicationUser user {get;set;}
        public double ApplicationFee {get;set;}
        public double ProgramFee {get;set;}
        public string ProgramName {get;set;}
        public string PaymentType {get;set;}
        public string UploadedCVFileName {get;set;}
        public string Language {get;set;} = "fr";
        
    }
}
