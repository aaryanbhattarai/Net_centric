using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StudentList()
        {
            StudentList student = new StudentList("AAryan", "kathmandu");
            return View(student);

        }
        
        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult DoLogin()
        {

            return View();
        }
        public IActionResult Register()
        {

            return View();
        }
        public IActionResult DoRegister()
        {

            return View();
        }
        public IActionResult ForgotPassword()
        {

            return View();
        }
        public IActionResult ChnagePassword()
        {

            return View();
        }
    }
}
