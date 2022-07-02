
using System.Collections.Generic;
using System.Linq;
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
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace breeze.Controllers
{
    public class en_OtherController : Controller
    {
        private ApiOtherController _apiOther;
        private ApiProgrammeController _apiProgram;
        private BimEduDataContext _datacontext;

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public en_OtherController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> SignInManager,
                                            BimEduDataContext datacontenxt,
                                            IConfiguration conf,IHostingEnvironment environment)
        {
            this._apiOther = new ApiOtherController(userManager,SignInManager, datacontenxt,conf,environment);
            this._apiProgram = new ApiProgrammeController(datacontenxt,conf,environment);
            this._userManager = userManager;
            this._signInManager = SignInManager;
            this._datacontext = datacontenxt;
        } 


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Comment()
        {
           await this.SetViewDataForComments();
            return View();            
        }

        [HttpGet]
        public async Task<List<Comment>> CommentAllForProgram(int ProgramId,int CourseLecturerId)
        { 
            var awaited_comments = await this._apiOther.CommentsGetAll(ProgramId,CourseLecturerId);
            List<Comment> comments = awaited_comments.ToList();      
            return comments;
        }

        [HttpGet]
        public async Task<List<Comment>> CommentsGetAllUrlRequest(int ProgramId,int CourseLecturerId)
        { 
            var awaited_comments = await this._apiOther.CommentsGetAllUrlRequest(ProgramId,CourseLecturerId);
            List<Comment> comments = awaited_comments.ToList();      
            return comments;
        }

        [HttpPost]
        public async Task<IActionResult> Comment(Comment model)
        {
            HttpContext.Session.Set<string>("ProgrammeName",_apiProgram.Find(model.Programme.ProgrammeId).Name);
            ViewData["ProgrammeName"] = HttpContext.Session.Get<string>("ProgrammeName");

            if(string.IsNullOrEmpty(model.message)){ 
                   ModelState.Clear();
            }
            else{
               var result =  await _apiOther.AddComment(model,LanguageType.English);
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
        public async Task<IActionResult> CommentUpdate(CommentUpdateViewModel model)
        {
            ViewData["ProgrammeName"] = HttpContext.Session.Get<string>("ProgrammeName");

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
            return View("Comment");            
        }

        [HttpPost]
        public async Task<IActionResult> CommentDelete(CommentUpdateViewModel model)
        {
               var result =  await _apiOther.CommentDelete(model);
               if(result){
                   ModelState.Clear();
               }else{   
                    ModelState.AddModelError("","Error During Processing");
               }
            await this.SetViewDataForComments();
            return View("Comment");            
        }

        [HttpPost]
        public async Task<IActionResult> CommentReply(CommentReplyViewModel model)
        {
               var result =  await _apiOther.CommentReply(model);
               if(result){
                   ModelState.Clear();
               }else{   
                    ModelState.AddModelError("","Error During Processing");
               }
            await this.SetViewDataForComments();
            return View("Comment");            
        }

        [HttpPost]
        public async Task<IActionResult> CommentReplyUpdate(CommentReplyUpdateViewModel model)
        {
               var result =  await _apiOther.CommentReplyUpdate(model);
               if(result){
                   ModelState.Clear();
               }else{   
                    ModelState.AddModelError("","Error During Processing");
               }
            await this.SetViewDataForComments();
            return View("Comment");            
        }

        [HttpPost]
        public async Task<IActionResult> CommentReplyDelete(int CommentReplyId)
        {
               var result =  await _apiOther.CommentReplyDelete(CommentReplyId);
               if(result){
                   ModelState.Clear();
               }else{   
                    ModelState.AddModelError("","Error During Processing");
               }
            await this.SetViewDataForComments();
            return View("Comment");            
        }

        private async Task<bool> SetViewDataForComments(){

            ProgrammeApplication program_application =  HttpContext.Session.Get<ProgrammeApplication>(GeneralStoredNames.Bim_Edu_Active_Programme_Application);
            CourseLecturer vCourseLecturer =  HttpContext.Session.Get<CourseLecturer>(GeneralStoredNames.Bim_Edu_Active_Course_Lecturer);

            Programme program = program_application.Programme;
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


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Video()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            // var user = await this._userManager.FindByIdAsync(userId);
            var user = await this._datacontext.AspNetUsers.Include("ProgrammeApplications.Programme").Where(p=>p.Id == userId).FirstOrDefaultAsync();
            ViewData["errormessage"] = "You Have Not Applied To Any Programme Yet";
                if(user.ProgrammeApplications.Count() > 0 ){
                ViewData["errormessage"] = "Your Application Has Not Been Approved";
                IEnumerable<ProgrammeApplication> programme_applications = user.ProgrammeApplications.Where(p=>p.isApproved == true && p.Programme.isremoved == false);
                
                    if(programme_applications.Count() > 0){

                    var pee = programme_applications.FirstOrDefault();
                        Programme single_programme_application = programme_applications.FirstOrDefault().Programme;
                        List<Programme> viewdata_programmes = new List<Programme>();

                        foreach(ProgrammeApplication currentprogramme in programme_applications){
                                viewdata_programmes.Add(currentprogramme.Programme);
                        }

                        HttpContext.Session.Set<List<Programme>>("list_of_programmes",viewdata_programmes);  
                        ViewData["programmes"] = viewdata_programmes;
                        ViewData["videos"] = this._apiOther.GetAllVideosOfAProgramme(single_programme_application.ProgrammeId).ToList();
                        ViewData["errormessage"] = null;
                    }

                }



            return View();            
        }

        [HttpPost]
        public ActionResult Video(int ProgrammeId)
        {
            
            List<Programme> viewdata_programmes = HttpContext.Session.Get<List<Programme>>("list_of_programmes");  
            ViewData["programmes"] = viewdata_programmes;
            ViewData["videos"] = this._apiOther.GetAllVideosOfAProgramme(ProgrammeId).ToList();
            
            return View();            
        }

        [HttpGet]
        public async Task<IActionResult> ShareFile()
        {
            await this.SetViewDataForShareFiles();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ShareFile(ShareFileViewModel model)
        {
            if(model.IFormFile != null){
                bool result = await this._apiProgram.ShareFileAdd(model);
                if(result){
                    ModelState.AddModelError("","Error During Processing");
                }
            }

            await this.SetViewDataForShareFiles();
            return View();
            
        }

        private async Task<bool> SetViewDataForShareFiles(){     

            CourseLecturer activeCourseLecturer =  HttpContext.Session.Get<CourseLecturer>(GeneralStoredNames.Bim_Edu_Active_Course_Lecturer);
            var awaited_ShareFiles = await this._apiProgram.ShareFileGetById(activeCourseLecturer.CourseLecturerId);
            List<ShareFile> ShareFiles = awaited_ShareFiles.ToList();
            ViewData["vShareFiles"] =ShareFiles;
            ViewData["vCourseLecturer"] = activeCourseLecturer;
            return true;
           
        }



    }

}