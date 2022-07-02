using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using bim_edu.DataContect.Controllers;
using bim_edu.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using Microsoft.EntityFrameworkCore;
using bim_edu.UserDefined.Functions;

namespace bim_edu.APIs.Controllers
{
    public class ApiUserController : Controller
    {

        string currentApplicationForErrorLogging = "ApiUserController";
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        BimEduDataContext _dataContext;
        ApiErrorController _apierrorcontroller;
        private IHostingEnvironment _environment;
        private IConfiguration _conf;
        private string _BaseUrl;
        public ApiUserController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager,
                                 BimEduDataContext datacontenxt,IConfiguration conf,IHostingEnvironment environment)
        {
            this._apierrorcontroller = new ApiErrorController(datacontenxt,conf,environment);
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._dataContext = datacontenxt;
            this._conf = conf;
            this._environment = environment;
            this._BaseUrl = _conf.GetValue<string>("Bim-Edu:BaseUrl");
        } 
        
        [HttpGet]
        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            IEnumerable<ApplicationUser> result =   this._userManager.Users.Where(p=>p.isremoved == false).ToList();
            return result;
        } 
        
        [HttpGet]
        public async Task<IEnumerable<ApplicationUser>> GetAllUsersAsync()
        {
            IEnumerable<ApplicationUser> result =  await this._userManager.Users.Where(p=>p.isremoved == false).ToListAsync();
            return result;
        }
        
        [HttpGet]
        public async Task<IEnumerable<ApplicationUser>> UserStaffAll()
        {
            var awaited_result =  await this._userManager.Users
                                        .Where(p=>p.isremoved == false && p.isStaff == true)
                                        .ToListAsync();
            IEnumerable<ApplicationUser> result = awaited_result.ToList();
            return result;
        }
        
        [HttpGet]
        public IEnumerable<ApplicationUser> GetAllUserWithProgramme()
        {
            IEnumerable<ApplicationUser> result =   this._userManager.Users.Include("ProgrammeApplications.Programme")
                                                    .Where( p=>p.isremoved == false).ToList();
            return result;
        }
        
        [HttpGet]
        public async Task<IEnumerable<ApplicationUser>> GetAllUserWithProgrammeApplication()
        {
            IEnumerable<ApplicationUser> result = await  this._userManager.Users
                                                    .Include("ProgrammeApplications.UploadedDocuments")
                                                    .Include("ProgrammeApplications.Programme")
                                                    .Where( p=>p.isremoved == false && 
                                                     p.ProgrammeApplications.Any(predicate=> predicate.isRejected == false && predicate.isApproved == false))
                                                    .ToListAsync();
            return result;
        }
        
        [HttpGet]
        public async Task<IEnumerable<ApplicationUser>> GetAllUserWithProgrammeApplicationApproved()
        {
            IEnumerable<ApplicationUser> result = await  this._userManager.Users
                                                    .Include("ProgrammeApplications.UploadedDocuments")
                                                    .Include("ProgrammeApplications.Programme")
                                                    .Where( p=>p.isremoved == false && 
                                                     p.ProgrammeApplications.Any(predicate=> predicate.isRejected == false && predicate.isApproved))
                                                    .ToListAsync();
            return result;
        }
        
        [HttpGet]
        public async Task<IEnumerable<ApplicationUser>> GetAllUserStudents()
        {
            IEnumerable<ApplicationUser> result = await  this._userManager.Users
                                                    .Include("ProgrammeApplications.UploadedDocuments")
                                                    .Include("ProgrammeApplications.Programme")
                                                    .Where( p=>p.isremoved == false && 
                                                     p.ProgrammeApplications.Any(predicate=> predicate.isApproved == true))
                                                    .ToListAsync();
            return result;
        }
        
        [HttpGet]
        public async Task<IEnumerable<ApplicationUser>> GetAllUserStaffs()
        {
            IEnumerable<ApplicationUser> result = await  this._userManager.Users
                                                    .Where( p=>p.isremoved == false && p.isStaff)
                                                    .ToListAsync();
            return result;
        }
        
        [HttpGet]
        public async Task<ApplicationUser> GetUserById(string Id)
        {
            ApplicationUser applicationUser =  await this._userManager.Users.Include("ProgrammeApplications.StudentFeesToPay")
                                                    .Include("ProgrammeApplications.Programme.Certification")
                                                    .Include("ProgrammeApplications.UploadedDocuments")
                                                    .Where( p=>p.Id == Id && p.isremoved == false).FirstOrDefaultAsync();
            return applicationUser;
        }
        
        [HttpGet]
        public async Task<ApplicationUser> UserGetByEmail(string email)
        {
            ApplicationUser applicationUser =  await this._userManager.Users
                                                    .Where( p=>p.Email == email && p.isremoved == false)
                                                    .FirstOrDefaultAsync();
            return applicationUser;
        }
        
        [HttpGet]
        public async Task<bool> UserRemove(string Id)
        {
            try{
                ApplicationUser applicationUser =  await this._dataContext.AspNetUsers
                                                        .Where( p=>p.Id == Id)
                                                        .FirstOrDefaultAsync();
                applicationUser.isremoved = true;
                await this._dataContext.SaveChangesAsync();
                return true;

            }catch(Exception ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return false;
            }
        }

        [HttpPost]
        public async Task<bool> UserNewLogin(ApplicationUser user)
        {
            try{
                ApplicationUserLogin newuserlogin = new ApplicationUserLogin();
                newuserlogin.ApplicationUserId = user.Id;
                newuserlogin.date = DateTime.Now;
                await this._dataContext.ApplicationUserLogins.AddAsync(newuserlogin);
                await this._dataContext.SaveChangesAsync();
                return true;

            }catch(Exception ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return false;
            }
        }

        [HttpGet]
        public async Task<IEnumerable<ApplicationUserLogin>> UserLoginsToday()
        {
                List<ApplicationUserLogin> logins = await this._dataContext.ApplicationUserLogins
                                                            .Where(predicate=>predicate.date > DateTime.Now.AddDays(-1))
                                                            .Include("ApplicationUser")
                                                            .ToListAsync();                
                return logins;
        }
        
        
        [HttpGet]
        public ProgrammeApplication GetUserActiveProgrammeApplicationById(int ProgrammeApplicationId)
        {
            ProgrammeApplication programmeApplication =  this._dataContext.ProgrammeApplications
                                                        .Include("UploadedDocuments")
                                                        .Include("Programme.Certification")
                                                        .Include("StudentFeesToPay")
                                                        .Include("Programme.CourseLecturers.Lecturer.ApplicationUser")
                                                        .Include("Programme.CourseLecturers.Course")
                                                        .Include("Programme.ProgramCalender")
                                                        .Where(p=>p.ProgrammeApplicationId == ProgrammeApplicationId)
                                                        .FirstOrDefault();
            return programmeApplication;
        }
        
        [HttpPost]
        public async Task<IdentityResult> CreateAync(RegisterViewModel model)
        {
            var user = new ApplicationUser{ 
                    UserName = model.Email, 
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email,
                    Country = model.Country,
                    PostalAddress = model.PostalAddress,
                    LevelOfEducation = model.LevelOfEducation,
                    photofilepath = model.photofilepath,
                    isStaff = model.isStaff                    
                };
            
            var result = await _userManager.CreateAsync(user,model.Password);
            if(result.Succeeded){
                await _signInManager.SignInAsync(user,isPersistent:false);
                var tmp =  await _userManager.FindByEmailAsync(model.Email);
                var Id =  tmp.Id;

                string message = "";
                string message_subject = "";
                
                if(model.Language == LanguageType.English){
                    
                 message = "<div style='padding:20px;background:#4b345d;color:white;'>" +
                    "<h1 style='color:white;font-weight:bolder;text-align:center;'><span style='color:white'> The academic council and all professors at BIM Edu Welcomes You To Our Online Learning Centre </span></h1><br/><br/>" +
                    "<div style='color:white;font-weight:bolder;text-align:center'>" +
                        "<a style='color:white;background-color:#e90172;padding:5px;text-decoration:none;' href='"+ _BaseUrl + "en_Account/ActivateEmail?Id="+ Id +"'> CLICK HERE TO ACTIVATE YOUR ACCOUNT </a><br/><br/>"+
                    "</div>" +
                    "</div>";
                 message_subject = "Welcome To Bim-Edu";

                } else{
                    message = "<div style='padding:20px;background:#4b345d;color:white;'>" +
                    "<h1 style='color:white;font-weight:bolder;text-align:center;'><span style='color:white'> Le conseil scientifique et tout le corps enseignants de BIM Edu vous souhaite la bienvenue sur notre plateforme de cours en ligne. </span></h1><br/><br/>" +
                    "<div style='color:white;font-weight:bolder;text-align:center'>" +
                        "<a style='color:white;background-color:#e90172;padding:5px;text-decoration:none;' href='"+ _BaseUrl + "Account/ActivateEmail?Id="+ Id +"'> CLIQUEZ ICI POUR ACTIVER VOTRE COMPTE </a><br/><br/>"+
                    "</div>" +
                    "</div>";
                    message_subject = "Bienvenue chez Bim-Edu";
                }
                
                await userEmailSender.EmailSender(_conf,model.Email,message_subject,message);

                //This email is being sent to the admin of the school as a notification
                string admin_subject = "NEW REGISTERED USER";
                string admin_email =  _conf.GetValue<string>("Email:enquiryemailreceiver");
                string admin_message = "<div style='padding:20px;background:#4b345d;color:white;'>" +
                    "<h1 style='color:white;font-weight:bolder;text-align:center;'><span style='color:white'> NEW USER REGISTRATION FROM " + user.FirstName + " " + user.LastName + ". The email is " + user.Email + "</span></h1><br/><br/>" +
                    "</div>";
                await userEmailSender.EmailSender(_conf,admin_email,admin_subject,admin_message);
            }
            else if(result.Errors.Count() > 0){
                foreach(var error in result.Errors){
                _apierrorcontroller.WriteError(error.Description,currentApplicationForErrorLogging);
                }
            }

            return result;
        }
        
        [HttpPost]
        public async Task<bool> UpdateUserAync(UpdateRegisterViewModel model)
        {
            try{
            ApplicationUser user = await this._dataContext.AspNetUsers.Where(predicate=> predicate.Id == model.Id).FirstOrDefaultAsync();
                    user.UserName = model.Email;
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.PhoneNumber = model.PhoneNumber;
                    user.Email = model.Email;
                    user.Country = model.Country;
                    user.PostalAddress = model.PostalAddress;
                    user.LevelOfEducation = model.LevelOfEducation;
                    user.photofilepath = model.photofilepath;
            
                    await this._dataContext.SaveChangesAsync();
                    return true;
                
            }catch(Exception ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return false;
            }
        }

        
        [HttpGet]
        public async Task<IdentityResult> EmailConfirmedAync(string Id)
        {
            var user = await _userManager.FindByIdAsync(Id);
            user.EmailConfirmed = true;
            var result =  await _userManager.UpdateAsync(user);

            if(result.Errors.Count() > 0){
                foreach(var error in result.Errors){
                _apierrorcontroller.WriteError(error.Description,currentApplicationForErrorLogging);
                }
            }
            return result;
        }
        [HttpPost]
        public async Task<ApplicationUser> PasswordResetEmail(PasswordResetEmailViewModel model)
        {

            try{
                var result = await _userManager.FindByEmailAsync(model.Email);
                if(result != null){
                    string message = "";
                    string message_subject = "";
                    if(model.Language == LanguageType.English){
                            message = "<div style='padding:20px;background:#4b345d;color:white;'>" +
                                "<h1 style='color:white;font-weight:bolder;text-align:center;'><span style='color:white'> Please Click Here To Reset Bim-Edu Password</h1><brr/><brr/>" +
                                "<div style='color:white;font-weight:bolder;text-align:center'>" +
                                    "<a style='color:white;background-color:#e90172;padding:5px;text-decoration:none;' href='"+ _BaseUrl + "en_Account/ResetPassword?Id="+ result.Id +"'>CLICK HERE TO RESET YOUR PASSWORD</a><brr/><brr/>"+
                                "</div>" +
                                "</div>";
                            message_subject = "Password Reset Link";
                    }
                    else{
                            message = "<div style='padding:20px;background:#4b345d;color:white;'>" +
                                "<h1 style='color:white;font-weight:bolder;text-align:center;'><span style='color:white'> Cliquez ici pour réinitialiser le mot de passe Bim-Edu </h1><brr/><brr/>" +
                                "<div style='color:white;font-weight:bolder;text-align:center'>" +
                                    "<a style='color:white;background-color:#e90172;padding:5px;text-decoration:none;' href='"+ _BaseUrl + "Account/ResetPassword?Id="+ result.Id +"'> CLIQUEZ ICI POUR RÉINITIALISER VOTRE MOT DE PASSE </a><brr/><brr/>"+
                                "</div>" +
                                "</div>";
                            message_subject = "Lien de réinitialisation de mot de passe";
                    }

                    await userEmailSender.EmailSender(_conf,model.Email,message_subject,message);
                    return result;
                }

            }
            catch(Exception ex){
                
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
            }

            return null;
        }

        [HttpPost]
        public async Task<IdentityResult> ResetPassword(ResetPasswordViewModel model)
        {
                var user = await _userManager.FindByIdAsync(model.Id);
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user,model.Password);
                var result = await _userManager.UpdateAsync(user);
                if(result.Succeeded){
                    string message = "";
                    string message_subject = "";
                    if(model.Language == LanguageType.English){
                            message = "<div style='padding:20px;background:#4b345d;color:white;'>" +
                                "<h1 style='color:white;font-weight:bolder;text-align:center;'><span style='color:white'>" + 
                                        "Your Bim-Edu Password Has Been Successfully Reset" +
                                "</h1><hr/>" +
                                "</div>";
                            message_subject = "Password Reset Successfully";
                    }else{
                            message = "<div style='padding:20px;background:#4b345d;color:white;'>" +
                                "<h1 style='color:white;font-weight:bolder;text-align:center;'><span style='color:white'>" + 
                                        "Votre mot de passe Bim-Edu a été réinitialisé avec succès" +
                                "</h1><hr/>" +
                                "</div>";
                            message_subject = "Mot de passe réinitialisé avec succès";
                    }

                    await userEmailSender.EmailSender(_conf,user.Email,message_subject,message);
                }
                else if(result.Errors.Count() > 0){
                    foreach(var error in result.Errors){
                    _apierrorcontroller.WriteError(error.Description,currentApplicationForErrorLogging);
                    }
                }

            return result;
        }

        [HttpPost]
        public async Task<bool> SaveApplication(PaymentViewModel model)
        {
            try{
                
                ApplicationUser user = await _userManager.FindByIdAsync(model.UserId);
                Programme programme = this._dataContext.Programmes.Where(p=> p.ProgrammeId == model.ProgrammeId).FirstOrDefault();

                ProgrammeApplication newProgrammeApplication = new ProgrammeApplication{
                        Programme = programme,
                        DateApplied = DateTime.Now,
                        applicationuserId = user.Id
                };
                
                this._dataContext.ProgrammeApplications.Add(newProgrammeApplication);
                this._dataContext.SaveChanges();
                this._dataContext.Entry(newProgrammeApplication).GetDatabaseValues();

                double total_amount_paid = programme.ApplicationFee;

                StudentFeeToPay applicationFee = new StudentFeeToPay(){
                    Amount = programme.ApplicationFee,
                    Paid = programme.ApplicationFee,
                    ProgrammeApplicationId =  newProgrammeApplication.ProgrammeApplicationId,
                    DateInitiated = DateTime.Now,
                    Type = "Application Fee"
                };

                if(model.UploadedCVFileName != null){

                    UploadedDocument programmApplicationUploadedCV = new UploadedDocument(){
                        Description = "Uploaded CV",
                        FilePath = model.UploadedCVFileName,
                        ProgrammeApplicationId = newProgrammeApplication.ProgrammeApplicationId,
                    };

                   bool programmeApplicaitonDocumentsResult = await this.AddProgrammeApplicationDocument(programmApplicationUploadedCV);

                }

                if(model.PaymentType != PaymentType.Free){
                    total_amount_paid = model.ProgramFee;
                    StudentFeeToPay schoolFees = new StudentFeeToPay(){
                        Amount = programme.Fee,
                        Paid = model.ProgramFee - programme.ApplicationFee,
                        ProgrammeApplicationId =  newProgrammeApplication.ProgrammeApplicationId,
                        DateInitiated = DateTime.Now,
                        Type = "Fees"
                    };
                this._dataContext.StudentFeesToPay.Add(schoolFees);

                }
                
                this._dataContext.StudentFeesToPay.Add(applicationFee);
                this._dataContext.SaveChanges();
                this._dataContext.Entry(applicationFee).GetDatabaseValues();
                
                Payment applicationFeePaymentHistory = new Payment(){
                    Amount = total_amount_paid,
                    PaymentDate = DateTime.Now,
                    PaymentType = model.PaymentType,
                    StudentFeeToPayId = applicationFee.StudentFeeToPayId
                };

                this._dataContext.Payments.Add(applicationFeePaymentHistory);
                this._dataContext.SaveChanges();

                string message = "";
                string message_subject = "";
                if(model.Language == LanguageType.English){
                    
                    message = "<div style='padding:20px;background:#4b345d;color:white;'>" +
                            "<br/><br/><h1 style='color:white;font-weight:bolder;text-align:center;'><span style='color:white'>" + 
                                    "Your Bim-Edu Fee (Amount is $" + total_amount_paid + " ) Payment Was Successful!" +
                            "</h1><br/><br/>" +
                            "</div>";
                    message_subject = "APPLICATION SUCCESSFULLY";

                }else{
                    
                    message = "<div style='padding:20px;background:#4b345d;color:white;'>" +
                            "<br/><br/><h1 style='color:white;font-weight:bolder;text-align:center;'><span style='color:white'>" + 
                                    "Vos frais Bim-Edu (le montant est de $" + total_amount_paid + ") Le paiement a été effectué avec succès!" +
                            "</h1><br/><br/>" +
                            "</div>";
                    message_subject = "APPLICATION AVEC SUCCÈS";

                }

                await userEmailSender.EmailSender(_conf,user.Email,message_subject,message);

                //This email is being sent to the admin of the school as a notification
                string admin_subject = "NEW APPLICATION";
                string admin_email =  _conf.GetValue<string>("Email:enquiryemailreceiver");
                string admin_message = "<div style='padding:20px;background:#4b345d;color:white;'>" +
                    "<h1 style='color:white;font-weight:bolder;text-align:center;'><span style='color:white'> APPLICATION FROM " + user.FirstName + " " + user.LastName + ". The email is " + user.Email + "</span></h1><br/><br/>" +
                    "</div>";
                await userEmailSender.EmailSender(_conf,admin_email,admin_subject,admin_message);

                return true;
            }
            catch(Exception ex){
                _apierrorcontroller.WriteError(currentApplicationForErrorLogging, ex.Message);
                return false;
            }
           

        }

        [HttpPost]
        public async Task<bool> SavePayment(StudentPaymentViewModel model)
        {
            try{

                ApplicationUser user = null;
                user = await _userManager.FindByIdAsync(model.userId);

                StudentFeeToPay entity =  await this._dataContext.StudentFeesToPay
                                        .Where(predicate=>predicate.StudentFeeToPayId == model.StudentFeeToPayId).FirstOrDefaultAsync();
                entity.Paid = entity.Paid + model.Amount;
                
                Payment applicationPaymentHistory = new Payment(){
                    Amount = model.Amount,PaymentDate = DateTime.Now,PaymentType = PaymentType.Paid,StudentFeeToPayId = entity.StudentFeeToPayId
                };

                this._dataContext.Payments.Add(applicationPaymentHistory);
                this._dataContext.SaveChanges();

                string message = "";
                string message_subject = "";

                if(model.Language == LanguageType.English){

                    message =   "<div style='padding:20px;background:#4b345d;color:white;'>" +
                                "<br/><br/><h1 style='color:white;font-weight:bolder;text-align:center;'><span style='color:white'>" + 
                                "Your Bim-Edu Payment of " + entity.Type + " (Amount is $" + model.Amount + " ) Payment Was Successful!" +
                                "</h1><br/><br/>" + "</div>";
                    message_subject = "Success! Bim-Edu Payment";

                }else{

                    message =   "<div style='padding:20px;background:#4b345d;color:white;'>" +
                                "<br/><br/><h1 style='color:white;font-weight:bolder;text-align:center;'><span style='color:white'>" + 
                                "Votre paiement Bim-Edu de "+ entity.Type +" (le montant correspond à $ "+ model.Amount +") Le paiement a été effectué avec succès!" +
                                "</h1><br/><br/>" + "</div>";
                    message_subject = "Succès! Paiement Bim-Edu";

                }

                await userEmailSender.EmailSender(_conf,user.Email,message_subject,message);

                return true;

            }
            catch(Exception ex){
                _apierrorcontroller.WriteError(currentApplicationForErrorLogging, ex.Message);
                return false;
            }
           

        }


        [HttpPost]
        public async Task<string> AddUploadedDocument(UploadedDocumentViewModel model)
        {
            try{
              string UploadedDocumentsFolder =  Path.Combine(this._environment.WebRootPath,"images",GeneralStoredNames.Uploaded_Documents);
              string uniqueFileName = Guid.NewGuid().ToString() + model.ApplicationUserId + "_" + model.IFormFile.FileName;
              string filepath = Path.Combine(UploadedDocumentsFolder,uniqueFileName);
              model.IFormFile.CopyTo(new FileStream(filepath,FileMode.Create));

                UploadedDocument newUploadedDocuments = new UploadedDocument(){
                    Description = model.Description,
                    FilePath = uniqueFileName,
                    ProgrammeApplicationId = model.ProgrammeApplicationId

                };
            
                bool result = await AddProgrammeApplicationDocument(newUploadedDocuments);

                return GeneralStoredNames.Success;
            }
            catch(Exception ex){
                _apierrorcontroller.WriteError(currentApplicationForErrorLogging, ex.Message);
                return GeneralStoredNames.Error;
            }
           

        }
        private async Task<bool> AddProgrammeApplicationDocument(UploadedDocument model){
                await this._dataContext.UploadedDocuments.AddAsync(model);
                await this._dataContext.SaveChangesAsync();
                return true;
        }
        [HttpPost]
        public async Task<string> RemoveUploadedDocument(int UploadedDocumentId)
        {
            try{
                var document_to_remove = await this._dataContext.UploadedDocuments
                                        .Where(predicate=> predicate.UploadedDocumentId == UploadedDocumentId)
                                        .FirstOrDefaultAsync();
                
                this._dataContext.UploadedDocuments.Remove(document_to_remove);
                await this._dataContext.SaveChangesAsync();

                return GeneralStoredNames.Success;
            }
            catch(Exception ex){
                _apierrorcontroller.WriteError(currentApplicationForErrorLogging, ex.Message);
                return GeneralStoredNames.Error;
            }
           

        }        

    }
}
