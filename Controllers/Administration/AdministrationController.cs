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
using Microsoft.AspNetCore.Identity;
using bim_edu.Session;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace breeze.Controllers
{
    
    public class AdministrationController : Controller
    {
        private ApiCertificationController _apiCertification;
        private ApiProgrammeController _apiProgram;
        private ApiOtherController _apiOther;
        private ApiQuestionController _apiQuestion;
        private ApiUserController _apiUser;
        private ApiLecturerController _apiLecturer;
        private List<ApplicationUser> _applicationusers;
        
        public AdministrationController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, 
                                            BimEduDataContext dataContext,IConfiguration conf,IHostingEnvironment environment)
        {
            _apiCertification = new ApiCertificationController(dataContext,conf,environment);
            _apiProgram = new ApiProgrammeController(dataContext,conf,environment);
            _apiQuestion = new ApiQuestionController(dataContext,conf,environment);
            _apiOther = new ApiOtherController(userManager,signInManager,dataContext,conf,environment);
            _apiUser = new ApiUserController(userManager,signInManager,dataContext,conf,environment);
            _apiLecturer = new ApiLecturerController(dataContext,conf,environment);
        } 

         [Authorize(Roles = "Admin,Staff")]
        [HttpGet]
        public async Task<IActionResult> Admin()
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ApplicationUser active_user = await this._apiUser.GetUserById(userId);
            HttpContext.Session.Set<ApplicationUser>(GeneralStoredNames.Bim_Edu_Active_Admin_User,active_user);

            List<Programme> allPrograms =  this.GetAllPrograms();
            Programme activeProgram = HttpContext.Session.Get<Programme>(GeneralStoredNames.Bim_Edu_Active_Program);
            CourseLecturer activeCourseLecturer =  HttpContext.Session.Get<CourseLecturer>(GeneralStoredNames.Bim_Edu_Active_Course_Lecturer);

            if(User.IsInRole(RoleName.Staff)){
                if(activeCourseLecturer != null){
                    if(activeCourseLecturer.Lecturer.ApplicationUser.Id != userId){
                        activeProgram = null;
                        activeCourseLecturer = null;
                        this.GetAllPrograms();
                    }
                }
            }

            if(activeProgram == null){
                activeProgram =  allPrograms.FirstOrDefault();
                activeCourseLecturer = null;
                HttpContext.Session.Set<Programme>(GeneralStoredNames.Bim_Edu_Active_Program,activeProgram);
                ViewData[GeneralStoredNames.Bim_Edu_Active_Program] = activeProgram;
            }

            if(activeProgram != null){
                if(activeCourseLecturer == null && activeProgram.CourseLecturers.Count() > 0){
                    List<CourseLecturer> all_active_courseLecturer = activeProgram.CourseLecturers.Where(predicate=> predicate.isremoved == false).ToList();
                    if(User.IsInRole(RoleName.Staff)){
                        all_active_courseLecturer = activeProgram.CourseLecturers.Where(predicate=> predicate.isremoved == false 
                                                                                        && predicate.Lecturer.ApplicationUser.Id == userId)
                                                                                        .ToList();
                    }
                    activeCourseLecturer =  all_active_courseLecturer.FirstOrDefault();
                    HttpContext.Session.Set<CourseLecturer>(GeneralStoredNames.Bim_Edu_Active_Course_Lecturer,activeCourseLecturer);
                    ViewData[GeneralStoredNames.Bim_Edu_Active_Course_Lecturer] = activeCourseLecturer;
                }
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Admin(int ProgramId,int CourseLecturerId){

            Programme activeProgram = await this._apiProgram.PorgrammeGetById(ProgramId);
            CourseLecturer activeCourseLecturer = this._apiProgram.CourseLectureGetById(CourseLecturerId);

            if(CourseLecturerId < 1){
                if(activeProgram != null){
                    activeCourseLecturer = activeProgram.CourseLecturers.Where(predicate=> predicate.isremoved == false).FirstOrDefault();
                }
            }

            HttpContext.Session.Set<Programme>(GeneralStoredNames.Bim_Edu_Active_Program,activeProgram);
            HttpContext.Session.Set<CourseLecturer>(GeneralStoredNames.Bim_Edu_Active_Course_Lecturer,activeCourseLecturer);

            GetAllPrograms();
            
            return View();
        }

        private List<Programme> GetAllPrograms(){

            List<Programme> allPrograms = null;
            Programme vActiveProgram = HttpContext.Session.Get<Programme>(GeneralStoredNames.Bim_Edu_Active_Program);
            if(User.IsInRole(RoleName.Admin)){
                allPrograms = _apiProgram.GetAllPorgrammes().ToList();
            }else if(User.IsInRole(RoleName.Staff)){
                string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;

                allPrograms = _apiProgram.ProgrammeStaff(id).ToList();

                if(vActiveProgram == null){
                    vActiveProgram =  allPrograms.FirstOrDefault();
                }
                    if(vActiveProgram != null){
                    List<CourseLecturer> all_courses_for_user = vActiveProgram.CourseLecturers.
                                                                    Where(predicate => predicate.isremoved == false 
                                                                                        && predicate.Lecturer.ApplicationUser.Id == id).ToList();
                    vActiveProgram.CourseLecturers = all_courses_for_user;
                    }
            }

            ViewData["v_allPrograms"] = allPrograms;
            ViewData[GeneralStoredNames.Bim_Edu_Active_Program] = vActiveProgram;
            ViewData[GeneralStoredNames.Bim_Edu_Active_Course_Lecturer] = HttpContext.Session.Get<CourseLecturer>(GeneralStoredNames.Bim_Edu_Active_Course_Lecturer);

            return allPrograms;

        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult AdminCertification()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCertification(Certification entity)
        {
            if(ModelState.IsValid){
               this._apiCertification.Add(entity);
            }
        return View("AdminCertification",entity);
            
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult AdminProgramme()
        {
             this.SetViewDataForProgramme();
            return View();
        }

        [HttpPost]
        public IActionResult ProgrammeAdd(ProgramViewModel model)
        {
            if(ModelState.IsValid){
               string result = this._apiProgram.ProgramAdd(model);
                if(result == GeneralStoredNames.Error){
                    ModelState.AddModelError("","Program Couldn't Be Added");
                }
            }

            this.SetViewDataForProgramme();            
            return View("AdminProgramme",model);
            
        }

        [HttpPost]
        public IActionResult ProgrammeUpdate(ProgramViewModel model)
        {
            if(ModelState.IsValid){
               bool result = this._apiProgram.ProgramUpdate(model);
                if(result == false){
                    ModelState.AddModelError("","Update Failed");
                }
            }

            this.SetViewDataForProgramme();              
            return View("AdminProgramme",model);
        }

        private bool SetViewDataForProgramme(){     
            ViewData["Certifications"] =_apiCertification.GetAllCertifications().ToList();
            ViewData["Programs"] =_apiProgram.GetAllPorgrammes().ToList();
            return true;
        }

        [Authorize(Roles = "Admin,Staff")]
        [HttpGet]
        public async Task<IActionResult> AdminVideo()
        {
            await GetVideoProgrammeLanguageSession();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdminVideo(VideoViewModel model)
        {

            if(string.IsNullOrEmpty(model.Url)){
                return View();
            }

            Video entity = model;
            entity.Url = GetDesiredVideoUrl(model.Url);

            if(entity.Url == string.Empty){
                ModelState.AddModelError("","Invalid Video Url");
                return View();
            }

            var result = await  this._apiOther.AddVideo(entity);
            if(result == GeneralStoredNames.Success){
                ModelState.Clear();
            }

            await GetVideoProgrammeLanguageSession();
            return View();
            
        }


        [HttpPost]
        public async Task<IActionResult> UpdateVideo(Video model)
        {
            model.Url = GetDesiredVideoUrl(model.Url);

            if(model.Url == string.Empty){
                ModelState.AddModelError("","Invalid Video Url");
            }else{
                var result = await  this._apiOther.UpdateVideo(model);
                if(result == GeneralStoredNames.Success){
                    ModelState.Clear();
                }
            }

            await GetVideoProgrammeLanguageSession();
            return View("AdminVideo");
            
        }

        [HttpPost]
        public async Task<IActionResult> DeleteVideo(Video model)
        {
            var result = await  this._apiOther.DeleteVideo(model.VideoId);
            if(result == GeneralStoredNames.Success){
                ModelState.Clear();
            }
            await GetVideoProgrammeLanguageSession();
             return View("AdminVideo");
            
        }

        private async Task<bool> GetVideoProgrammeLanguageSession(){
            Programme activeProgram = HttpContext.Session.Get<Programme>(GeneralStoredNames.Bim_Edu_Active_Program);
            activeProgram = await this._apiProgram.PorgrammeGetById(activeProgram.ProgrammeId);
            ViewData["v_Program"] = activeProgram;

            List<Video> videos = this._apiOther.GetAllVideosOfAProgramme(activeProgram.ProgrammeId).ToList();

            ViewData["v_Videos"] = videos;
            return true;
        }

        private string GetDesiredVideoUrl(string Url){

            string current_split_string = "?v=";
            string desired_url = Url;

                if(Url.Contains(current_split_string)){
                    desired_url = Url.Split(current_split_string)[1];
                    desired_url = "https://www.youtube.com/embed/" + desired_url;
                }
            return desired_url;
        }

        [Authorize(Roles = "Admin,Staff")]
        [HttpGet]
        public async Task<IActionResult> AdminProgramDocument()
        {
            await this.SetViewDataForProgramDocuments();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdminProgramDocument(ProgramDocumentViewModel model)
        {
            if(model.IFormFile != null){
                HttpContext.Session.Set<string>("programmdocumentId",model.ProgrammeId.ToString());
                string result = await this._apiProgram.AddFileToAProgram(model);
                if(result == GeneralStoredNames.Success){
                    ModelState.AddModelError("","Error During Processing");
                }
            }

            await this.SetViewDataForProgramDocuments();
            return View();
            
        }

        [HttpPost]
        public async Task<IActionResult> AdminProgramDeleteDocument(int Id)
        {

            string result = await this._apiProgram.DeleteFileForAProgram(Id);
            if(result != GeneralStoredNames.Success){
                ModelState.AddModelError("","Error During Processing");
            }

            await this.SetViewDataForProgramDocuments();
            return View("AdminProgramDocument");
            
        }

        private async Task<bool> SetViewDataForProgramDocuments(){     

            Programme activeProgram = HttpContext.Session.Get<Programme>(GeneralStoredNames.Bim_Edu_Active_Program);
            activeProgram = await this._apiProgram.PorgrammeGetById(activeProgram.ProgrammeId);
            List<Programme> _programs = new List<Programme>();
            _programs.Add(activeProgram);
           ViewData["Programs"] =_programs;
           ViewData["programdocuments"] = this._apiProgram.GetAllFileForAProgram(Convert.ToInt32(activeProgram.ProgrammeId));
           return true;
           
        }
        
        [Authorize(Roles = "Admin,Staff")]
        [HttpGet]
        public async Task<IActionResult> AdminQuestion()
        {
            await this.SetViewDataForQuestion();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdminQuestion(QuestionViewModel model)
        {
            if(model.IFormFile != null){

                Course activeCourse = new Course();
                activeCourse.CourseId = model.CourseId;
                HttpContext.Session.Set<Course>("v_activeCourse",activeCourse);

                bool result = await this._apiQuestion.QuestionAdd(model);
                if(!result){
                    ModelState.AddModelError("","Error During Processing");
                }
            }
            
            await this.SetViewDataForQuestion();
            return View();
            
        }

        [HttpPost]
        public async Task<IActionResult> AdminQuestionView(QuestionViewModel model)
        {
                Course activeCourse = new Course();
                activeCourse.CourseId = model.CourseId;
                HttpContext.Session.Set<Course>("v_activeCourse",activeCourse);
            
                await this.SetViewDataForQuestion();
                return View("AdminQuestion");
            
        }

        [HttpPost]
        public async Task<IActionResult> AdminQuestionDelete(int Id)
        {
           await this.SetViewDataForQuestion();
                bool result = await this._apiQuestion.QuestionDelete(Id);
                if(!result){
                    ModelState.AddModelError("","Error During Processing");
                }
            
            return View("AdminQuestion");
            
        }

        [HttpPost]
        public async Task<IActionResult> AdminQuestionLecturerEvaluateStudentSolution(QuestionLecturerEvaluateStudentSolutionViewModel model)
        {
            if(model.IFormFile != null){
                bool result = await this._apiQuestion.QuestionLecturerEvaluateStudentSolutionAdd(model);
                if(!result){
                    ModelState.AddModelError("","Error During Processing");
                }
            }
            await this.SetViewDataForQuestion();
            return View("AdminQuestion");
            
        }

        [HttpPost]
        public async Task<IActionResult> AdminQuestionLecturerEvaluateStudentSolutionDelete(int QuestionLecturerEvaluateStudentSolutionId)
        {
           await this.SetViewDataForQuestion();
                bool result = await this._apiQuestion.QuestionLecturerEvaluateStudentSolutionDelete(QuestionLecturerEvaluateStudentSolutionId);
                if(!result){
                    ModelState.AddModelError("","Error During Processing");
                }
            
            return View("AdminQuestion");
            
        }

        private async Task<bool> SetViewDataForQuestion(){

            Programme activeProgram = HttpContext.Session.Get<Programme>(GeneralStoredNames.Bim_Edu_Active_Program);
            activeProgram = await this._apiProgram.PorgrammeGetById(activeProgram.ProgrammeId);

            var awaited_courses = await this._apiLecturer.CourseAll();
            List<Course> courses = awaited_courses.ToList();
            Course activeCourse = HttpContext.Session.Get<Course>("v_activeCourse");
            if(activeCourse == null){
                if(awaited_courses.Count() > 0){
                    activeCourse = awaited_courses.FirstOrDefault();
                }else{
                    activeCourse = new Course();
                    activeCourse.CourseId = 1;
                }
            }

            ViewData["v_Program"] = activeProgram;
            ViewData["v_Courses"] = courses;
            ViewData["v_activeCourse"] = activeCourse;
            return true;

        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> AdminLecturer()
        {
            await this.SetViewDataForLecturers();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdminLecturer(Lecturer entity){
            if(ModelState.IsValid){
                await this._apiLecturer.AddANewLecturer(entity);
            }
            await this.SetViewDataForLecturers();
            return View("AdminLecturer");
        }

        private async Task<bool> SetViewDataForLecturers(){

            var awaited_user_staffs = await _apiUser.UserStaffAll();
            ViewData["vUserStaffs"] = awaited_user_staffs.ToList();
            return true;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> AdminApproval()
        {
            await this.setViewDataForApproval();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ApprovalAccept(int PorgramApplicationId,string ApplicationUserId){
            await this._apiProgram.ApplicationApproval(PorgramApplicationId,ApplicationUserId);
            await this.setViewDataForApproval();
            return View("AdminApproval");
        }

        [HttpPost]
        public async Task<IActionResult> ApprovalReject(int PorgramApplicationId,string ApplicationUserId){
            await this._apiProgram.ApplicationRejection(PorgramApplicationId,ApplicationUserId);
            await this.setViewDataForApproval();
            return View("AdminApproval");
        }

        private async Task<bool>  setViewDataForApproval(){

         var result = await  _apiUser.GetAllUserWithProgrammeApplication();
         _applicationusers = result.ToList();
         ViewData["applicationusers"] = _applicationusers;
           return true;

        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> AdminStudent()
        {
            var result = await  _apiUser.GetAllUserStudents();
            List<ApplicationUser> vStudents = result.ToList();
            ViewData["vStudents"] = vStudents;
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> AdminStaff()
        {
            var result = await  _apiUser.GetAllUserStaffs();
            List<ApplicationUser> vStaffs = result.ToList();
            ViewData["vStaffs"] = vStaffs;
            return View();
        }
    }

}