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
            var unitDescriptionList = _context.UnitDescriptionList.OrderByDescending(a => a.OrderByDate).Where(a => a.CurrentPosition == "UC").ToList();
            List<UnitDescriptionModel> lstUnitDescList = UploadToNewList(unitDescriptionList);
            return View(lstUnitDescList);
        }

        private List<UnitDescriptionModel> UploadToNewList(List<UnitDescriptionModel> unitDescriptionList)
        {
            List<UnitDescriptionModel> newlstUnitDescList = new List<UnitDescriptionModel>();
            foreach (var obj in unitDescriptionList)
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
            return newlstUnitDescList;
        }


        public IActionResult AddNewUnitDescription()
        {
            return View();
        }
    }
}