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
    public class AssessmentItemController : Controller
    {
        private readonly ILogger<AssessmentItemController> _logger;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly ApplicationDbContext _context;
        public AssessmentItemController(ILogger<AssessmentItemController> logger, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ApplicationDbContext context)
        {
            _logger = logger;
            this.userManager = userManager;
            this.signInManager = signInManager;
            _context = context;
        }


        public IActionResult UnitAssessmentItemListUC()
        {
            var unitAssessmentItemList = _context.UnitAssessmentItemList.OrderByDescending(a => a.OrderByDate).Where(a => a.CurrentPosition == "UC").ToList();
            List<UnitAssessmentItemModel> lstUnitDescList = UploadToNewList(unitAssessmentItemList);
            return View(lstUnitDescList);
        }

        private List<UnitAssessmentItemModel> UploadToNewList(List<UnitAssessmentItemModel> unitAssessmentItemList)
        {
            List<UnitAssessmentItemModel> newAssessmentItemList = new List<UnitAssessmentItemModel>();
            foreach (var obj in unitAssessmentItemList)
            {
                var objnew = new UnitAssessmentItemModel
                {
                    Id = obj.Id,
                    UnitCode = obj.UnitCode,
                    UnitTitle = obj.UnitTitle,
                    UnitLevel = obj.UnitLevel,
                    OwningCollege = obj.OwningCollege,
                    OwningDiscipline = obj.OwningDiscipline,

                    Semester_Year_of_Implementation = obj.Semester_Year_of_Implementation,

                    Order_1 = obj.Order_1,
                    Order_2 = obj.Order_2,
                    Order_3 = obj.Order_3,
                    Order_4 = obj.Order_4,
                    Order_5 = obj.Order_5,
                    Order_6 = obj.Order_6,
                    Order_7 = obj.Order_7,

                    Current_Accredited_Assessment_Item_Description_1 = obj.Current_Accredited_Assessment_Item_Description_1,
                    Current_Accredited_Assessment_Item_Description_2 = obj.Current_Accredited_Assessment_Item_Description_2,
                    Current_Accredited_Assessment_Item_Description_3 = obj.Current_Accredited_Assessment_Item_Description_3,
                    Current_Accredited_Assessment_Item_Description_4 = obj.Current_Accredited_Assessment_Item_Description_4,
                    Current_Accredited_Assessment_Item_Description_5 = obj.Current_Accredited_Assessment_Item_Description_5,
                    Current_Accredited_Assessment_Item_Description_6 = obj.Current_Accredited_Assessment_Item_Description_6,
                    Current_Accredited_Assessment_Item_Description_7 = obj.Current_Accredited_Assessment_Item_Description_7,

                    Current_Accredited_Assessment_Percentage_1 = obj.Current_Accredited_Assessment_Percentage_1,
                    Current_Accredited_Assessment_Percentage_2 = obj.Current_Accredited_Assessment_Percentage_2,
                    Current_Accredited_Assessment_Percentage_3 = obj.Current_Accredited_Assessment_Percentage_3,
                    Current_Accredited_Assessment_Percentage_4 = obj.Current_Accredited_Assessment_Percentage_4,
                    Current_Accredited_Assessment_Percentage_5 = obj.Current_Accredited_Assessment_Percentage_5,
                    Current_Accredited_Assessment_Percentage_6 = obj.Current_Accredited_Assessment_Percentage_6,
                    Current_Accredited_Assessment_Percentage_7 = obj.Current_Accredited_Assessment_Percentage_7,

                    Current_Accredited_Assessment_ULO_1 = obj.Current_Accredited_Assessment_ULO_1,
                    Current_Accredited_Assessment_ULO_2 = obj.Current_Accredited_Assessment_ULO_2,
                    Current_Accredited_Assessment_ULO_3 = obj.Current_Accredited_Assessment_ULO_3,
                    Current_Accredited_Assessment_ULO_4 = obj.Current_Accredited_Assessment_ULO_4,
                    Current_Accredited_Assessment_ULO_5 = obj.Current_Accredited_Assessment_ULO_5,
                    Current_Accredited_Assessment_ULO_6 = obj.Current_Accredited_Assessment_ULO_6,
                    Current_Accredited_Assessment_ULO_7 = obj.Current_Accredited_Assessment_ULO_7,

                    Proposed_Assessment_Items_Description_1 = obj.Proposed_Assessment_Items_Description_1,
                    Proposed_Assessment_Items_Description_2 = obj.Proposed_Assessment_Items_Description_2,
                    Proposed_Assessment_Items_Description_3 = obj.Proposed_Assessment_Items_Description_3,
                    Proposed_Assessment_Items_Description_4 = obj.Proposed_Assessment_Items_Description_4,
                    Proposed_Assessment_Items_Description_5 = obj.Proposed_Assessment_Items_Description_5,
                    Proposed_Assessment_Items_Description_6 = obj.Proposed_Assessment_Items_Description_6,
                    Proposed_Assessment_Items_Description_7 = obj.Proposed_Assessment_Items_Description_7,

                    Proposed_Assessment_Items_Percentage_1 = obj.Proposed_Assessment_Items_Percentage_1,
                    Proposed_Assessment_Items_Percentage_2 = obj.Proposed_Assessment_Items_Percentage_2,
                    Proposed_Assessment_Items_Percentage_3 = obj.Proposed_Assessment_Items_Percentage_3,
                    Proposed_Assessment_Items_Percentage_4 = obj.Proposed_Assessment_Items_Percentage_4,
                    Proposed_Assessment_Items_Percentage_5 = obj.Proposed_Assessment_Items_Percentage_5,
                    Proposed_Assessment_Items_Percentage_6 = obj.Proposed_Assessment_Items_Percentage_6,
                    Proposed_Assessment_Items_Percentage_7 = obj.Proposed_Assessment_Items_Percentage_7,

                    Proposed_Assessment_Items_ULO_1 = obj.Proposed_Assessment_Items_ULO_1,
                    Proposed_Assessment_Items_ULO_2 = obj.Proposed_Assessment_Items_ULO_2,
                    Proposed_Assessment_Items_ULO_3 = obj.Proposed_Assessment_Items_ULO_3,
                    Proposed_Assessment_Items_ULO_4 = obj.Proposed_Assessment_Items_ULO_4,
                    Proposed_Assessment_Items_ULO_5 = obj.Proposed_Assessment_Items_ULO_5,
                    Proposed_Assessment_Items_ULO_6 = obj.Proposed_Assessment_Items_ULO_6,
                    Proposed_Assessment_Items_ULO_7 = obj.Proposed_Assessment_Items_ULO_7,

                    Is_This_Unit_Currently_Accredited = obj.Is_This_Unit_Currently_Accredited,
                    Is_This_Unit_Required = obj.Is_This_Unit_Required,

                    JustificatioRequestOutline = obj.JustificatioRequestOutline,
                    DomesticStudentNumber = obj.DomesticStudentNumber,
                    InternationalStudentNumber = obj.InternationalStudentNumber,

                    ReviewedCoreCourseList = obj.ReviewedCoreCourseList,
                    ReviewedSpecialistElectiveCourseList = obj.ReviewedSpecialistElectiveCourseList,
                    Provide_Summary_If_Student_Consultation_Was_Undertaken = obj.Provide_Summary_If_Student_Consultation_Was_Undertaken,
                    Provide_Summary_If_The_Proposed_Change_Response_To_Student = obj.Provide_Summary_If_The_Proposed_Change_Response_To_Student,

                    Summary_Of_Consultation_With_Impacted_College = obj.Summary_Of_Consultation_With_Impacted_College,

                    UnitCoordinator = obj.UnitCoordinator,
                    FeedbackByUC = obj.FeedbackByUC,

                    AssignedCourseCoordinator = obj.AssignedCourseCoordinator,
                    CourseCoordinator = obj.CourseCoordinator,
                    FeedbackByCC = obj.FeedbackByCC,

                    Admin = obj.Admin,
                    AssignedAdmin = obj.AssignedAdmin,

                    Reviewer1 = obj.Reviewer1,
                    AssignedReviewer1 = obj.AssignedReviewer1,
                    FeedbackByReviewer1 = obj.FeedbackByReviewer1,
                    IsReviewedByReviewer1 = obj.IsReviewedByReviewer1,

                    Reviewer2 = obj.Reviewer2,
                    AssignedReviewer2 = obj.AssignedReviewer2,
                    FeedbackByReviewer2 = obj.FeedbackByReviewer2,
                    IsReviewedByReviewer2 = obj.IsReviewedByReviewer2,

                    Approver = obj.Approver,
                    AssignedApprover = obj.AssignedApprover,
                    FeedbackByApprover = obj.FeedbackByApprover,

                    CreatedBy = obj.CreatedBy,
                    CreatedDate = obj.CreatedDate,
                    UpdatedDate = obj.UpdatedDate,
                    UpdatedBy = obj.UpdatedBy,
                    AssignedTo = obj.AssignedTo,
                    AssignedBy = obj.AssignedBy,
                    AssignedDate = obj.AssignedDate,
                    Status = obj.Status,
                    ActivityLog = obj.ActivityLog,
                    ChangeRequest = obj.ChangeRequest,
                    OrderByDate = obj.OrderByDate,
                    CurrentPosition = obj.CurrentPosition
                };
                newAssessmentItemList.Add(objnew);
            }
            return newAssessmentItemList;
        }


        public IActionResult AddNewAssessmentItem()
        {
            return View();
        }
    }
}