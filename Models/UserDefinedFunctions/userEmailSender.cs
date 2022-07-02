

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace bim_edu.UserDefined.Functions
{
    public static class userEmailSender
    {

        public static async Task<bool> EmailSender(IConfiguration _conf,string studentEmail, string subject,string message)
        {
            var url = _conf.GetValue<string>("Email:url");
            var emailservicename = _conf.GetValue<string>("Email:emailservicename");
            var owneremail = _conf.GetValue<string>("Email:owneremail");
            var password = _conf.GetValue<string>("Email:password");
            var port = _conf.GetValue<string>("Email:port");

            var values = new Dictionary<string, string>
            {
                { "email", studentEmail },
                { "subject", subject },
                { "message", message },
                { "selfemail", studentEmail },
                { "emailservicename", emailservicename },
                { "owneremail", owneremail },
                { "password", password },
                { "port", port }
            };

            try{
                var content = new FormUrlEncodedContent(values);

                HttpClient client = new HttpClient();
                
                var response = await client.PostAsync(url, content);

                var responseString = await response.Content.ReadAsStringAsync();
                return true;

            }
            catch(Exception ex){
                string error_message = ex.Message;
                return false;
            }
           
        }

    }
}