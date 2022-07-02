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
    public class Administration_FourController : Controller
    {
        private ApiCertificationController _apiCertificationController;
        private ApiProgrammeController _apiProgram;
        private ApiOtherController _apiOther;
        private ApiUserController _apiUser;
        private ApiLecturerController _apiLecturer;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ApiPaymentController _apiPayment;

        public Administration_FourController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, 
                                            RoleManager<IdentityRole> roleManager,
                                            BimEduDataContext dataContext,IConfiguration conf,IHostingEnvironment environment)
        {
            _apiCertificationController = new ApiCertificationController(dataContext,conf,environment);
            _apiProgram = new ApiProgrammeController(dataContext,conf,environment);
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
        public async Task<IActionResult> AdminChangeProgram()
        {
            ApplicationUser activeUser = HttpContext.Session.Get<ApplicationUser>(GeneralStoredNames.Bim_Edu_Change_Program_Active_User);
            if(activeUser == null){
                var result = await _apiUser.GetAllUserWithProgrammeApplicationApproved();
                activeUser = result.FirstOrDefault();
                HttpContext.Session.Set<ApplicationUser>(GeneralStoredNames.Bim_Edu_Change_Program_Active_User,activeUser);
            }
            await this.SetViewDataForChangeProgram();
            return View();            
        }

        [HttpPost]
        public async Task<IActionResult> AdminViewStudentPrograms(string ApplicationUserId)
        {
            ApplicationUser user = await this._apiUser.GetUserById(ApplicationUserId);
            HttpContext.Session.Set<ApplicationUser>(GeneralStoredNames.Bim_Edu_Change_Program_Active_User,user);
            await this.SetViewDataForChangeProgram();
            return View("AdminChangeProgram");
        }

        [HttpPost]
        public async Task<IActionResult> AdminUpdateStudentProgram(int ProgramApplicationId,int ProgramId)
        {
            bool user = await this._apiProgram.ProgrammeApplicationUpdateWithNewProgram(ProgramApplicationId,ProgramId);
            await this.SetViewDataForChangeProgram();
            return View("AdminChangeProgram");            
        }

        [HttpPost]
        public async Task<IActionResult> AdminRemoveStudentProgram(int ProgramApplicationId)
        {
            bool user = await this._apiProgram.ProgrammeApplicationRemove(ProgramApplicationId);
            await this.SetViewDataForChangeProgram();
            return View("AdminChangeProgram");            
        }

        private async Task<bool> SetViewDataForChangeProgram(){     

            var awaited_course = await _apiUser.GetAllUserWithProgrammeApplicationApproved();
            ApplicationUser activeUser = HttpContext.Session.Get<ApplicationUser>(GeneralStoredNames.Bim_Edu_Change_Program_Active_User);
            activeUser = await this._apiUser.GetUserById(activeUser.Id);
            List<ApplicationUser> vUsers = awaited_course.ToList();
            List<Programme> vPrograms = this._apiProgram.GetAllPorgrammes().ToList();

            ViewData["vUsers"] = vUsers;
            ViewData["vPrograms"] = vPrograms;
            ViewData["vActiveUser"] = activeUser;

            return true;

        }

        [HttpGet]
        public async Task<IActionResult> AdminShareFile()
        {
            await this.SetViewDataForShareFiles();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdminShareFile(ShareFileViewModel model)
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

        [HttpPost]
        public async Task<IActionResult> AdminShareFileDelete(int Id)
        {

            bool result = await this._apiProgram.ShareFileDeleteById(Id);
            if(result != true){
                ModelState.AddModelError("","Error During Processing");
            }

            await this.SetViewDataForShareFiles();
            return View("AdminShareFile");
            
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