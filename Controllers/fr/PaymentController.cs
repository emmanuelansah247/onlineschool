using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bim_edu.Models;
using bim_edu.Session;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using bim_edu.APIs.Controllers;
using bim_edu.DataContect.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using bim_edu.Models.PaymentModel;

namespace breeze.Controllers
{
    public class PaymentController : Controller
    {

        ApiPaymentController _apiPayment;

        public ApiProgrammeController _apiProgram;
        public ApiUserController _apiUser;
        private readonly UserManager<ApplicationUser> _userManager;

        public PaymentController(BimEduDataContext datacontext,IConfiguration conf,IHostingEnvironment environment,
        UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager)
        {
            _apiPayment = new ApiPaymentController(datacontext,conf,environment);
            _apiUser = new ApiUserController(userManager,signInManager,datacontext,conf,environment);
            this._apiProgram = new ApiProgrammeController(datacontext,conf,environment);
            this._userManager = userManager;
        }

        [HttpGet]
        public PaymentCredential GetPaymentCredentials()
        {
            PaymentCredential details = this._apiPayment.PaymentCredential();
            return  details;
        } 

        [HttpGet]
        public async Task<ActionResult> ProcessApplicationPayment(PaymentViewModel model)
        {
            
            ViewData["vApplicationUser"] = await this._apiUser.GetUserById(model.UserId);
            ViewData["vPaymentViewModel"] = model;
            return View();
        }

        [HttpGet]
        public ActionResult NewStudentPaymentSuccessUrl()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewStudentPaymentCancelUrl()
        {
            return View();
        }

        [HttpPost]
        public async Task<bool> NewStudentPaymentSuccessUrl(PaymentViewModel model)
        {
            model.Language = LanguageType.French;
            return await _apiUser.SaveApplication(model);
        }

        [HttpGet]
        public IActionResult OldStudentPaymentSuccessUrl()
        {
            return View();
        }

        [HttpPost]
        public async Task<bool> OldStudentPaymentSuccessUrl(StudentPaymentViewModel model)
        {
            model.Language = LanguageType.French;
            bool result = await _apiUser.SavePayment(model);
            HttpContext.Session.Set<ProgrammeApplication>(GeneralStoredNames.Bim_Edu_Active_Programme_Application,null);
            return result;

        }

        [HttpGet]
        public IActionResult OldStudentPaymentCancelUrl()
        {
            return View();
        }

    }

}