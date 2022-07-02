using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bim_edu.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using bim_edu.APIs.Controllers;
using bim_edu.DataContect.Controllers;
using System.Net.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.IO;

namespace breeze.Controllers
{
    public class AccountController : Controller
    {
        private ApiProgrammeController _apiProgrammeController;
        private ApiCertificationController _apiCertificationController;
        private ApiPaymentController _apiPayment;
        private ApiUserController _apiUserController;
        private List<Certification> _certifications;
        private List<Programme> _programmes;

        private static readonly HttpClient _client = new HttpClient();
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public BimEduDataContext _datacontenxt { get; }

        public AccountController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> SignInManager,
                                BimEduDataContext datacontenxt,IConfiguration conf,IHostingEnvironment environment)
        {
            _apiCertificationController = new ApiCertificationController(datacontenxt,conf,environment);
            _apiProgrammeController = new ApiProgrammeController(datacontenxt,conf,environment);
            _apiUserController = new ApiUserController(userManager,SignInManager,datacontenxt,conf,environment);
            this._apiPayment = new ApiPaymentController(datacontenxt,conf,environment);
            this._userManager = userManager;
            this._signInManager = SignInManager;
            this._datacontenxt = datacontenxt;
        } 
        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            if(returnUrl != null){
                if(returnUrl.StartsWith("/en_")){
                    return RedirectToAction("Login","en_Account",new{returnUrl});
                }
            }
            ViewData["returnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
         var returnUrl = model.returnUrl;   
            if(ModelState.IsValid){

                var result = await _signInManager.PasswordSignInAsync(model.Email,model.Password,model.RememberMe,false);

                        

                if(result.Succeeded){
                    ApplicationUser user = await this._apiUserController.UserGetByEmail(model.Email);
                    await this._apiUserController.UserNewLogin(user);
                    if(user != null){
                        if(!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl) ){
                            return Redirect(returnUrl);
                        }else{
                            if(await _userManager.IsInRoleAsync(user,RoleName.Admin) || await _userManager.IsInRoleAsync(user,RoleName.Staff)){
                                    return RedirectToAction("Admin","Administration");
                            }
                            return RedirectToAction("Welcome","Student");

                        }
                    }else{
                        ModelState.AddModelError(string.Empty,"Account Removed");
                    }

                }else{
                    ModelState.AddModelError(string.Empty,"Invalid Username Or Password");
                }

            }else{
                ViewData["message"] = "Please Correct The Errors";
            }
            return View(model);
            
        }

        public async Task<IActionResult> Logout()
        {
           await _signInManager.SignOutAsync();
           return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public IActionResult AccessDenied(string returnUrl)
        {
            if(returnUrl != null){
                if(returnUrl.StartsWith("/en_")){
                    return RedirectToAction("AccessDenied","en_Account",new{returnUrl});
                }
            }
            ViewData["returnUrl"] = returnUrl;
            return View();
        }

        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> Search(string q)
        {
            int title_length= 50;
            int desciption_length = 200;
            List<SearchViewModel> result = new List<SearchViewModel>();
            var awaited_result = await this._apiProgrammeController.PorgrammesSearch(q);
            List<Programme> search_result = awaited_result.ToList();
            foreach(Programme item in search_result){
               int firstindex = item.Description.IndexOf(q);
               if(firstindex > 0){
                        string text = item.Description.Substring(firstindex);
                        if(text.Length > title_length){
                            text = text.Substring(0,title_length - 1);
                        }
                        
                        SearchViewModel search_item = new SearchViewModel();
                        search_item.Title = "..." + text + "...";
                        
                        search_item.Desscription = item.Description;

                        if(search_item.Desscription.Length > desciption_length){
                            search_item.Desscription = search_item.Desscription.Substring(0,desciption_length - 1);
                        }

                        search_item.Action = item.Url;

                        string asp_controller= "Programmes";
                        if(item.Language == LanguageType.English){
                                asp_controller= "en_" + asp_controller;
                        }
                        search_item.Controller = asp_controller;
                        result.Add(search_item);

                    }
            }

            ViewData["Vresult"] = result;    
            return View();            
        }

        

        [HttpGet]
        public IActionResult Register()
        {
            if(this._signInManager.IsSignedIn(User)){
                return RedirectToAction("Apply","Account");
            }
            return View();            
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {

            model.Language = LanguageType.French;
            if(ModelState.IsValid){ 
                if(model.IFormFile != null){
                 model.photofilepath = await this._apiProgrammeController.SaveFile(model.IFormFile,GeneralStoredNames.Profile_Picture_Path);
                }
                var result =  await _apiUserController.CreateAync(model);
                if(result.Succeeded){
                   return  RedirectToAction("Apply","Account");
                }
                foreach(var error in result.Errors){
                        ModelState.AddModelError("",error.Description);
                }
            }

         return View(model);
            
        }
        
        [HttpGet]
        public IActionResult Apply()
        {
            this.SetProgramsAndCertifications();
            return View();            
        }

        [HttpPost]
        public async Task<string> ApplyDocuments(ApplyDocumentsViewModel model)
        {
            try{
                string file_name = await this._apiProgrammeController.SaveFile(model.IFormFile,Path.Combine("images",GeneralStoredNames.Uploaded_Documents));
                return file_name;    
            }
            catch(Exception ex){
                string result = ex.Message;
                return "false";
            }        
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> ApplyPaymentByPassCode(ApplyPaymentByPassCodeViewModel model)
        {
           bool hasPassCodePassed =  await this._apiPayment.PaymentByPassCodeCheckAndRemove(model.Code,model.ApplicationUserId);
           Programme program = await this._apiProgrammeController.PorgrammeGetById(model.ProgramId);

           if(hasPassCodePassed){
               PaymentViewModel newpaymentviewmodel = new PaymentViewModel(){
                   ApplicationFee = program.ApplicationFee,
                   ProgrammeId = model.ProgramId,
                   UserId = model.ApplicationUserId,
                   UploadedCVFileName = model.UploadedCVFileName,
                   PaymentType = PaymentType.Waived
               };

               

                var result =  await this._apiUserController.SaveApplication(newpaymentviewmodel);

                if(result){
                    return RedirectToAction("Feedback","Home",
                            new{heading="DEMANDE EN COURS", 
                            description="Vous recevrez un courriel une fois le traitement terminé"});
                }
                else{
                    return RedirectToAction("Feedback","Home",
                                    new{heading="APPLICATION NON RÉUSSIE", 
                                    description="Votre demande n'a pas pu être traitée"});
                }

           }
            else{
                return RedirectToAction("Feedback","Home",
                                    new{heading="APPLICATION NON RÉUSSIE", 
                                    description="Votre demande n'a pas pu être traitée"});
            }        
        }

        private bool SetProgramsAndCertifications(){
            _certifications = _apiCertificationController.GetAllCertifications().ToList();
            _programmes = _apiProgrammeController.GetAllPorgrammes().ToList();
            TempData["certifications"] = _certifications;
            TempData["programmes"] = _programmes;

            return true;
        }

        [HttpGet]
        public async Task<IActionResult> ActivateEmail(string Id = "")
        {
            if(Id.Length > 0){
               var result = await _apiUserController.EmailConfirmedAync(Id);
               if(result.Errors.Count() > 0){
                   Id= "";
               }
            }
            ViewData["Id"] = Id;
            return View();            
        }

        [HttpGet]
        public IActionResult PasswordResetEmail()
        {
            ViewData["Email"] = "";
            return View();            
        }
        [HttpPost]
        public async Task<IActionResult> PasswordResetEmail(PasswordResetEmailViewModel model)
        {
            model.Language = LanguageType.French;
            if(ModelState.IsValid){
               var result = await _apiUserController.PasswordResetEmail(model);
               if(result == null){
                    ViewData["Email"] = "";
                    ModelState.AddModelError("","Email n'existe pas");
               }else{
                    ViewData["Email"] = model.Email;
               }
            }
            return View(model);            
        }

        [HttpGet]
        public IActionResult ResetPassword(string Id = null )
        {
            ViewData["Id"] = Id;
            return View();            
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            model.Language = LanguageType.French;
            if(ModelState.IsValid){
               var result = await _apiUserController.ResetPassword(model);
               if(result.Succeeded){
                    ViewData["Id "] = null;
               }else{   
                    foreach(var error in result.Errors){
                        ModelState.AddModelError("",error.Description);
                    }
               }
            }
            return View(model);            
        }


    }

}