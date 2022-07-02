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
    public class Administration_TwoController : Controller
    {
        private ApiCertificationController _apiCertificationController;
        private ApiProgrammeController _apiProgrammeController;
        private ApiOtherController _apiOtherController;
        private ApiUserController _apiUserController;
        private ApiLecturerController _apiLecturer;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ApiPaymentController _apiPayment;

        public Administration_TwoController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, 
                                            RoleManager<IdentityRole> roleManager,
                                            BimEduDataContext dataContext,IConfiguration conf,IHostingEnvironment environment)
        {
            _apiCertificationController = new ApiCertificationController(dataContext,conf,environment);
            _apiProgrammeController = new ApiProgrammeController(dataContext,conf,environment);
            _apiOtherController = new ApiOtherController(userManager,signInManager,dataContext,conf,environment);
            _apiUserController = new ApiUserController(userManager,signInManager,dataContext,conf,environment);
            _apiLecturer = new ApiLecturerController(dataContext,conf,environment);
            _apiPayment = new ApiPaymentController(dataContext,conf,environment); 
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        } 


        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> AdminCoureseLecture()
        {
            await GetActiveCourseLecturersSession();
            return View();
        }
        
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AdminRole()
        {

            ApplicationUser awaited_user =  await _apiUserController.GetUserById(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            List<IdentityRole> roles =  roleManager.Roles.ToList();

            if(roles.Count() < 1 ){
                IdentityRole roleAdmin = new IdentityRole(){
                    Name = RoleName.Admin
                };
                IdentityRole roleStaff = new IdentityRole(){
                    Name = RoleName.Staff
                };
                IdentityResult result = await roleManager.CreateAsync(roleAdmin);
                IdentityResult result1 = await roleManager.CreateAsync(roleStaff);

                await userManager.AddToRoleAsync(awaited_user,roleAdmin.Name);
            }


            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AdminRoleAdd(RoleViewModel model)
        {
            if(ModelState.IsValid){
                IdentityRole role = new IdentityRole(){
                    Name = model.Rolename
                };
                IdentityResult result = await roleManager.CreateAsync(role);

                if(result.Errors.Count() > 0){
                    foreach(IdentityError error in result.Errors){
                        ModelState.AddModelError("",error.Description);
                    }
                }
            }
            return View("AdminRole");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> AdminUserRole()
        {
           await SetUsersRoles();
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AdminUserRoleAdd(UserRoleViewModel model)
        {
            if(ModelState.IsValid){
             ApplicationUser user = await this._apiUserController.GetUserById(model.UserId);
             IdentityRole role = await roleManager.FindByIdAsync(model.RoleId);

            List<IdentityRole> roles =  roleManager.Roles.ToList();
            foreach(IdentityRole current_role in roles){
                if(await userManager.IsInRoleAsync(user,current_role.Name)){
                    await userManager.RemoveFromRoleAsync(user,current_role.Name);
                }
            }
            
             if( !(await userManager.IsInRoleAsync(user,role.Name)) ){
                IdentityResult result = await userManager.AddToRoleAsync(user,role.Name);
                    if(result.Errors.Count() > 0){
                        foreach(IdentityError error in result.Errors){
                            ModelState.AddModelError("",error.Description);
                        }
                    }
             }
            }
            await SetUsersRoles();
            return View("AdminUserRole");
        }

        [HttpPost]
        public async Task<IActionResult> AddCourseLecture(CourseLecturerViewModel model)
        {
            string result = await _apiLecturer.AddANewCourseLecturer(model);
            await GetActiveCourseLecturersSession();
            return View("AdminCoureseLecture");
        }

        [HttpPost]
        public async Task<IActionResult> ViewCourseLectures(CourseLecturerViewModel model)
        {
            HttpContext.Session.Set<string>("ProgramId",model.ProgrammeId.ToString());
            await GetActiveCourseLecturersSession();
            return View("AdminCoureseLecture");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveCourseLecturer(int courselectureIdtoremove)
        {
            var result = await  this._apiLecturer.RemoveOldCourseLecturer(courselectureIdtoremove);
            await GetActiveCourseLecturersSession();
            return View("AdminCoureseLecture");
            
        }


        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult AdminPaymentByPassCode()
        {
            
            this.SetPaymentByPassCodes();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdminPaymentByPassCodeGenerate()
        {
            await this._apiPayment.PaymentByPassCodeGenerate();
            this.SetPaymentByPassCodes();
            return View("AdminPaymentByPassCode");
            
        }
        private bool SetPaymentByPassCodes(){

            List<PaymentByPassCode> paymentbypasscode =  this._apiPayment.PaymentByPassCodes().ToList();
            ViewData["paymentbypasscode"] = paymentbypasscode;
            return true;

        }
        private async Task<bool> SetUsersRoles(){

            var awaited_users =  await _apiUserController.UserStaffAll();
            List<ApplicationUser> users =  awaited_users.ToList();
            List<IdentityRole> roles =  roleManager.Roles.ToList();

            ViewData["users"] = users;   
            ViewData["roles"] = roles;
            return true;

        }

        private async Task<bool> GetActiveCourseLecturersSession(){



            Programme activeProgram = HttpContext.Session.Get<Programme>(GeneralStoredNames.Bim_Edu_Active_Program);
            activeProgram = await this._apiProgrammeController.PorgrammeGetById(activeProgram.ProgrammeId);

            var awaited_result = await _apiLecturer.GetAllCourseLecturersForAProgram(Convert.ToInt32(activeProgram.ProgrammeId));
            List<CourseLecturer> courseLecturers = awaited_result.ToList();

            var awaited_courses = await _apiLecturer.CourseAll();

            ViewData["v_Program"] = activeProgram;
            ViewData["courseLecturers"] = courseLecturers;
            ViewData["lecturers"] = _apiLecturer.GetAllLecturers();
            ViewData["vCourses"] = awaited_courses.ToList();

            return true;
        }

        [Authorize(Roles = "Admin,Staff")]
        [HttpGet]
        public async Task<IActionResult> AdminProgramCalender()
        {
            await this.SetViewDataForProgramCalender();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdminProgramCalender(ProgramCalenderViewModel model)
        {
            if(model.IFormFile != null){
                bool result = await this._apiProgrammeController.AddProgramCalenderToProgram(model);
                if(!result){
                    ModelState.AddModelError("","Error During Processing");
                }
            }
            await this.SetViewDataForProgramCalender();
            return View();
            
        }

        private async Task<bool> SetViewDataForProgramCalender(){

            Programme activeProgram = HttpContext.Session.Get<Programme>(GeneralStoredNames.Bim_Edu_Active_Program);
            activeProgram = await this._apiProgrammeController.PorgrammeGetById(activeProgram.ProgrammeId);
            ViewData["v_Program"] = activeProgram;
            return true;
            
        }


        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> AdminStudentFeeToPay()
        {
            await this.SetViewDataForStudentFeeToPay();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdminStudentFeeToPayView(StudentFeeToPayViewModel model)
        {
            
            HttpContext.Session.Set<string>("program_application_id",model.ProgrammeApplicationId.ToString());
            await this.SetViewDataForStudentFeeToPay();
            return View("AdminStudentFeeToPay");
            
        }

        [HttpPost]
        public async Task<IActionResult> AdminStudentFeeToPayAdd(StudentFeeToPayViewModel model)
        {
            if(ModelState.IsValid){
                HttpContext.Session.Set<string>("program_application_id",model.ProgrammeApplicationId.ToString());
                bool result = await this._apiPayment.StudentFeeToPayAdd(model);
                if(!result){
                     ModelState.AddModelError("","Error During Processing"); 
                }
            }

            await this.SetViewDataForStudentFeeToPay();
            return View("AdminStudentFeeToPay");
            
        }

        [HttpPost]
        public async Task<IActionResult> AdminStudentFeeToPayUpdate(StudentFeeToPayViewModel model)
        {
            if(ModelState.IsValid){
                bool result = await this._apiPayment.StudentFeeToPayUpdate(model);
                if(!result){
                    ModelState.AddModelError("","Error During Processing");
                }
            }

            await this.SetViewDataForStudentFeeToPay();
            return View("AdminStudentFeeToPay");
            
        }

        [HttpPost]
        public async Task<IActionResult> AdminStudentFeeToPayDelete(int StudentFeeToPayId)
        {
                bool result = await this._apiPayment.StudentFeeToPayDelete(StudentFeeToPayId);
                if(!result){
                    ModelState.AddModelError("","Error During Processing");
                }

            await this.SetViewDataForStudentFeeToPay();
            return View("AdminStudentFeeToPay");
            
        }

        private async Task<bool> SetViewDataForStudentFeeToPay(){
         List<ApplicationUser> application_users =   _apiUserController.GetAllUserWithProgramme().ToList();
           string program_application_id = HttpContext.Session.Get<string>("program_application_id");
           if(program_application_id == null){
               if(application_users.FirstOrDefault().ProgrammeApplications.ToList().Count() > 0){
                    program_application_id = application_users.FirstOrDefault().ProgrammeApplications.FirstOrDefault().ProgrammeApplicationId.ToString();
               }else{
                   program_application_id = "0";
               }
           }
            
          ProgrammeApplication program_application =  await _apiProgrammeController
                                                        .ProgramApplicationsToQueryFeesForAStudent(Convert.ToInt32(program_application_id));
           ViewData["application_users"] = application_users;
           ViewData["program_application"] = program_application;
           ViewData["program_application_id"] = program_application_id;
           return true;
        }


    }

}