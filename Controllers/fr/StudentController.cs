using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bim_edu.Models;
using bim_edu.APIs.Controllers;
using Microsoft.AspNetCore.Hosting;
using bim_edu.DataContect.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using bim_edu.Session;
using Microsoft.AspNetCore.Authorization;

namespace bim_edu.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        private ApiUserController _apiUser;
        private ApiProgrammeController _apiProgram;
        private ApiQuestionController _apiQuestion;
        private ApiLecturerController _apiLecturer;
        private readonly IHostingEnvironment _environment;

        public StudentController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager, 
                                BimEduDataContext dataContext,IConfiguration conf,IHostingEnvironment environment)
        {
            _apiProgram = new ApiProgrammeController(dataContext,conf,environment);
            _apiLecturer = new ApiLecturerController(dataContext,conf,environment);
            _apiQuestion = new ApiQuestionController(dataContext,conf,environment);
            _apiUser = new ApiUserController(userManager,signInManager,dataContext,conf,environment);
            this._environment = environment;
        } 
        [HttpGet]
        public async Task<IActionResult> Welcome()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await this._apiUser.GetUserById(userId);
            if(user.ProgrammeApplications.Count() < 1){
                return RedirectToAction("Apply","Account");
            }


            HttpContext.Session.Set<ApplicationUser>(GeneralStoredNames.Bim_Edu_Application_User,user);
            ProgrammeApplication activeProgrammeApplication =  HttpContext.Session.Get<ProgrammeApplication>(GeneralStoredNames.Bim_Edu_Active_Programme_Application);
            CourseLecturer activeCourseLecturer =  HttpContext.Session.Get<CourseLecturer>(GeneralStoredNames.Bim_Edu_Active_Course_Lecturer);

            if(activeProgrammeApplication == null){
                var tmp =  user.ProgrammeApplications.FirstOrDefault();
                activeProgrammeApplication =  this._apiUser.GetUserActiveProgrammeApplicationById(tmp.ProgrammeApplicationId);
                HttpContext.Session.Set<ProgrammeApplication>(GeneralStoredNames.Bim_Edu_Active_Programme_Application,activeProgrammeApplication);
            }

            if(activeCourseLecturer == null && activeProgrammeApplication.Programme.CourseLecturers.Count() > 0){
                activeCourseLecturer =  activeProgrammeApplication.Programme.CourseLecturers.FirstOrDefault();
                HttpContext.Session.Set<CourseLecturer>(GeneralStoredNames.Bim_Edu_Active_Course_Lecturer,activeCourseLecturer);
            }

            ViewData[GeneralStoredNames.Bim_Edu_Application_User] = user;
            ViewData[GeneralStoredNames.Bim_Edu_Active_Programme_Application] = activeProgrammeApplication;
            ViewData[GeneralStoredNames.Bim_Edu_Active_Course_Lecturer] = activeCourseLecturer;
            
            return View();
        }

        [HttpPost]
        public IActionResult Welcome(int ProgrammeApplicationId,int CourseLecturerId){

            ApplicationUser user = HttpContext.Session.Get<ApplicationUser>(GeneralStoredNames.Bim_Edu_Application_User);
            ProgrammeApplication activeProgrammeApplication = this._apiUser.GetUserActiveProgrammeApplicationById(ProgrammeApplicationId);
            CourseLecturer activeCourseLecturer = this._apiProgram.CourseLectureGetById(CourseLecturerId);

            HttpContext.Session.Set<ProgrammeApplication>(GeneralStoredNames.Bim_Edu_Active_Programme_Application,activeProgrammeApplication);
            HttpContext.Session.Set<CourseLecturer>(GeneralStoredNames.Bim_Edu_Active_Course_Lecturer,activeCourseLecturer);

            ViewData[GeneralStoredNames.Bim_Edu_Application_User] = user;
            ViewData[GeneralStoredNames.Bim_Edu_Active_Programme_Application] = activeProgrammeApplication;
            ViewData[GeneralStoredNames.Bim_Edu_Active_Course_Lecturer] = activeCourseLecturer;
            
            return View();
        }
        public IActionResult Application()
        {
            this.SetUserAndActiveProgramme();
            return View();
        }
        public IActionResult Payment()
        {
            this.SetUserAndActiveProgramme();
            return View();
        }
        public IActionResult Policy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Foundation()
        {
            this.SetUserAndActiveProgramme();
            
            return View();
        }

        [HttpGet]
        public IActionResult Program()
        {
            this.SetUserAndActiveProgramme();
            return View();
        }

        [HttpGet]
        public IActionResult Profile()
        {
            this.SetUserAndActiveProgramme();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProfileUpdate(UpdateRegisterViewModel model)
        {
            if(ModelState.IsValid){ 
                if(model.IFormFile != null){
                 model.photofilepath = await this._apiProgram.SaveFile(model.IFormFile,GeneralStoredNames.Profile_Picture_Path);
                }
                bool result =  await _apiUser.UpdateUserAync(model);
                if(result == false){
                        ModelState.AddModelError("","Something Went Wrong");
                }
            }
            var user = await this._apiUser.GetUserById(model.Id);
            HttpContext.Session.Set<ApplicationUser>(GeneralStoredNames.Bim_Edu_Application_User,user);
            this.SetUserAndActiveProgramme();
            return View("Profile");
        }

        [HttpGet]
        public IActionResult Lecturer()
        {
            this.SetUserAndActiveProgramme();
            return View();
        }
        [HttpGet]
        public IActionResult ProgramDocument()
        {   
            ProgrammeApplication programmeApplication = HttpContext.Session.Get<ProgrammeApplication>(GeneralStoredNames.Bim_Edu_Active_Programme_Application);
            List<ProgramDocument> result = this._apiProgram.GetAllFileForAProgram(programmeApplication.Programme.ProgrammeId).ToList();
            ViewData["programdocuments"] = result;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Question()
        {
            await this.SetViewDataForQuestion();
            
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> QuestionStudentProvidedSolutionAdd(QuestionStudentProvidedSolutionViewModel model)
        {
            if(model.IFormFile != null){
                bool result = await this._apiQuestion.QuestionStudentProvidedSolutionAdd(model);
                if(!result){
                    ModelState.AddModelError("","Error During Processing");
                }
            }
            await this.SetViewDataForQuestion();
            return View("Question");
            
        }

        [HttpPost]
        public async Task<IActionResult> QuestionStudentProvidedSolutionDelete(int QuestionStudentProvidedSolutionId)
        {
           await this.SetViewDataForQuestion();
                bool result = await this._apiQuestion.QuestionStudentProvidedSolutionDelete(QuestionStudentProvidedSolutionId);
                if(!result){
                    ModelState.AddModelError("","Error During Processing");
                }
            
            return View("Question");
            
        }

        private async Task<bool> SetViewDataForQuestion(){

            ProgrammeApplication activeProgrammeApplication = HttpContext.Session.Get<ProgrammeApplication>(GeneralStoredNames.Bim_Edu_Active_Programme_Application);
            Programme activeProgram = await this._apiProgram.PorgrammeGetById(activeProgrammeApplication.Programme.ProgrammeId);

            ViewData["v_Program"] = activeProgram;

            return true;

        }


        [HttpPost]
        public async Task<IActionResult> UploadStudentDocument(UploadedDocumentViewModel model){
            if(model.IFormFile != null){
                string result = await this._apiUser.AddUploadedDocument(model);
                if(result == GeneralStoredNames.Success){
                    ProgrammeApplication activeProgrammeApplication =  this._apiUser.GetUserActiveProgrammeApplicationById(model.ProgrammeApplicationId);
                    HttpContext.Session.Set<ProgrammeApplication>(GeneralStoredNames.Bim_Edu_Active_Programme_Application,activeProgrammeApplication);
                    ModelState.Clear();
                }else{
                    ModelState.AddModelError("","Error During Processing");
                }
            }
            this.SetUserAndActiveProgramme();
            return View("Foundation");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveUploadedDocument(int UploadedDocumentId){

            ProgrammeApplication activeProgrammeApplication =  HttpContext.Session.Get<ProgrammeApplication>(GeneralStoredNames.Bim_Edu_Active_Programme_Application);
            
            string result = await this._apiUser.RemoveUploadedDocument(UploadedDocumentId);
            if(result == GeneralStoredNames.Success){
                activeProgrammeApplication =  this._apiUser.GetUserActiveProgrammeApplicationById(activeProgrammeApplication.ProgrammeApplicationId);
                HttpContext.Session.Set<ProgrammeApplication>(GeneralStoredNames.Bim_Edu_Active_Programme_Application,activeProgrammeApplication);
                ModelState.Clear();
            }else{
                ModelState.AddModelError("","Error During Processing");
            }
            this.SetUserAndActiveProgramme();
            return View("Foundation");

        }
        public void SetUserAndActiveProgramme(){
            ApplicationUser user = HttpContext.Session.Get<ApplicationUser>(GeneralStoredNames.Bim_Edu_Application_User);
            ProgrammeApplication activeProgrammeApplication =  HttpContext.Session.Get<ProgrammeApplication>(GeneralStoredNames.Bim_Edu_Active_Programme_Application);

            ViewData[GeneralStoredNames.Bim_Edu_Application_User] = user;
            ViewData[GeneralStoredNames.Bim_Edu_Active_Programme_Application] = activeProgrammeApplication;
        }

    }
}
