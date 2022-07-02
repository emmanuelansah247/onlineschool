using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using bim_edu.DataContect.Controllers;
using bim_edu.Models;

namespace bim_edu.APIs.Controllers
{
    public class ApiErrorController : Controller
    {

        BimEduDataContext _applicationDataContext;
        private IHostingEnvironment _hostingEnvironment;
        private IConfiguration _conf;
        public ApiErrorController(BimEduDataContext datacontenxt,IConfiguration conf,IHostingEnvironment environment)
        {
            this._applicationDataContext = datacontenxt;
            this._conf = conf;
            this._hostingEnvironment = environment;
        } 
        
        [HttpGet]
        public void WriteError(string message,string where)
        {
            ApplicationError applicationerror = new ApplicationError();
            applicationerror.date = DateTime.Now;
            applicationerror.where = where;
            applicationerror.message = message;

            _applicationDataContext.applicationerrors.Add(applicationerror);
        }


    }
}
