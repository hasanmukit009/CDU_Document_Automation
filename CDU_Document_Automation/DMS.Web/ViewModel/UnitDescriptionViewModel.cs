using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Web.ViewModel
{
    public class UnitDescriptionViewModel
    {
        public string ChangeRequest { get; set; }
        public string UnitCode { get; set; }
        public string UnitTitle { get; set; }
        public string UnitLevel { get; set; }
        public string OwningCollege { get; set; }
        public string OwningDiscipline { get; set; }
        public string CoreCourseCode { get; set; }
        public string SpecialistElectiveCourseCode { get; set; }
        public string CurrentUnitDescription { get; set; }
        public string TypeOfChangeRequest { get; set; }
        public string ProposedUnitDescription { get; set; }
        public string JustificatioRequestOutline { get; set; }
        public string DomesticStudentNumber { get; set; }
        public string InternationalStudentNumber { get; set; }
        public string ObligationsDetails { get; set; }
        public string RemovalEffectDetails { get; set; }
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
