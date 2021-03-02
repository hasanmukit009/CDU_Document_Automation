using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMS.Web.ViewModel
{
    public class UnitAssessmentItemViewModel
    {
            public string ChangeRequest { get; set; }
            public string UnitCode { get; set; }
            public string UnitTitle { get; set; }
            public string UnitLevel { get; set; }
            public string OwningCollege { get; set; }
            public string OwningDiscipline { get; set; }
            public string Semester_Year_of_Implementation { get; set; }

            public string Order_1 { get; set; }
            public string Order_2 { get; set; }
            public string Order_3 { get; set; }
            public string Order_4 { get; set; }
            public string Order_5 { get; set; }
            public string Order_6 { get; set; }
            public string Order_7 { get; set; }

            public string Current_Accredited_Assessment_Item_Description_1 { get; set; }
            public string Current_Accredited_Assessment_Item_Description_2 { get; set; }
            public string Current_Accredited_Assessment_Item_Description_3 { get; set; }
            public string Current_Accredited_Assessment_Item_Description_4 { get; set; }
            public string Current_Accredited_Assessment_Item_Description_5 { get; set; }
            public string Current_Accredited_Assessment_Item_Description_6 { get; set; }
            public string Current_Accredited_Assessment_Item_Description_7 { get; set; }

            public string Current_Accredited_Assessment_Percentage_1 { get; set; }
            public string Current_Accredited_Assessment_Percentage_2 { get; set; }
            public string Current_Accredited_Assessment_Percentage_3 { get; set; }
            public string Current_Accredited_Assessment_Percentage_4 { get; set; }
            public string Current_Accredited_Assessment_Percentage_5 { get; set; }
            public string Current_Accredited_Assessment_Percentage_6 { get; set; }
            public string Current_Accredited_Assessment_Percentage_7 { get; set; }

            public string Current_Accredited_Assessment_ULO_1 { get; set; }
            public string Current_Accredited_Assessment_ULO_2 { get; set; }
            public string Current_Accredited_Assessment_ULO_3 { get; set; }
            public string Current_Accredited_Assessment_ULO_4 { get; set; }
            public string Current_Accredited_Assessment_ULO_5 { get; set; }
            public string Current_Accredited_Assessment_ULO_6 { get; set; }
            public string Current_Accredited_Assessment_ULO_7 { get; set; }

            public string Proposed_Assessment_Items_Description_1 { get; set; }
            public string Proposed_Assessment_Items_Description_2 { get; set; }
            public string Proposed_Assessment_Items_Description_3 { get; set; }
            public string Proposed_Assessment_Items_Description_4 { get; set; }
            public string Proposed_Assessment_Items_Description_5 { get; set; }
            public string Proposed_Assessment_Items_Description_6 { get; set; }
            public string Proposed_Assessment_Items_Description_7 { get; set; }

            public string Proposed_Assessment_Items_Percentage_1 { get; set; }
            public string Proposed_Assessment_Items_Percentage_2 { get; set; }
            public string Proposed_Assessment_Items_Percentage_3 { get; set; }
            public string Proposed_Assessment_Items_Percentage_4 { get; set; }
            public string Proposed_Assessment_Items_Percentage_5 { get; set; }
            public string Proposed_Assessment_Items_Percentage_6 { get; set; }
            public string Proposed_Assessment_Items_Percentage_7 { get; set; }

            public string Proposed_Assessment_Items_ULO_1 { get; set; }
            public string Proposed_Assessment_Items_ULO_2 { get; set; }
            public string Proposed_Assessment_Items_ULO_3 { get; set; }
            public string Proposed_Assessment_Items_ULO_4 { get; set; }
            public string Proposed_Assessment_Items_ULO_5 { get; set; }
            public string Proposed_Assessment_Items_ULO_6 { get; set; }
            public string Proposed_Assessment_Items_ULO_7 { get; set; }

            public string Is_This_Unit_Currently_Accredited { get; set; }
            public string Is_This_Unit_Required { get; set; }

            public string JustificatioRequestOutline { get; set; }
            public string DomesticStudentNumber { get; set; }
            public string InternationalStudentNumber { get; set; }

            public string ReviewedCoreCourseList { get; set; }
            public string ReviewedSpecialistElectiveCourseList { get; set; }
            public string Provide_Summary_If_Student_Consultation_Was_Undertaken { get; set; }
            public string Provide_Summary_If_The_Proposed_Change_Response_To_Student { get; set; }
            public string Summary_Of_Consultation_With_Impacted_College { get; set; }

            public string UnitCoordinator { get; set; }
            public string FeedbackByUC { get; set; }

            public string CourseCoordinator { get; set; }
            public string AssignedCourseCoordinator { get; set; }
            public string FeedbackByCC { get; set; }

            public string Admin { get; set; }
            public string AssignedAdmin { get; set; }

            public string Reviewer1 { get; set; }
            public string FeedbackByReviewer1 { get; set; }
            public string AssignedReviewer1 { get; set; }
            public bool IsReviewedByReviewer1 { get; set; }

            public string Reviewer2 { get; set; }
            public string FeedbackByReviewer2 { get; set; }
            public string AssignedReviewer2 { get; set; }
            public bool IsReviewedByReviewer2 { get; set; }

            public string Approver { get; set; }
            public string FeedbackByApprover { get; set; }
            public string AssignedApprover { get; set; }

            public string CreatedBy { get; set; }
            public DateTime CreatedDate { get; set; }

            public DateTime UpdatedDate { get; set; }
            public string UpdatedBy { get; set; }

            public string AssignedTo { get; set; }
            public string AssignedBy { get; set; }
            public DateTime AssignedDate { get; set; }


            public string Status { get; set; }
            public string ActivityLog { get; set; }
            public string CurrentPosition { get; set; }
            public DateTime OrderByDate { get; set; }
    }
}
