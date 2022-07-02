using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace breeze.Controllers
{
    [Authorize(Roles = "Admin,Staff")]
    public class Administration_DocumentationController : Controller
    {
        public Administration_DocumentationController()
        {

        }

        [HttpGet]
        public IActionResult Admin_Doc_Links()
        {
            return View();
        } 

        [HttpGet]
        public IActionResult Admin_Doc_Application()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Admin_Doc_Staff()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Admin_Doc_Certificate()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Admin_Doc_Program()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Admin_Doc_Video()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Admin_Doc_Documents()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Admin_Doc_Results()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Admin_Doc_Calender()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Admin_Doc_Course()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Admin_Doc_Lecture()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Admin_Doc_UserRole()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Admin_Doc_PaymentCodes()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Admin_Doc_Payments()
        {
            return View();
        }

    }

}