using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bim_edu.Models;
using bim_edu.DataContect.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using bim_edu.APIs.Controllers;
using bim_edu.UserDefined.Functions;

namespace bim_edu.Controllers
{
    public class en_HomeController : Controller
    {
        private ApiProgrammeController _apiProgrammeController;
        private ApiUserController _apiUserController;
        private List<Programme> _programmes;
        private readonly IConfiguration _conf;

        public en_HomeController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> SignInManager,
                                BimEduDataContext breezeDataContext,IConfiguration conf,IHostingEnvironment environment)
        {
            _apiProgrammeController = new ApiProgrammeController(breezeDataContext,conf,environment);
            _apiUserController = new ApiUserController(userManager,SignInManager,breezeDataContext,conf,environment);
            this._conf = conf;
        } 

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Studentexperience()
        {
            return View();
        }

        public IActionResult TuitionFee()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TeachWithus()
        {

            _programmes = _apiProgrammeController.GetAllPorgrammes().ToList();
            ViewData["programmes"] = _programmes;
            ViewData["message"] = null;
            return View();
        }

        [HttpGet]
        public IActionResult Feedback(string heading="",string description="")
        {
            ViewData["heading"] = heading;
            ViewData["description"] = description;
            return View();            
        }

        [HttpPost]
        public async Task<IActionResult> TeachWithus(TeachWithUsViewModel model)
        {
            _programmes = _apiProgrammeController.GetAllPorgrammes().ToList();
            ViewData["programmes"] = _programmes;
            if(ModelState.IsValid){
            if(model.Phone.Contains('+')){
                ViewData["message"] = null;
                ModelState.AddModelError("","Phone Number should be only numbers");
                return View(model);
            }
            var message = "<div style='padding:20px;background:#4b345d;color:white;'>" +
                            "<h1 style='color:white;font-weight:bolder;text-align:center;'>" +
                            "<span style='color:white'> WANT TO TEACH WITH BIM-EDU </span>" +
                            "</h1>" +
                            "<div style='color:white;font-weight:bolder;text-align:center'>" +
                                "<div style='text-align:left'><span> Name </span> : " + model.Name + "<span> </span></div><br/><br/>" +
                                "<div style='text-align:left'><span> Email </span style='color:white'> : " + model.Email + "<span> </span></div><br/><br/>" +
                                "<div style='text-align:left'><span> Phone </span> : " + model.Phone + "<span> </span></div><br/><br/>" +
                                "<div style='text-align:left'><span> Level Of Education </span> : " + model.LevelOfEducation + "<span> </span></div><br/><br/>" +
                                "<div style='text-align:left'><span> Programme Applied To Teach  </span> : " + model.ProgrammeName + "<span> </span></div><br/><br/>" +
                                "<div style='text-align:left'><span> About Me  </span> : " + model.AboutYourself + "<span> </span></div><br/><br/>" +
                            "</div>" +
                            "</div>";

              bool result =  await userEmailSender.EmailSender(_conf,_conf.GetValue<string>("Email:enquiryemailreceiver"),
                                                    "TEACH WITH BIM EDU Application From Website", message);
                if(result){
                    ViewData["message"] = "Application Sent. You Will Hear From Us Soon!";
                }
                else{
                    ViewData["message"] = null;
                }
            }
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
