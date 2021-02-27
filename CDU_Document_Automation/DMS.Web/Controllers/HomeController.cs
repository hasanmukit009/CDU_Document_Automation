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
                    mailSender.SendMail("Verification Code", output, "hasanmukit009@gmail.com");
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
            var unitInformationList = _context.UnitInformationList.OrderByDescending(a => a.OrderByDate).ToList();
            List<UnitInformationModel> lstUnitInfoList = UploadToNewList(unitInformationList);
            return View(lstUnitInfoList);
        }

        private List<UnitInformationModel> UploadToNewList(List<UnitInformationModel> unitInformationList)
        {
            List<UnitInformationModel> lstUnitInfoList = new List<UnitInformationModel>();
            foreach (var obj in unitInformationList)
            {
                var objnew = new UnitInformationModel();
                objnew.Id = obj.Id;
                objnew.UnitCode = obj.UnitCode;
                objnew.UnitTitle = obj.UnitTitle;
                objnew.CreditPoints = obj.CreditPoints;
                objnew.Prerequisites = obj.Prerequisites;
                objnew.Semester = obj.Semester;
                objnew.Year = obj.Year;
                objnew.Mode = obj.Mode;
                objnew.Location = obj.Location;
                objnew.LearningMethod = obj.LearningMethod;
                objnew.UnitCoordinator = GetNameByEmail(obj.UnitCoordinator);
                objnew.Phone = obj.Phone;
                objnew.Email = obj.Email;
                objnew.UnitDescription = obj.UnitDescription;
                objnew.LearningOutComes = obj.LearningOutComes;
                objnew.TeachingAndLearningApproach_HowUnitRun = obj.TeachingAndLearningApproach_HowUnitRun;
                objnew.TeachingAndLearningApproach_LecturerRole = obj.TeachingAndLearningApproach_LecturerRole;
                objnew.TeachingAndLearningApproach_StudentParticipation = obj.TeachingAndLearningApproach_StudentParticipation;
                objnew.Resources_RequiredTextbooks = obj.Resources_RequiredTextbooks;
                objnew.Resources_Learnline = obj.Resources_Learnline;
                objnew.Resources_eReserveCourseReadings = obj.Resources_eReserveCourseReadings;
                objnew.Resources_AdditionalResources = obj.Resources_AdditionalResources;
                objnew.CreatedBy = obj.CreatedBy;
                objnew.CreatedDate = obj.CreatedDate;
                objnew.UpdatedDate = obj.UpdatedDate;
                objnew.UpdatedBy = obj.UpdatedBy;
                objnew.AssignedTo = obj.AssignedTo;
                objnew.AssignedBy = obj.AssignedBy;
                objnew.AssignedDate = obj.AssignedDate;
                objnew.Status = obj.Status;
                objnew.Remarks = obj.Remarks;
                objnew.FeedbackByCC = obj.FeedbackByCC;
                objnew.IsReviewedByReviewer1 = obj.IsReviewedByReviewer1;
                objnew.FeedbackByReviewer1 = obj.FeedbackByReviewer1;
                objnew.IsReviewedByReviewer2 = obj.IsReviewedByReviewer2;
                objnew.FeedbackByReviewer2 = obj.FeedbackByReviewer2;
                objnew.FeedbackByApprover = obj.FeedbackByApprover;
                objnew.CourseCoordinator = GetNameByEmail(obj.CourseCoordinator);
                objnew.CurrentPosition = obj.CurrentPosition;
                objnew.Assessment_Overview_Description_1 = obj.Assessment_Overview_Description_1;
                objnew.Assessment_Overview_Description_2 = obj.Assessment_Overview_Description_2;
                objnew.Assessment_Overview_Description_3 = obj.Assessment_Overview_Description_3;
                objnew.Assessment_Overview_Description_4 = obj.Assessment_Overview_Description_4;
                objnew.Assessment_Overview_Item_1 = obj.Assessment_Overview_Item_1;
                objnew.Assessment_Overview_Item_2 = obj.Assessment_Overview_Item_2;
                objnew.Assessment_Overview_Item_3 = obj.Assessment_Overview_Item_3;
                objnew.Assessment_Overview_Item_4 = obj.Assessment_Overview_Item_4;
                objnew.Assessment_Overview_Learning_Outcome_1 = obj.Assessment_Overview_Learning_Outcome_1;
                objnew.Assessment_Overview_Learning_Outcome_2 = obj.Assessment_Overview_Learning_Outcome_2;
                objnew.Assessment_Overview_Learning_Outcome_3 = obj.Assessment_Overview_Learning_Outcome_3;
                objnew.Assessment_Overview_Learning_Outcome_4 = obj.Assessment_Overview_Learning_Outcome_4;
                objnew.Assessment_Overview_Value_1 = obj.Assessment_Overview_Value_1;
                objnew.Assessment_Overview_Value_2 = obj.Assessment_Overview_Value_2;
                objnew.Assessment_Overview_Value_3 = obj.Assessment_Overview_Value_3;
                objnew.Assessment_Overview_Value_4 = obj.Assessment_Overview_Value_4;
                objnew.LearningSchedule_Assessments_1 = obj.LearningSchedule_Assessments_1;
                objnew.LearningSchedule_Assessments_2 = obj.LearningSchedule_Assessments_2;
                objnew.LearningSchedule_Assessments_3 = obj.LearningSchedule_Assessments_3;
                objnew.LearningSchedule_Assessments_4 = obj.LearningSchedule_Assessments_4;
                objnew.LearningSchedule_Assessments_5 = obj.LearningSchedule_Assessments_5;
                objnew.LearningSchedule_Assessments_6 = obj.LearningSchedule_Assessments_6;
                objnew.LearningSchedule_Assessments_7 = obj.LearningSchedule_Assessments_7;
                objnew.LearningSchedule_Assessments_8 = obj.LearningSchedule_Assessments_8;
                objnew.LearningSchedule_Assessments_9 = obj.LearningSchedule_Assessments_9;
                objnew.LearningSchedule_Assessments_10 = obj.LearningSchedule_Assessments_10;
                objnew.LearningSchedule_Assessments_11 = obj.LearningSchedule_Assessments_11;
                objnew.LearningSchedule_Assessments_12 = obj.LearningSchedule_Assessments_12;
                objnew.LearningSchedule_Assessments_13 = obj.LearningSchedule_Assessments_13;
                objnew.LearningSchedule_Assessments_14 = obj.LearningSchedule_Assessments_14;
                objnew.LearningSchedule_Assessments_15 = obj.LearningSchedule_Assessments_15;
                objnew.LearningSchedule_Topic_1 = obj.LearningSchedule_Topic_1;
                objnew.LearningSchedule_Topic_2 = obj.LearningSchedule_Topic_2;
                objnew.LearningSchedule_Topic_3 = obj.LearningSchedule_Topic_3;
                objnew.LearningSchedule_Topic_4 = obj.LearningSchedule_Topic_4;
                objnew.LearningSchedule_Topic_5 = obj.LearningSchedule_Topic_5;
                objnew.LearningSchedule_Topic_6 = obj.LearningSchedule_Topic_6;
                objnew.LearningSchedule_Topic_7 = obj.LearningSchedule_Topic_7;
                objnew.LearningSchedule_Topic_8 = obj.LearningSchedule_Topic_8;
                objnew.LearningSchedule_Topic_9 = obj.LearningSchedule_Topic_9;
                objnew.LearningSchedule_Topic_10 = obj.LearningSchedule_Topic_10;
                objnew.LearningSchedule_Topic_11 = obj.LearningSchedule_Topic_11;
                objnew.LearningSchedule_Topic_12 = obj.LearningSchedule_Topic_12;
                objnew.LearningSchedule_Topic_13 = obj.LearningSchedule_Topic_13;
                objnew.LearningSchedule_Topic_14 = obj.LearningSchedule_Topic_14;
                objnew.LearningSchedule_Topic_15 = obj.LearningSchedule_Topic_15;
                objnew.LearningSchedule_Tutorial_1 = obj.LearningSchedule_Tutorial_1;
                objnew.LearningSchedule_Tutorial_2 = obj.LearningSchedule_Tutorial_2;
                objnew.LearningSchedule_Tutorial_3 = obj.LearningSchedule_Tutorial_3;
                objnew.LearningSchedule_Tutorial_4 = obj.LearningSchedule_Tutorial_4;
                objnew.LearningSchedule_Tutorial_5 = obj.LearningSchedule_Tutorial_5;
                objnew.LearningSchedule_Tutorial_6 = obj.LearningSchedule_Tutorial_6;
                objnew.LearningSchedule_Tutorial_7 = obj.LearningSchedule_Tutorial_7;
                objnew.LearningSchedule_Tutorial_8 = obj.LearningSchedule_Tutorial_8;
                objnew.LearningSchedule_Tutorial_9 = obj.LearningSchedule_Tutorial_9;
                objnew.LearningSchedule_Tutorial_10 = obj.LearningSchedule_Tutorial_10;
                objnew.LearningSchedule_Tutorial_11 = obj.LearningSchedule_Tutorial_11;
                objnew.LearningSchedule_Tutorial_12 = obj.LearningSchedule_Tutorial_12;
                objnew.LearningSchedule_Tutorial_13 = obj.LearningSchedule_Tutorial_13;
                objnew.LearningSchedule_Tutorial_14 = obj.LearningSchedule_Tutorial_14;
                objnew.LearningSchedule_Tutorial_15 = obj.LearningSchedule_Tutorial_15;
                objnew.LearningSchedule_Week_1 = obj.LearningSchedule_Week_1;
                objnew.LearningSchedule_Week_2 = obj.LearningSchedule_Week_2;
                objnew.LearningSchedule_Week_3 = obj.LearningSchedule_Week_3;
                objnew.LearningSchedule_Week_4 = obj.LearningSchedule_Week_4;
                objnew.LearningSchedule_Week_5 = obj.LearningSchedule_Week_5;
                objnew.LearningSchedule_Week_6 = obj.LearningSchedule_Week_6;
                objnew.LearningSchedule_Week_7 = obj.LearningSchedule_Week_7;
                objnew.LearningSchedule_Week_8 = obj.LearningSchedule_Week_8;
                objnew.LearningSchedule_Week_9 = obj.LearningSchedule_Week_9;
                objnew.LearningSchedule_Week_10 = obj.LearningSchedule_Week_10;
                objnew.LearningSchedule_Week_11 = obj.LearningSchedule_Week_11;
                objnew.LearningSchedule_Week_12 = obj.LearningSchedule_Week_12;
                objnew.LearningSchedule_Week_13 = obj.LearningSchedule_Week_13;
                objnew.LearningSchedule_Week_14 = obj.LearningSchedule_Week_14;
                objnew.LearningSchedule_Week_15 = obj.LearningSchedule_Week_15;
                objnew.TeachingAndLearningApproach = obj.TeachingAndLearningApproach;
                objnew.ChangeRequest = obj.ChangeRequest;

                objnew.AssignedCourseCoordinator = GetNameByEmail(obj.AssignedCourseCoordinator);


                objnew.AssignedAdmin = GetNameByEmail(obj.AssignedAdmin);
                objnew.AssignedReviewer1 = GetNameByEmail(obj.AssignedReviewer1);
                objnew.AssignedReviewer2 = GetNameByEmail(obj.AssignedReviewer2);
                objnew.AssignedApprover = GetNameByEmail(obj.AssignedApprover);


                objnew.OrderByDate = obj.OrderByDate;


                lstUnitInfoList.Add(objnew);
            }
            return lstUnitInfoList;
        }

        private string GetNameByEmail(string unitCoordinator)
        {
            if (!string.IsNullOrEmpty(unitCoordinator))
            {
                unitCoordinator = _context.UserList.Where(a => a.Email == unitCoordinator).FirstOrDefault().FirstName + " " + _context.UserList.Where(a => a.Email == unitCoordinator).FirstOrDefault().LastName;
            }
            return unitCoordinator;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Contact()
        {
            return View();
        }
    }
}
