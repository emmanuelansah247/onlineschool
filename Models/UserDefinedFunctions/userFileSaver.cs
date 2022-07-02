

using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace bim_edu.UserDefined.Functions
{
    public static class userFileSaver
    {

        public static async Task<string> SaveFile(IFormFile IFormFile,IHostingEnvironment environment,string foldername)
        {
            try{

              string UploadedDocumentsFolder =  Path.Combine(environment.WebRootPath,foldername);
              string uniqueFileName = Guid.NewGuid().ToString() +  "_" + IFormFile.FileName;
              string filepath = Path.Combine(UploadedDocumentsFolder,uniqueFileName);
              await IFormFile.CopyToAsync(new FileStream(filepath,FileMode.Create));
              return uniqueFileName;

            }
            catch(Exception ex){
                string mes = ex.Message;
                return null;
            }
           
        }

    }
}