using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMS.Web.Models
{
    [Table("DMS_UNIT_INFO")]
    public class UnitInformationModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UnitCode { get; set; }
        public string UnitTitle { get; set; }
        public string CreditPoints { get; set; }
        public string Prerequisites { get; set; }
        public string Semester { get; set; }
        public string Year { get; set; }
        public string Mode { get; set; }
        public string Location { get; set; }
        public string LearningMethod { get; set; }
        public string UnitCoordinator { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string UnitDescription { get; set; }
        public string LearningOutComes { get; set; }
        public string AssessmentOverview { get; set; }
        public string TeachingAndLearningApproach_HowUnitRun{get;set;}
        public string TeachingAndLearningApproach_LecturerRole { get;set;}
        public string TeachingAndLearningApproach_StudentParticipation { get;set;}
        public string Resources_RequiredTextbooks { get; set; }
        public string Resources_Learnline { get; set; }
        public string Resources_eReserveCourseReadings { get; set; }
        public string Resources_AdditionalResources  { get; set; }
        public string LearningSchedule { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedBy { get; set; }
        public DateTime AssignedDate { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public string FeedbackByUC { get; set; }
        public string FeedbackByCC { get; set; }
        public string FeedbackByAdmin { get; set; }
        public string FeedbackByReviewer { get; set; }
        public string FeedbackByApprover { get; set; }
    }
}
