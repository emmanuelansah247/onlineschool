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
using Microsoft.AspNetCore.Authorization;
using bim_edu.Session;

namespace breeze.Controllers
{
    public class Administration_ThreeController : Controller
    {
        private ApiCertificationController _apiCertificationController;
        private ApiProgrammeController _apiProgrammeController;
        private ApiOtherController _apiOther;
        private ApiUserController _apiUser;
        private ApiLecturerController _apiLecturer;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ApiPaymentController _apiPayment;

        public Administration_ThreeController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, 
                                            RoleManager<IdentityRole> roleManager,
                                            BimEduDataContext dataContext,IConfiguration conf,IHostingEnvironment environment)
        {
            _apiCertificationController = new ApiCertificationController(dataContext,conf,environment);
            _apiProgrammeController = new ApiProgrammeController(dataContext,conf,environment);
            _apiOther = new ApiOtherController(userManager,signInManager,dataContext,conf,environment);
            _apiUser = new ApiUserController(userManager,signInManager,dataContext,conf,environment);
            _apiLecturer = new ApiLecturerController(dataContext,conf,environment);
            _apiPayment = new ApiPaymentController(dataContext,conf,environment); 
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult AdminStaffRegister()
        {
            return View();            
        }
        [AllowAnonymous]

        [HttpPost]
        public async Task<IActionResult> AdminStaffRegister(RegisterViewModel model)
        {

            model.Language = LanguageType.English;
            model.isStaff = true;
            if(ModelState.IsValid){ 
                if(model.IFormFile != null){
                 model.photofilepath = await this._apiProgrammeController.SaveFile(model.IFormFile,GeneralStoredNames.Profile_Picture_Path);
                }
                var result =  await _apiUser.CreateAync(model);
                if(result.Succeeded){
                   return  RedirectToAction("ActivateEmail","Account");
                }
                foreach(var error in result.Errors){
                        ModelState.AddModelError("",error.Description);
                }
            }

         return View(model);
            
        }


        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> AdminCourse()
        {
           await this.SetViewDataForCourse();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdminCourse(Course model)
        {
            if(model.Name != string.Empty){
                bool result = await this._apiLecturer.CourseAdd(model);
                if(!result){
                    ModelState.AddModelError("","Course Already Exist");
                }
            }

           await this.SetViewDataForCourse();
            return View("AdminCourse");
            
        }

        [HttpPost]
        public async Task<IActionResult> AdminCourseRemove(int CourseId)
        {
                bool result = await this._apiLecturer.CourseRemove(CourseId);
                if(!result){
                    ModelState.AddModelError("","Error During Processing");
                }
            await this.SetViewDataForCourse();            
            return View("AdminCourse");
            
        }

        private async Task<bool> SetViewDataForCourse(){     
            var awaited_course = await _apiLecturer.CourseAll();
            List<Course> course = awaited_course.ToList();
            ViewData["vCourse"] =course;
            return true;
        }


        [Authorize(Roles = "Admin,Staff")]
        [HttpGet]
        public async Task<IActionResult> AdminComment()
        {
           await this.SetViewDataForComments();
            return View();            
        }

        [HttpGet]
        public async Task<List<Comment>> CommentAllForProgram(int ProgramId)
        { 
            var awaited_comments = await this._apiOther.CommentsGetAll(ProgramId,-1);
            List<Comment> comments = awaited_comments.ToList();      
            return comments;
        }

        [HttpPost]
        public async Task<IActionResult> AdminComment(Comment model)
        {
            if(string.IsNullOrEmpty(model.message)){ 
                   ModelState.Clear();
            }
            else{
               var result =  await _apiOther.AddComment(model);
               if(result){
                   ModelState.Clear();
               }else{   
                    ModelState.AddModelError("","Error During Processing");
               }

            }
            await this.SetViewDataForComments();
            return View(model);            
        }

        [HttpPost]
        public async Task<IActionResult> AdminCommentUpdate(CommentUpdateViewModel model)
        {
            if(string.IsNullOrEmpty(model.updated_message)){ 
                   ModelState.Clear();
            }
            else{
               var result =  await _apiOther.CommentUpdate(model);
               if(result){
                   ModelState.Clear();
               }else{   
                    ModelState.AddModelError("","Error During Processing");
               }

            }
            await this.SetViewDataForComments();
            return View("AdminComment");            
        }

        [HttpPost]
        public async Task<IActionResult> AdminCommentDelete(CommentUpdateViewModel model)
        {
               var result =  await _apiOther.CommentDelete(model);
               if(result){
                   ModelState.Clear();
               }else{   
                    ModelState.AddModelError("","Error During Processing");
               }
            await this.SetViewDataForComments();
            return View("AdminComment");            
        }

        [HttpPost]
        public async Task<IActionResult> AdminCommentReply(CommentReplyViewModel model)
        {
               var result =  await _apiOther.CommentReply(model);
               if(result){
                   ModelState.Clear();
               }else{   
                    ModelState.AddModelError("","Error During Processing");
               }
            await this.SetViewDataForComments();
            return View("AdminComment");            
        }

        [HttpPost]
        public async Task<IActionResult> AdminCommentReplyUpdate(CommentReplyUpdateViewModel model)
        {
               var result =  await _apiOther.CommentReplyUpdate(model);
               if(result){
                   ModelState.Clear();
               }else{   
                    ModelState.AddModelError("","Error During Processing");
               }
            await this.SetViewDataForComments();
            return View("AdminComment");            
        }

        [HttpPost]
        public async Task<IActionResult> AdminCommentReplyDelete(int CommentReplyId)
        {
               var result =  await _apiOther.CommentReplyDelete(CommentReplyId);
               if(result){
                   ModelState.Clear();
               }else{   
                    ModelState.AddModelError("","Error During Processing");
               }
            await this.SetViewDataForComments();
            return View("AdminComment");            
        }

        private async Task<bool> SetViewDataForComments(){

            Programme program =  HttpContext.Session.Get<Programme>(GeneralStoredNames.Bim_Edu_Active_Program);
            CourseLecturer vCourseLecturer =  HttpContext.Session.Get<CourseLecturer>(GeneralStoredNames.Bim_Edu_Active_Course_Lecturer);
            ViewData["program"] = program;
            ViewData["vCourseLecturer"] = vCourseLecturer;
            int course_lecturer_id = -1;
            if(vCourseLecturer != null){
                course_lecturer_id = vCourseLecturer.CourseLecturerId;
            }

            var awaited_comments = await this._apiOther.CommentsGetAll(program.ProgrammeId,course_lecturer_id);
            List<Comment> comments = awaited_comments.ToList();
            ViewData["comments"] = comments;

            return true;
        }
        

        [HttpGet]
        public async Task<IActionResult> AdminUnregister()
        { 
            await this.SetViewDataForUnregister();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdminUnregsiterStudent(string StudentId)
        {
               bool success =  await _apiUser.UserRemove(StudentId);
               if(success){
                    ModelState.Clear();
               }
               else{
                   ModelState.AddModelError("","Error During Processing");
               }
            await this.SetViewDataForUnregister();
            return View("AdminUnregister");            
        }


        [HttpPost]
        public async Task<IActionResult> AdminUnregsiterStaff(string StaffId)
        {
               bool success =  await _apiUser.UserRemove(StaffId);
               if(success){
                    ModelState.Clear();
               }
               else{
                   ModelState.AddModelError("","Error During Processing");
               }
            await this.SetViewDataForUnregister();
            return View("AdminUnregister");            
        }

        private async Task<bool> SetViewDataForUnregister(){

            var awaited_result = await this._apiUser.GetAllUsersAsync();
            List<ApplicationUser> vUser =  awaited_result.ToList();
            ViewData["vUser"] = vUser;

            return true;
        }

        [HttpGet]
        public async Task<IActionResult> AdminLogin()
        { 
            var awaited_users = await this._apiUser.UserLoginsToday();
            ViewData["vApplicationUserLogin"] = awaited_users.ToList();
            return View();
        }




    }

}