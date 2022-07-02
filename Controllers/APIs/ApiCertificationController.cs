using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using bim_edu.DataContect.Controllers;
using bim_edu.Models;

namespace bim_edu.APIs.Controllers
{
    public class ApiCertificationController : Controller
    {

        string currentApplicationForErrorLogging = "ApiCertificationController";
        BimEduDataContext _applicationDataContext;
        ApiErrorController _apierrorcontroller;
        private IHostingEnvironment _hostingEnvironment;
        private IConfiguration _conf;
        public ApiCertificationController(BimEduDataContext datacontenxt,IConfiguration conf,IHostingEnvironment environment)
        {
            this._apierrorcontroller = new ApiErrorController(datacontenxt,conf,environment);
            this._applicationDataContext = datacontenxt;
            this._conf = conf;
            this._hostingEnvironment = environment;
        } 
        
        [HttpGet]
        public IEnumerable<Certification> GetAllCertifications()
        {
            IEnumerable<Certification> result =   this._applicationDataContext.Certifications.Where(p=>p.isremoved == false).ToList();
            return result;
        }
        
        [HttpGet]
        public IEnumerable<Certification> GetAllCertificationsWithDeleted()
        {
            IEnumerable<Certification> result =   this._applicationDataContext.Certifications.ToList();
            return result;
        }

        [HttpPost]
        public string Add(Certification entity)
        {
          try{
            var entity_already_exist = this._applicationDataContext.Certifications.Where(p=>p.Name == entity.Name).FirstOrDefault();
            if(entity_already_exist != null){
              return GeneralStoredNames.Error;
            }else{
              this._applicationDataContext.Add(entity);
              this._applicationDataContext.SaveChanges();
              return GeneralStoredNames.Success;
            }
          }
          catch(Exception  ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return GeneralStoredNames.Error;
          }
        }


    }
}
