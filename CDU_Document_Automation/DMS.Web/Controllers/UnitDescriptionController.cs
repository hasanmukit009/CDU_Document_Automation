using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMS.Web.Data;
using DMS.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DMS.Web.Controllers
{
    public class UnitDescriptionController : Controller
    {
        private readonly ILogger<UnitDescriptionController> _logger;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly ApplicationDbContext _context;
        public UnitDescriptionController(ILogger<UnitDescriptionController> logger, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ApplicationDbContext context)
        {
            _logger = logger;
            this.userManager = userManager;
            this.signInManager = signInManager;
            _context = context;
        }

        public IActionResult UnitDescriptionListUC()
        {
            var unitDescriptionList = _context.UnitDescriptionList.OrderByDescending(a => a.OrderByDate).Where(a => a.CurrentPosition == "UC" && a.ChangeRequest == "UD").ToList().GroupBy(a => a.UnitCode);
            List<UnitDescriptionModel> lstUnitDescList = UploadToNewList(unitDescriptionList);
            return View(lstUnitDescList);
        }

        private List<UnitDescriptionModel> UploadToNewList(IEnumerable<IGrouping<string, UnitDescriptionModel>> unitDescriptionList)
        {
            List<UnitDescriptionModel> newlstUnitDescList = new List<UnitDescriptionModel>();
            foreach (var obj1 in unitDescriptionList)
            {
                foreach (var obj in obj1)
                {
                    var objnew = new UnitDescriptionModel();
                    objnew.Id = obj.Id;
                    objnew.UnitCode = obj.UnitCode;
                    objnew.UnitTitle = obj.UnitTitle;
                    objnew.UnitLevel = obj.UnitLevel;
                    objnew.OwningCollege = obj.OwningCollege;
                    objnew.OwningDiscipline = obj.OwningDiscipline;
                    objnew.CoreCourseCode = obj.CoreCourseCode;
                    objnew.SpecialistElectiveCourseCode = obj.SpecialistElectiveCourseCode;
                    objnew.CurrentUnitDescription = obj.CurrentUnitDescription;
                    objnew.TypeOfChangeRequest = obj.TypeOfChangeRequest;
                    objnew.ProposedUnitDescription = obj.ProposedUnitDescription;
                    objnew.JustificatioRequestOutline = obj.JustificatioRequestOutline;
                    objnew.DomesticStudentNumber = obj.DomesticStudentNumber;
                    objnew.InternationalStudentNumber = obj.InternationalStudentNumber;
                    objnew.ObligationsDetails = obj.ObligationsDetails;
                    objnew.RemovalEffectDetails = obj.RemovalEffectDetails;
                    objnew.Summary_Of_Consultation_With_Impacted_College = obj.Summary_Of_Consultation_With_Impacted_College;

                    objnew.UnitCoordinator = obj.UnitCoordinator;
                    objnew.FeedbackByUC = obj.FeedbackByUC;

                    objnew.AssignedCourseCoordinator = obj.AssignedCourseCoordinator;
                    objnew.CourseCoordinator = obj.CourseCoordinator;
                    objnew.FeedbackByCC = obj.FeedbackByCC;

                    objnew.Admin = obj.Admin;
                    objnew.AssignedAdmin = obj.AssignedAdmin;

                    objnew.Reviewer1 = obj.Reviewer1;
                    objnew.AssignedReviewer1 = obj.AssignedReviewer1;
                    objnew.FeedbackByReviewer1 = obj.FeedbackByReviewer1;
                    objnew.IsReviewedByReviewer1 = obj.IsReviewedByReviewer1;

                    objnew.Reviewer2 = obj.Reviewer2;
                    objnew.AssignedReviewer2 = obj.AssignedReviewer2;
                    objnew.FeedbackByReviewer2 = obj.FeedbackByReviewer2;
                    objnew.IsReviewedByReviewer2 = obj.IsReviewedByReviewer2;

                    objnew.Approver = obj.Approver;
                    objnew.AssignedApprover = obj.AssignedApprover;
                    objnew.FeedbackByApprover = obj.FeedbackByApprover;

                    objnew.CreatedBy = obj.CreatedBy;
                    objnew.CreatedDate = obj.CreatedDate;
                    objnew.UpdatedDate = obj.UpdatedDate;
                    objnew.UpdatedBy = obj.UpdatedBy;
                    objnew.AssignedTo = obj.AssignedTo;
                    objnew.AssignedBy = obj.AssignedBy;
                    objnew.AssignedDate = obj.AssignedDate;
                    objnew.Status = obj.Status;
                    objnew.ActivityLog = obj.ActivityLog;
                    objnew.ChangeRequest = obj.ChangeRequest;
                    objnew.OrderByDate = obj.OrderByDate;
                    objnew.CurrentPosition = obj.CurrentPosition;

                    newlstUnitDescList.Add(objnew);
                }
            }
            return newlstUnitDescList;
        }

        [HttpGet]
        public IActionResult AddNewUnitDescription()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewUnitDescription(UnitDescriptionModel model)
        {
            if (ModelState.IsValid)
            {
                UnitDescriptionModel objUnitDescription = LoadUnitDescription(model);
                _context.Add(objUnitDescription);
                await _context.SaveChangesAsync();
                return RedirectToAction("UnitDescriptionListUC");
            }
            return View(model);
        }

        private UnitDescriptionModel LoadUnitDescription(UnitDescriptionModel model)
        {
            var obj = new UnitDescriptionModel
            {
                Id = model.Id,
                UnitCode = model.UnitCode,
                UnitTitle = model.UnitTitle,
                UnitLevel = model.UnitLevel,
                OwningCollege = model.OwningCollege,
                OwningDiscipline = model.OwningDiscipline,
                CoreCourseCode = model.CoreCourseCode,
                SpecialistElectiveCourseCode = model.SpecialistElectiveCourseCode,
                CurrentUnitDescription = model.CurrentUnitDescription,
                TypeOfChangeRequest = model.TypeOfChangeRequest,
                IsChangeToCoreUnitDescriptionContentChecked = model.IsChangeToCoreUnitDescriptionContentChecked,
                IsGrammarOrFormattingAmendmentChecked = model.IsGrammarOrFormattingAmendmentChecked,
                IsProvidingSpecificEnrolmentInformationChecked = model.IsProvidingSpecificEnrolmentInformationChecked,
                ProposedUnitDescription = model.ProposedUnitDescription,
                JustificatioRequestOutline = model.JustificatioRequestOutline,
                DomesticStudentNumber = model.DomesticStudentNumber,
                InternationalStudentNumber = model.InternationalStudentNumber,
                ObligationsDetails = model.ObligationsDetails,
                RemovalEffectDetails = model.RemovalEffectDetails,
                Summary_Of_Consultation_With_Impacted_College = model.Summary_Of_Consultation_With_Impacted_College,
                CourseCoordinator = model.CourseCoordinator,
                UnitCoordinator = User.Identity.Name,
                CreatedBy = User.Identity.Name,
                CreatedDate = DateTime.Now,
                Status = "Created",
                ActivityLog = model.UnitCode + " - " + model.UnitTitle + " created by UC - " + GetNameByEmail(User.Identity.Name),
                ChangeRequest = "UD",
                OrderByDate = DateTime.Now,
                CurrentPosition = "UC"
            };
            return obj;
        }

        private string GetNameByEmail(string email)
        {
            string unitcoordinatorname = string.Empty;
            if (email != null)
            {
                unitcoordinatorname = _context.UserList.Where(a => a.Email == email).FirstOrDefault().FirstName + " " + _context.UserList.Where(a => a.Email == email).FirstOrDefault().LastName;
            }
            return unitcoordinatorname;
        }

        [HttpGet]
        public async Task<IActionResult> ViewUnitDescription(int id)
        {
            var objUnitDescription = await _context.UnitDescriptionList.FindAsync(id);
            return View(objUnitDescription);
        }

        [HttpGet]
        public async Task<IActionResult> EditUnitDescription(int id)
        {
            var objUnitDescription = await _context.UnitDescriptionList.FindAsync(id);
            return View(objUnitDescription);
        }

        [HttpPost]
        public async Task<IActionResult> EditUnitDescription(UnitDescriptionModel model)
        {
            if (ModelState.IsValid)
            {
                model.OrderByDate = DateTime.Now;
                model.UpdatedBy = User.Identity.Name;
                model.UpdatedDate = DateTime.Now;
                model.ActivityLog = model.UnitCode + " - " + model.UnitTitle + " has been updated by UC- " + GetNameByEmail(model.UnitCoordinator);
                _context.Update(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("UnitDescriptionListUC");
            }
            return View(model);
        }

        public JsonResult RemoveUnitDescriptionByUC(int id)
        {
            var objUnitDescription = _context.UnitDescriptionList.Find(id);
            _context.Remove(objUnitDescription);
            _context.SaveChanges();
            return Json(new { status = "Success" });
        }

        public async Task<IActionResult> AssignToCourseCoordinator(int id)
        {
            var objUnitDescription = _context.UnitDescriptionList.Find(id);
            if (objUnitDescription != null)
            {
                objUnitDescription.AssignedTo = objUnitDescription.CourseCoordinator;
                objUnitDescription.AssignedBy = User.Identity.Name;
                objUnitDescription.AssignedDate = DateTime.Now;
                objUnitDescription.UpdatedBy = User.Identity.Name;
                objUnitDescription.UpdatedDate = DateTime.Now;
                objUnitDescription.AssignedCourseCoordinator = objUnitDescription.CourseCoordinator;
                objUnitDescription.CurrentPosition = "CC";
                objUnitDescription.Status = "Pending";
                objUnitDescription.ActivityLog = objUnitDescription.UnitCode + " - " + objUnitDescription.UnitTitle + " has been assigned to CC- " + GetNameByEmail(objUnitDescription.AssignedCourseCoordinator);
                objUnitDescription.OrderByDate = DateTime.Now;

                _context.Update(objUnitDescription);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("DashBoard", "Home");
        }
    }
}