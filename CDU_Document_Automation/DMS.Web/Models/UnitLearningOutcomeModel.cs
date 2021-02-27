using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMS.Web.Models
{
    [Table("DMS_UNIT_LO")]
    public class UnitLearningOutcomeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ChangeRequest { get; set; }
        public string UnitCode { get; set; }
        public string UnitTitle { get; set; }
        public string CreditPoints { get; set; }
        public string Prerequisites { get; set; }
        public string Semester { get; set; }
        public string Year { get; set; }
        public string Mode { get; set; }
        public string Location { get; set; }
        public string LearningMethod { get; set; }
        
        public string Phone { get; set; }
        public string Email { get; set; }
        public string UnitDescription { get; set; }
        public string LearningOutComes { get; set; }


        public string Assessment_Overview_Item_1 { get; set; }
        public string Assessment_Overview_Description_1 { get; set; }
        public string Assessment_Overview_Value_1 { get; set; }
        public string Assessment_Overview_Learning_Outcome_1 { get; set; }
        public string Assessment_Overview_Item_2 { get; set; }
        public string Assessment_Overview_Description_2 { get; set; }
        public string Assessment_Overview_Value_2 { get; set; }
        public string Assessment_Overview_Learning_Outcome_2 { get; set; }
        public string Assessment_Overview_Item_3 { get; set; }
        public string Assessment_Overview_Description_3 { get; set; }
        public string Assessment_Overview_Value_3 { get; set; }
        public string Assessment_Overview_Learning_Outcome_3 { get; set; }
        public string Assessment_Overview_Item_4 { get; set; }
        public string Assessment_Overview_Description_4 { get; set; }
        public string Assessment_Overview_Value_4 { get; set; }
        public string Assessment_Overview_Learning_Outcome_4 { get; set; }


        public string TeachingAndLearningApproach { get; set; }
        public string TeachingAndLearningApproach_HowUnitRun { get; set; }
        public string TeachingAndLearningApproach_LecturerRole { get; set; }
        public string TeachingAndLearningApproach_StudentParticipation { get; set; }


        public string Resources_RequiredTextbooks { get; set; }
        public string Resources_Learnline { get; set; }
        public string Resources_eReserveCourseReadings { get; set; }
        public string Resources_AdditionalResources { get; set; }



        public string LearningSchedule_Week_1 { get; set; }
        public string LearningSchedule_Topic_1 { get; set; }
        public string LearningSchedule_Tutorial_1 { get; set; }
        public string LearningSchedule_Assessments_1 { get; set; }

        public string LearningSchedule_Week_2 { get; set; }
        public string LearningSchedule_Topic_2 { get; set; }
        public string LearningSchedule_Tutorial_2 { get; set; }
        public string LearningSchedule_Assessments_2 { get; set; }

        public string LearningSchedule_Week_3 { get; set; }
        public string LearningSchedule_Topic_3 { get; set; }
        public string LearningSchedule_Tutorial_3 { get; set; }
        public string LearningSchedule_Assessments_3 { get; set; }

        public string LearningSchedule_Week_4 { get; set; }
        public string LearningSchedule_Topic_4 { get; set; }
        public string LearningSchedule_Tutorial_4 { get; set; }
        public string LearningSchedule_Assessments_4 { get; set; }

        public string LearningSchedule_Week_5 { get; set; }
        public string LearningSchedule_Topic_5 { get; set; }
        public string LearningSchedule_Tutorial_5 { get; set; }
        public string LearningSchedule_Assessments_5 { get; set; }

        public string LearningSchedule_Week_6 { get; set; }
        public string LearningSchedule_Topic_6 { get; set; }
        public string LearningSchedule_Tutorial_6 { get; set; }
        public string LearningSchedule_Assessments_6 { get; set; }

        public string LearningSchedule_Week_7 { get; set; }
        public string LearningSchedule_Topic_7 { get; set; }
        public string LearningSchedule_Tutorial_7 { get; set; }
        public string LearningSchedule_Assessments_7 { get; set; }

        public string LearningSchedule_Week_8 { get; set; }
        public string LearningSchedule_Topic_8 { get; set; }
        public string LearningSchedule_Tutorial_8 { get; set; }
        public string LearningSchedule_Assessments_8 { get; set; }

        public string LearningSchedule_Week_9 { get; set; }
        public string LearningSchedule_Topic_9 { get; set; }
        public string LearningSchedule_Tutorial_9 { get; set; }
        public string LearningSchedule_Assessments_9 { get; set; }

        public string LearningSchedule_Week_10 { get; set; }
        public string LearningSchedule_Topic_10 { get; set; }
        public string LearningSchedule_Tutorial_10 { get; set; }
        public string LearningSchedule_Assessments_10 { get; set; }

        public string LearningSchedule_Week_11 { get; set; }
        public string LearningSchedule_Topic_11 { get; set; }
        public string LearningSchedule_Tutorial_11 { get; set; }
        public string LearningSchedule_Assessments_11 { get; set; }

        public string LearningSchedule_Week_12 { get; set; }
        public string LearningSchedule_Topic_12 { get; set; }
        public string LearningSchedule_Tutorial_12 { get; set; }
        public string LearningSchedule_Assessments_12 { get; set; }

        public string LearningSchedule_Week_13 { get; set; }
        public string LearningSchedule_Topic_13 { get; set; }
        public string LearningSchedule_Tutorial_13 { get; set; }
        public string LearningSchedule_Assessments_13 { get; set; }

        public string LearningSchedule_Week_14 { get; set; }
        public string LearningSchedule_Topic_14 { get; set; }
        public string LearningSchedule_Tutorial_14 { get; set; }
        public string LearningSchedule_Assessments_14 { get; set; }

        public string LearningSchedule_Week_15 { get; set; }
        public string LearningSchedule_Topic_15 { get; set; }
        public string LearningSchedule_Tutorial_15 { get; set; }
        public string LearningSchedule_Assessments_15 { get; set; }

        public string UnitCoordinator { get; set; }
        public string FeedbackByUC { get; set; }

        public string CourseCoordinator { get; set; }
        public string AssignedCourseCoordinator { get; set; }
        public string FeedbackByCC { get; set; }


        public string Admin { get; set; }
        public string AssignedAdmin { get; set; }



        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedBy { get; set; }
        public DateTime AssignedDate { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }

        
        
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


        public string CurrentPosition { get; set; }

        public DateTime OrderByDate { get; set; }
    }
}
