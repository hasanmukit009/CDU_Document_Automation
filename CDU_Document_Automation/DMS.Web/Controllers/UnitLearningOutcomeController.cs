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
    public class UnitLearningOutcomeController : Controller
    {
        private readonly ILogger<UnitLearningOutcomeController> _logger;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly ApplicationDbContext _context;
        public UnitLearningOutcomeController(ILogger<UnitLearningOutcomeController> logger, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ApplicationDbContext context)
        {
            _logger = logger;
            this.userManager = userManager;
            this.signInManager = signInManager;
            _context = context;
        }


        public IActionResult UnitLearningOutcomeListUC()
        {
            var unitLearningOutcomeList = _context.UnitLearningOutcomeList.OrderByDescending(a => a.OrderByDate).Where(a => a.CurrentPosition == "UC").ToList();
            List<UnitLearningOutcomeModel> lstUnitLearningOutcomeList = UploadToNewList(unitLearningOutcomeList);
            return View(lstUnitLearningOutcomeList);
        }

        private List<UnitLearningOutcomeModel> UploadToNewList(List<UnitLearningOutcomeModel> unitLearningOutcomeList)
        {
            List<UnitLearningOutcomeModel> newlstLearningOutcomeList = new List<UnitLearningOutcomeModel>();
            foreach (var obj in unitLearningOutcomeList)
            {
                var objnew = new UnitLearningOutcomeModel();
                objnew.Id = obj.Id;
                objnew.UnitCode = obj.UnitCode;
                objnew.UnitTitle = obj.UnitTitle;
                objnew.UnitLevel = obj.UnitLevel;
                objnew.OwningCollege = obj.OwningCollege;
                objnew.OwningDiscipline = obj.OwningDiscipline;

                objnew.Semester_Year_of_Implementation = obj.Semester_Year_of_Implementation;
                
                objnew.Order_1 = obj.Order_1;
                objnew.Order_2 = obj.Order_2;
                objnew.Order_3 = obj.Order_3;
                objnew.Order_4 = obj.Order_4;
                objnew.Order_5 = obj.Order_5;
                objnew.Order_6 = obj.Order_6;
                objnew.Order_7 = obj.Order_7;

                objnew.Current_Learning_Outcomes_Description_1 = obj.Current_Learning_Outcomes_Description_1;
                objnew.Current_Learning_Outcomes_Description_2 = obj.Current_Learning_Outcomes_Description_2;
                objnew.Current_Learning_Outcomes_Description_3 = obj.Current_Learning_Outcomes_Description_3;
                objnew.Current_Learning_Outcomes_Description_4 = obj.Current_Learning_Outcomes_Description_4;
                objnew.Current_Learning_Outcomes_Description_5 = obj.Current_Learning_Outcomes_Description_5;
                objnew.Current_Learning_Outcomes_Description_6 = obj.Current_Learning_Outcomes_Description_6;
                objnew.Current_Learning_Outcomes_Description_7 = obj.Current_Learning_Outcomes_Description_7;

                objnew.Current_Course_Learning_Outcome_1 = obj.Current_Course_Learning_Outcome_1;
                objnew.Current_Course_Learning_Outcome_2 = obj.Current_Course_Learning_Outcome_2;
                objnew.Current_Course_Learning_Outcome_3 = obj.Current_Course_Learning_Outcome_3;
                objnew.Current_Course_Learning_Outcome_4 = obj.Current_Course_Learning_Outcome_4;
                objnew.Current_Course_Learning_Outcome_5 = obj.Current_Course_Learning_Outcome_5;
                objnew.Current_Course_Learning_Outcome_6 = obj.Current_Course_Learning_Outcome_6;
                objnew.Current_Course_Learning_Outcome_7 = obj.Current_Course_Learning_Outcome_7;

                objnew.Proposed_Learning_Outcomes_Description_1 = obj.Proposed_Learning_Outcomes_Description_1;
                objnew.Proposed_Learning_Outcomes_Description_2 = obj.Proposed_Learning_Outcomes_Description_2;
                objnew.Proposed_Learning_Outcomes_Description_3 = obj.Proposed_Learning_Outcomes_Description_3;
                objnew.Proposed_Learning_Outcomes_Description_4 = obj.Proposed_Learning_Outcomes_Description_4;
                objnew.Proposed_Learning_Outcomes_Description_5 = obj.Proposed_Learning_Outcomes_Description_5;
                objnew.Proposed_Learning_Outcomes_Description_6 = obj.Proposed_Learning_Outcomes_Description_6;
                objnew.Proposed_Learning_Outcomes_Description_7 = obj.Proposed_Learning_Outcomes_Description_7;

                objnew.Proposed_Course_Learning_Outcome_1 = obj.Proposed_Course_Learning_Outcome_1;
                objnew.Proposed_Course_Learning_Outcome_2 = obj.Proposed_Course_Learning_Outcome_2;
                objnew.Proposed_Course_Learning_Outcome_3 = obj.Proposed_Course_Learning_Outcome_3;
                objnew.Proposed_Course_Learning_Outcome_4 = obj.Proposed_Course_Learning_Outcome_4;
                objnew.Proposed_Course_Learning_Outcome_5 = obj.Proposed_Course_Learning_Outcome_5;
                objnew.Proposed_Course_Learning_Outcome_6 = obj.Proposed_Course_Learning_Outcome_6;
                objnew.Proposed_Course_Learning_Outcome_7 = obj.Proposed_Course_Learning_Outcome_7;

                objnew.JustificatioRequestOutline = obj.JustificatioRequestOutline;
                objnew.DomesticStudentNumber = obj.DomesticStudentNumber;
                objnew.InternationalStudentNumber = obj.InternationalStudentNumber;

                objnew.ReviewedCoreCourseList = obj.ReviewedCoreCourseList;
                objnew.ReviewedSpecialistElectiveCourseList = obj.ReviewedSpecialistElectiveCourseList;
                objnew.Provide_Summary_If_Student_Consultation_Was_Undertaken = obj.Provide_Summary_If_Student_Consultation_Was_Undertaken;
                objnew.Provide_Summary_If_The_Proposed_Change_Response_To_Student = obj.Provide_Summary_If_The_Proposed_Change_Response_To_Student;

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

                newlstLearningOutcomeList.Add(objnew);
            }
            return newlstLearningOutcomeList;
        }


        public IActionResult AddNewUnitLearningOutcome()
        {
            return View();
        }
    }
}