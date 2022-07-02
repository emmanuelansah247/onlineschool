
namespace bim_edu.Models.PaymentModel
{
    public class PaymentCredential
    {
        public string RunEnvironment { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string AccessTokenUrl { get; set; }
        public string ExecutePaymentUrl { get; set; }
        public string NewStudentPaymentSuccessUrl { get; set; }
        public string NewStudentPaymentCancelUrl { get; set; }
        public string OldStudentPaymentSuccessUrl { get; set; }
        public string OldStudentPaymentCancelUrl { get; set; }
        public string BaseUrl { get; set; }
        
    }
}