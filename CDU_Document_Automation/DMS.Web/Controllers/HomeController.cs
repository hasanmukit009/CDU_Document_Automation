using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DMS.Web.Models;
using Microsoft.AspNetCore.Identity;
using DMS.Web.Data;
using DMS.Web.ViewModel;
using DMS.Web.Utils;

namespace DMS.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ApplicationDbContext context)
        {
            _logger = logger;
            this.userManager = userManager;
            this.signInManager = signInManager;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginAsync(UserViewModel model)
        {
            var obj = _context.UserList.Where(a => a.Email == model.Email && a.Password == model.Password).ToList().FirstOrDefault();
            if (obj != null)
            {
                var user = new IdentityUser { UserName = model.Email, Email = model.Email };
                await signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("DashBoard", "Home");
            }
            else
            {
                ViewBag.IncorrectUserNamePassword = "Wrong username or password. Try again!";
            }
            return View(model);
        }
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                MailSender mailSender = new MailSender();
                Random_Generator generator = new Random_Generator();
                string verficationcode = generator.RandomString(10, false);

                var user = new IdentityUser { UserName = model.Email, Email = model.Email };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    var obj = LoadUser(model);
                    _context.Add(obj);
                    await _context.SaveChangesAsync();
                    string output = string.Format(format: "Dear {0}, {1} Thank you for your registration, please copy the below code to complete your registration.{2} Verification Code: {3}", model.FirstName, Environment.NewLine, Environment.NewLine, verficationcode);
                    mailSender.SendMail("Verification Code", output, model.Email);
                    obj.VerficationCode = verficationcode;
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("VerifyRegistration", new { id = obj.Id });
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        private UserModel LoadUser(UserViewModel model)
        {
            var obj = new UserModel
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Password = model.Password,
                Email = model.Email,
                UserType = model.UserType
            };
            return obj;
        }

        [HttpGet]
        public IActionResult VerifyRegistration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> VerifyRegistration(UserModel user)
        {
            var objuser = await _context.UserList.FindAsync(user.Id);
            if (objuser.VerficationCode != user.VerficationCode)
            {
                return RedirectToAction("FailedRegistration", new { id = user.Id });
            }
            objuser.IsActive = true;
            _context.Update(objuser);
            await _context.SaveChangesAsync();
            return RedirectToAction("SuccessfulRegistration");
        }

        public IActionResult SuccessfulRegistration()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> FailedRegistration(int id)
        {
            var objuser = await _context.UserList.FindAsync(id);
            return View(objuser);
        }

        [HttpPost]
        public IActionResult FailedRegistration(UserModel user)
        {
            return RedirectToAction("VerifyRegistration", new { id = user.Id });
        }

        public IActionResult Logout()
        {
            signInManager.SignOutAsync();
            return RedirectToAction("Login", "Home");
        }




        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult DashBoard()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
