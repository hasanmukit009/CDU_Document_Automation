﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCore.Reporting;
using DMS.Web.Data;
using DMS.Web.Models;
using DMS.Web.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DMS.Web.Controllers
{
    public class UnitInfoController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly Microsoft.Extensions.Hosting.IHostingEnvironment _hostingEnvironment;
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly ApplicationDbContext _context;
        public UnitInfoController(Microsoft.Extensions.Hosting.IHostingEnvironment hostingEnvironment,ILogger<HomeController> logger, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            this.userManager = userManager;
            this.signInManager = signInManager;
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _hostingEnvironment = hostingEnvironment;
            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }


        /// <summary>
        /// Unit Coordinator
        /// </summary>
        /// <returns></returns>
        public IActionResult UnitInfoListUC()
        {

            var unitInformationList = _context.UnitInformationList.OrderByDescending(a => a.OrderByDate).Where(a => a.CurrentPosition == "UC").ToList().GroupBy(a => a.UnitCode);
            List<UnitInformationModel> lstUnitInfoList = UploadToNewList(unitInformationList);
            return View(lstUnitInfoList);
        }

        private List<UnitInformationModel> UploadToNewList(IEnumerable<IGrouping<string, UnitInformationModel>> unitInformationList)
        {
            List<UnitInformationModel> lstUnitInfoList = new List<UnitInformationModel>();
            foreach (var obj1 in unitInformationList)
            {
                foreach (var obj in obj1)
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

                    objnew.Phone = obj.Phone;
                    objnew.Email = obj.Email;
                    objnew.UnitDescription = obj.UnitDescription;
                    objnew.LearningOutComes = obj.LearningOutComes;

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

                    objnew.TeachingAndLearningApproach = obj.TeachingAndLearningApproach;
                    objnew.TeachingAndLearningApproach_HowUnitRun = obj.TeachingAndLearningApproach_HowUnitRun;
                    objnew.TeachingAndLearningApproach_LecturerRole = obj.TeachingAndLearningApproach_LecturerRole;
                    objnew.TeachingAndLearningApproach_StudentParticipation = obj.TeachingAndLearningApproach_StudentParticipation;

                    objnew.Resources_RequiredTextbooks = obj.Resources_RequiredTextbooks;
                    objnew.Resources_Learnline = obj.Resources_Learnline;
                    objnew.Resources_eReserveCourseReadings = obj.Resources_eReserveCourseReadings;
                    objnew.Resources_AdditionalResources = obj.Resources_AdditionalResources;

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

                    objnew.UnitCoordinator = obj.UnitCoordinator;
                    objnew.FeedbackByUC = obj.FeedbackByUC;

                    objnew.CourseCoordinator = obj.CourseCoordinator;
                    objnew.AssignedCourseCoordinator = obj.AssignedCourseCoordinator;
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
                    objnew.FeedbackByApprover = obj.FeedbackByApprover;

                    objnew.Approver = obj.Approver;
                    objnew.AssignedApprover = obj.AssignedApprover;

                    objnew.CurrentPosition = obj.CurrentPosition;
                    objnew.ChangeRequest = obj.ChangeRequest;

                    objnew.CreatedBy = obj.CreatedBy;
                    objnew.CreatedDate = obj.CreatedDate;
                    objnew.UpdatedDate = obj.UpdatedDate;
                    objnew.UpdatedBy = obj.UpdatedBy;
                    objnew.AssignedTo = obj.AssignedTo;
                    objnew.AssignedBy = obj.AssignedBy;
                    objnew.AssignedDate = obj.AssignedDate;

                    objnew.Status = obj.Status;
                    objnew.Remarks = obj.Remarks;
                    objnew.OrderByDate = obj.OrderByDate;

                    lstUnitInfoList.Add(objnew);
                }
            }
            return lstUnitInfoList;
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

        public IActionResult AddNewUnitInfo()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewUnitInfo(UnitInformationViewModel model)
        {
            if (ModelState.IsValid)
            {
                UnitInformationModel objUnitInformation = LoadUnitInformation(model);
                _context.Add(objUnitInformation);
                await _context.SaveChangesAsync();
                return RedirectToAction("UnitInfoListUC");
            }
            return View(model);
        }

        private UnitInformationModel LoadUnitInformation(UnitInformationViewModel model)
        {
            var obj = new UnitInformationModel
            {
                UnitCode = model.UnitCode,
                UnitTitle = model.UnitTitle,
                CreditPoints = model.CreditPoints,
                Prerequisites = model.Prerequisites,
                Semester = model.Semester,
                Year = model.Year,
                Mode = model.Mode,
                Location = model.Location,
                LearningMethod = model.LearningMethod,
                UnitCoordinator = User.Identity.Name,
                Phone = model.Phone,
                Email = model.Email,
                UnitDescription = model.UnitDescription,
                LearningOutComes = model.LearningOutComes,

                Assessment_Overview_Item_1 = model.Assessment_Overview_Item_1,
                Assessment_Overview_Description_1 = model.Assessment_Overview_Description_1,
                Assessment_Overview_Value_1 = model.Assessment_Overview_Value_1,
                Assessment_Overview_Learning_Outcome_1 = model.Assessment_Overview_Learning_Outcome_1,
                Assessment_Overview_Item_2 = model.Assessment_Overview_Item_2,
                Assessment_Overview_Description_2 = model.Assessment_Overview_Description_2,
                Assessment_Overview_Value_2 = model.Assessment_Overview_Value_2,
                Assessment_Overview_Learning_Outcome_2 = model.Assessment_Overview_Learning_Outcome_2,
                Assessment_Overview_Item_3 = model.Assessment_Overview_Item_3,
                Assessment_Overview_Description_3 = model.Assessment_Overview_Description_3,
                Assessment_Overview_Value_3 = model.Assessment_Overview_Value_3,
                Assessment_Overview_Learning_Outcome_3 = model.Assessment_Overview_Learning_Outcome_3,
                Assessment_Overview_Item_4 = model.Assessment_Overview_Item_4,
                Assessment_Overview_Description_4 = model.Assessment_Overview_Description_4,
                Assessment_Overview_Value_4 = model.Assessment_Overview_Value_4,
                Assessment_Overview_Learning_Outcome_4 = model.Assessment_Overview_Learning_Outcome_4,

                TeachingAndLearningApproach = model.TeachingAndLearningApproach,
                TeachingAndLearningApproach_HowUnitRun = model.TeachingAndLearningApproach_HowUnitRun,
                TeachingAndLearningApproach_LecturerRole = model.TeachingAndLearningApproach_LecturerRole,
                TeachingAndLearningApproach_StudentParticipation = model.TeachingAndLearningApproach_StudentParticipation,

                Resources_RequiredTextbooks = model.Resources_RequiredTextbooks,
                Resources_Learnline = model.Resources_Learnline,
                Resources_eReserveCourseReadings = model.Resources_eReserveCourseReadings,
                Resources_AdditionalResources = model.Resources_AdditionalResources,

                LearningSchedule_Week_1 = model.LearningSchedule_Week_1,
                LearningSchedule_Topic_1 = model.LearningSchedule_Topic_1,
                LearningSchedule_Tutorial_1 = model.LearningSchedule_Tutorial_1,
                LearningSchedule_Assessments_1 = model.LearningSchedule_Assessments_1,

                LearningSchedule_Week_2 = model.LearningSchedule_Week_2,
                LearningSchedule_Topic_2 = model.LearningSchedule_Topic_2,
                LearningSchedule_Tutorial_2 = model.LearningSchedule_Tutorial_2,
                LearningSchedule_Assessments_2 = model.LearningSchedule_Assessments_2,

                LearningSchedule_Week_3 = model.LearningSchedule_Week_3,
                LearningSchedule_Topic_3 = model.LearningSchedule_Topic_3,
                LearningSchedule_Tutorial_3 = model.LearningSchedule_Tutorial_3,
                LearningSchedule_Assessments_3 = model.LearningSchedule_Assessments_3,

                LearningSchedule_Week_4 = model.LearningSchedule_Week_4,
                LearningSchedule_Topic_4 = model.LearningSchedule_Topic_4,
                LearningSchedule_Tutorial_4 = model.LearningSchedule_Tutorial_4,
                LearningSchedule_Assessments_4 = model.LearningSchedule_Assessments_4,

                LearningSchedule_Week_5 = model.LearningSchedule_Week_5,
                LearningSchedule_Topic_5 = model.LearningSchedule_Topic_5,
                LearningSchedule_Tutorial_5 = model.LearningSchedule_Tutorial_5,
                LearningSchedule_Assessments_5 = model.LearningSchedule_Assessments_5,

                LearningSchedule_Week_6 = model.LearningSchedule_Week_6,
                LearningSchedule_Topic_6 = model.LearningSchedule_Topic_6,
                LearningSchedule_Tutorial_6 = model.LearningSchedule_Tutorial_6,
                LearningSchedule_Assessments_6 = model.LearningSchedule_Assessments_6,

                LearningSchedule_Week_7 = model.LearningSchedule_Week_7,
                LearningSchedule_Topic_7 = model.LearningSchedule_Topic_7,
                LearningSchedule_Tutorial_7 = model.LearningSchedule_Tutorial_7,
                LearningSchedule_Assessments_7 = model.LearningSchedule_Assessments_7,

                LearningSchedule_Week_8 = model.LearningSchedule_Week_8,
                LearningSchedule_Topic_8 = model.LearningSchedule_Topic_8,
                LearningSchedule_Tutorial_8 = model.LearningSchedule_Tutorial_8,
                LearningSchedule_Assessments_8 = model.LearningSchedule_Assessments_8,

                LearningSchedule_Week_9 = model.LearningSchedule_Week_9,
                LearningSchedule_Topic_9 = model.LearningSchedule_Topic_9,
                LearningSchedule_Tutorial_9 = model.LearningSchedule_Tutorial_9,
                LearningSchedule_Assessments_9 = model.LearningSchedule_Assessments_9,

                LearningSchedule_Week_10 = model.LearningSchedule_Week_10,
                LearningSchedule_Topic_10 = model.LearningSchedule_Topic_10,
                LearningSchedule_Tutorial_10 = model.LearningSchedule_Tutorial_10,
                LearningSchedule_Assessments_10 = model.LearningSchedule_Assessments_10,

                LearningSchedule_Week_11 = model.LearningSchedule_Week_11,
                LearningSchedule_Topic_11 = model.LearningSchedule_Topic_11,
                LearningSchedule_Tutorial_11 = model.LearningSchedule_Tutorial_11,
                LearningSchedule_Assessments_11 = model.LearningSchedule_Assessments_11,

                LearningSchedule_Week_12 = model.LearningSchedule_Week_12,
                LearningSchedule_Topic_12 = model.LearningSchedule_Topic_12,
                LearningSchedule_Tutorial_12 = model.LearningSchedule_Tutorial_12,
                LearningSchedule_Assessments_12 = model.LearningSchedule_Assessments_12,

                LearningSchedule_Week_13 = model.LearningSchedule_Week_13,
                LearningSchedule_Topic_13 = model.LearningSchedule_Topic_13,
                LearningSchedule_Tutorial_13 = model.LearningSchedule_Tutorial_13,
                LearningSchedule_Assessments_13 = model.LearningSchedule_Assessments_13,

                LearningSchedule_Week_14 = model.LearningSchedule_Week_14,
                LearningSchedule_Topic_14 = model.LearningSchedule_Topic_14,
                LearningSchedule_Tutorial_14 = model.LearningSchedule_Tutorial_14,
                LearningSchedule_Assessments_14 = model.LearningSchedule_Assessments_14,

                LearningSchedule_Week_15 = model.LearningSchedule_Week_15,
                LearningSchedule_Topic_15 = model.LearningSchedule_Topic_15,
                LearningSchedule_Tutorial_15 = model.LearningSchedule_Tutorial_15,
                LearningSchedule_Assessments_15 = model.LearningSchedule_Assessments_15,


                CourseCoordinator = model.CourseCoordinator,

                CreatedBy = User.Identity.Name,
                CreatedDate = DateTime.Now,
                Remarks = model.UnitCode + " " + model.UnitTitle + " has been created by UC- " + GetNameByEmail(User.Identity.Name),
                CurrentPosition = "UC",
                ChangeRequest = "Unit Info.",
                Status = "Created",
                OrderByDate = DateTime.Now
            };
            return obj;
        }

        public async Task<IActionResult> EditUnitInfoByUC(int id)
        {
            var objUnitInformation = await _context.UnitInformationList.FindAsync(id);
            return View(objUnitInformation);
        }

        [HttpPost]
        public async Task<IActionResult> EditUnitInfoByUC(UnitInformationModel model)
        {
            if (ModelState.IsValid)
            {
                model.OrderByDate = DateTime.Now;
                model.UpdatedBy = User.Identity.Name;
                model.UpdatedDate = DateTime.Now;
                model.Remarks = model.UnitCode + " " + model.UnitTitle + " has been updated by UC- " + GetNameByEmail(model.UnitCoordinator);
                _context.Update(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("UnitInfoListUC");
            }
            return View(model);
        }

        public async Task<IActionResult> AssignToCourseCoordinatorAsync(int id)
        {
            var objUnitInformation = _context.UnitInformationList.Find(id);
            if (objUnitInformation != null)
            {
                objUnitInformation.UpdatedBy = User.Identity.Name;
                objUnitInformation.UpdatedDate = DateTime.Now;
                objUnitInformation.AssignedTo = objUnitInformation.CourseCoordinator;
                objUnitInformation.AssignedBy = User.Identity.Name;
                objUnitInformation.AssignedDate = DateTime.Now;
                objUnitInformation.AssignedCourseCoordinator = objUnitInformation.CourseCoordinator;

                objUnitInformation.CurrentPosition = "CC";
                objUnitInformation.Status = "Pending";

                objUnitInformation.Remarks = objUnitInformation.UnitCode + " " + objUnitInformation.UnitTitle + " has been assigned to CC- " + GetNameByEmail(objUnitInformation.AssignedCourseCoordinator);

                objUnitInformation.OrderByDate = DateTime.Now;
                _context.Update(objUnitInformation);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("DashBoard", "Home");
        }

        public async Task<IActionResult> ApproveUnitInfoByUC(int id)
        {
            var objUnitInformation = _context.UnitInformationList.Find(id);
            if (objUnitInformation != null)
            {
                objUnitInformation.UpdatedBy = User.Identity.Name;
                objUnitInformation.UpdatedDate = DateTime.Now;
                objUnitInformation.CurrentPosition = "UC";
                objUnitInformation.Status = "Approved";

                objUnitInformation.Remarks = objUnitInformation.UnitCode + " " + objUnitInformation.UnitTitle + " has been approved by UC- " + GetNameByEmail(objUnitInformation.UnitCoordinator) + " with minor changes.";
                objUnitInformation.OrderByDate = DateTime.Now;
                _context.Update(objUnitInformation);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("UnitInfoListUC");
        }

        public async Task<IActionResult> ViewUnitInfoByUC(int id)
        {
            var objUnitInformation = await _context.UnitInformationList.FindAsync(id);
            return View(objUnitInformation);
        }

        public JsonResult RemoveUnitInfoByUC(int id)
        {
            var objUnitInformation = _context.UnitInformationList.Find(id);
            _context.Remove(objUnitInformation);
            _context.SaveChanges();
            return Json(new { status = "Success" });
        }

        public IActionResult DownloadUnitInfo(int id)
        {
           string p= _hostingEnvironment.ContentRootPath;
            string mimtype = "";
            int extension = 1;
            var path = $"{_hostingEnvironment.ContentRootPath}\\Reports\\report_UnitInformation.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            var objUnitInformation = _context.UnitInformationList.FindAsync(id);
            parameters.Add("rp_unitcode", objUnitInformation.Result.UnitCode);
            parameters.Add("rp_unitTitle", objUnitInformation.Result.UnitTitle);
            parameters.Add("rp_creditPoints", objUnitInformation.Result.CreditPoints);
            parameters.Add("rp_prerequisites", objUnitInformation.Result.Prerequisites);
            parameters.Add("rp_semester", objUnitInformation.Result.Semester);
            parameters.Add("rp_year", objUnitInformation.Result.Year);
            parameters.Add("rp_Mode", objUnitInformation.Result.Mode);
            parameters.Add("rp_Location", objUnitInformation.Result.Location);
            parameters.Add("rp_LearningMethod", objUnitInformation.Result.LearningMethod);
            parameters.Add("rp_unitCoordinator", objUnitInformation.Result.UnitCoordinator);
            parameters.Add("rp_phone", objUnitInformation.Result.Phone);
            parameters.Add("rp_Email", objUnitInformation.Result.Email);
            parameters.Add("rp_UnitDescription", objUnitInformation.Result.UnitDescription);
            parameters.Add("rp_LearningOutcomes", objUnitInformation.Result.LearningOutComes);
            parameters.Add("rp_Assessment_Overview_Item_1", objUnitInformation.Result.Assessment_Overview_Item_1);
            parameters.Add("rp_Assessment_Overview_Item_2", objUnitInformation.Result.Assessment_Overview_Item_2);
            parameters.Add("rp_Assessment_Overview_Item_3", objUnitInformation.Result.Assessment_Overview_Item_3);
            parameters.Add("rp_Assessment_Overview_Item_4", objUnitInformation.Result.Assessment_Overview_Item_4);
            parameters.Add("rp_Assessment_Overview_Description_1", objUnitInformation.Result.Assessment_Overview_Description_1);
            parameters.Add("rp_Assessment_Overview_Description_2", objUnitInformation.Result.Assessment_Overview_Description_2);
            parameters.Add("rp_Assessment_Overview_Description_3", objUnitInformation.Result.Assessment_Overview_Description_3);
            parameters.Add("rp_Assessment_Overview_Description_4", objUnitInformation.Result.Assessment_Overview_Description_4);
            parameters.Add("rp_Assessment_Overview_Value_1", objUnitInformation.Result.Assessment_Overview_Value_1);
            parameters.Add("rp_Assessment_Overview_Value_2", objUnitInformation.Result.Assessment_Overview_Value_2);
            parameters.Add("rp_Assessment_Overview_Value_3", objUnitInformation.Result.Assessment_Overview_Value_3);
            parameters.Add("rp_Assessment_Overview_Value_4", objUnitInformation.Result.Assessment_Overview_Value_4);
            parameters.Add("rp_Assessment_Overview_Learning_Outcome_1", objUnitInformation.Result.Assessment_Overview_Learning_Outcome_1);
            parameters.Add("rp_Assessment_Overview_Learning_Outcome_2", objUnitInformation.Result.Assessment_Overview_Learning_Outcome_2);
            parameters.Add("rp_Assessment_Overview_Learning_Outcome_3", objUnitInformation.Result.Assessment_Overview_Learning_Outcome_3);
            parameters.Add("rp_Assessment_Overview_Learning_Outcome_4", objUnitInformation.Result.Assessment_Overview_Learning_Outcome_4);


            parameters.Add("rp_TeachingAndLearningApproach", objUnitInformation.Result.TeachingAndLearningApproach);
            parameters.Add("rp_TeachingAndLearningApproach_HowUnitRun", objUnitInformation.Result.TeachingAndLearningApproach_HowUnitRun);
            parameters.Add("rp_TeachingAndLearningApproach_LecturerRole", objUnitInformation.Result.TeachingAndLearningApproach_LecturerRole);
            parameters.Add("rp_TeachingAndLearningApproach_StudentParticipation", objUnitInformation.Result.TeachingAndLearningApproach_StudentParticipation);

            parameters.Add("rp_Resources_AdditionalResources", objUnitInformation.Result.Resources_AdditionalResources);
            parameters.Add("rp_Resources_eReserveCourseReadings", objUnitInformation.Result.Resources_eReserveCourseReadings);
            parameters.Add("rp_Resources_Learnline", objUnitInformation.Result.Resources_Learnline);
            parameters.Add("rp_Resources_RequiredTextbooks", objUnitInformation.Result.Resources_RequiredTextbooks);

            parameters.Add("rp_LearningSchedule_Week_1", objUnitInformation.Result.LearningSchedule_Week_1);
            parameters.Add("rp_LearningSchedule_Week_2", objUnitInformation.Result.LearningSchedule_Week_2);
            parameters.Add("rp_LearningSchedule_Week_3", objUnitInformation.Result.LearningSchedule_Week_3);
            parameters.Add("rp_LearningSchedule_Week_4", objUnitInformation.Result.LearningSchedule_Week_4);
            parameters.Add("rp_LearningSchedule_Week_5", objUnitInformation.Result.LearningSchedule_Week_5);
            parameters.Add("rp_LearningSchedule_Week_6", objUnitInformation.Result.LearningSchedule_Week_6);
            parameters.Add("rp_LearningSchedule_Week_7", objUnitInformation.Result.LearningSchedule_Week_7);
            parameters.Add("rp_LearningSchedule_Week_8", objUnitInformation.Result.LearningSchedule_Week_8);
            parameters.Add("rp_LearningSchedule_Week_9", objUnitInformation.Result.LearningSchedule_Week_9);
            parameters.Add("rp_LearningSchedule_Week_10", objUnitInformation.Result.LearningSchedule_Week_10);
            parameters.Add("rp_LearningSchedule_Week_11", objUnitInformation.Result.LearningSchedule_Week_11);
            parameters.Add("rp_LearningSchedule_Week_12", objUnitInformation.Result.LearningSchedule_Week_12);
            parameters.Add("rp_LearningSchedule_Week_13", objUnitInformation.Result.LearningSchedule_Week_13);
            parameters.Add("rp_LearningSchedule_Week_14", objUnitInformation.Result.LearningSchedule_Week_14);
            parameters.Add("rp_LearningSchedule_Week_15", objUnitInformation.Result.LearningSchedule_Week_15);

            parameters.Add("rp_LearningSchedule_Topic_1", objUnitInformation.Result.LearningSchedule_Topic_1);
            parameters.Add("rp_LearningSchedule_Topic_2", objUnitInformation.Result.LearningSchedule_Topic_2);
            parameters.Add("rp_LearningSchedule_Topic_3", objUnitInformation.Result.LearningSchedule_Topic_3);
            parameters.Add("rp_LearningSchedule_Topic_4", objUnitInformation.Result.LearningSchedule_Topic_4);
            parameters.Add("rp_LearningSchedule_Topic_5", objUnitInformation.Result.LearningSchedule_Topic_5);
            parameters.Add("rp_LearningSchedule_Topic_6", objUnitInformation.Result.LearningSchedule_Topic_6);
            parameters.Add("rp_LearningSchedule_Topic_7", objUnitInformation.Result.LearningSchedule_Topic_7);
            parameters.Add("rp_LearningSchedule_Topic_8", objUnitInformation.Result.LearningSchedule_Topic_8);
            parameters.Add("rp_LearningSchedule_Topic_9", objUnitInformation.Result.LearningSchedule_Topic_9);
            parameters.Add("rp_LearningSchedule_Topic_10", objUnitInformation.Result.LearningSchedule_Topic_10);
            parameters.Add("rp_LearningSchedule_Topic_11", objUnitInformation.Result.LearningSchedule_Topic_11);
            parameters.Add("rp_LearningSchedule_Topic_12", objUnitInformation.Result.LearningSchedule_Topic_12);
            parameters.Add("rp_LearningSchedule_Topic_13", objUnitInformation.Result.LearningSchedule_Topic_13);
            parameters.Add("rp_LearningSchedule_Topic_14", objUnitInformation.Result.LearningSchedule_Topic_14);
            parameters.Add("rp_LearningSchedule_Topic_15", objUnitInformation.Result.LearningSchedule_Topic_15);

            parameters.Add("rp_LearningSchedule_Tutorial_1", objUnitInformation.Result.LearningSchedule_Tutorial_1);
            parameters.Add("rp_LearningSchedule_Tutorial_2", objUnitInformation.Result.LearningSchedule_Tutorial_2);
            parameters.Add("rp_LearningSchedule_Tutorial_3", objUnitInformation.Result.LearningSchedule_Tutorial_3);
            parameters.Add("rp_LearningSchedule_Tutorial_4", objUnitInformation.Result.LearningSchedule_Tutorial_4);
            parameters.Add("rp_LearningSchedule_Tutorial_5", objUnitInformation.Result.LearningSchedule_Tutorial_5);
            parameters.Add("rp_LearningSchedule_Tutorial_6", objUnitInformation.Result.LearningSchedule_Tutorial_6);
            parameters.Add("rp_LearningSchedule_Tutorial_7", objUnitInformation.Result.LearningSchedule_Tutorial_7);
            parameters.Add("rp_LearningSchedule_Tutorial_8", objUnitInformation.Result.LearningSchedule_Tutorial_8);
            parameters.Add("rp_LearningSchedule_Tutorial_9", objUnitInformation.Result.LearningSchedule_Tutorial_9);
            parameters.Add("rp_LearningSchedule_Tutorial_10", objUnitInformation.Result.LearningSchedule_Tutorial_10);
            parameters.Add("rp_LearningSchedule_Tutorial_11", objUnitInformation.Result.LearningSchedule_Tutorial_11);
            parameters.Add("rp_LearningSchedule_Tutorial_12", objUnitInformation.Result.LearningSchedule_Tutorial_12);
            parameters.Add("rp_LearningSchedule_Tutorial_13", objUnitInformation.Result.LearningSchedule_Tutorial_13);
            parameters.Add("rp_LearningSchedule_Tutorial_14", objUnitInformation.Result.LearningSchedule_Tutorial_14);
            parameters.Add("rp_LearningSchedule_Tutorial_15", objUnitInformation.Result.LearningSchedule_Tutorial_15);


            parameters.Add("rp_LearningSchedule_Assessments_1", objUnitInformation.Result.LearningSchedule_Assessments_1);
            parameters.Add("rp_LearningSchedule_Assessments_2", objUnitInformation.Result.LearningSchedule_Assessments_2);
            parameters.Add("rp_LearningSchedule_Assessments_3", objUnitInformation.Result.LearningSchedule_Assessments_3);
            parameters.Add("rp_LearningSchedule_Assessments_4", objUnitInformation.Result.LearningSchedule_Assessments_4);
            parameters.Add("rp_LearningSchedule_Assessments_5", objUnitInformation.Result.LearningSchedule_Assessments_5);
            parameters.Add("rp_LearningSchedule_Assessments_6", objUnitInformation.Result.LearningSchedule_Assessments_6);
            parameters.Add("rp_LearningSchedule_Assessments_7", objUnitInformation.Result.LearningSchedule_Assessments_7);
            parameters.Add("rp_LearningSchedule_Assessments_8", objUnitInformation.Result.LearningSchedule_Assessments_8);
            parameters.Add("rp_LearningSchedule_Assessments_9", objUnitInformation.Result.LearningSchedule_Assessments_9);
            parameters.Add("rp_LearningSchedule_Assessments_10", objUnitInformation.Result.LearningSchedule_Assessments_10);
            parameters.Add("rp_LearningSchedule_Assessments_11", objUnitInformation.Result.LearningSchedule_Assessments_11);
            parameters.Add("rp_LearningSchedule_Assessments_12", objUnitInformation.Result.LearningSchedule_Assessments_12);
            parameters.Add("rp_LearningSchedule_Assessments_13", objUnitInformation.Result.LearningSchedule_Assessments_13);
            parameters.Add("rp_LearningSchedule_Assessments_14", objUnitInformation.Result.LearningSchedule_Assessments_14);
            parameters.Add("rp_LearningSchedule_Assessments_15", objUnitInformation.Result.LearningSchedule_Assessments_15);


            LocalReport localReport = new LocalReport(path);
            var result = localReport.Execute(RenderType.Pdf, extension, parameters, mimtype);
            return File(result.MainStream, "application/pdf");
        }



        /// <summary>
        /// Course Coordinator
        /// </summary>
        /// <returns></returns>
        public IActionResult UnitInfoListCC()
        {
            var unitInformationList = _context.UnitInformationList.OrderByDescending(a => a.OrderByDate).Where(a => a.Status == "Pending" && a.CurrentPosition == "CC").ToList().GroupBy(a => a.UnitCode);
            List<UnitInformationModel> lstUnitInfoList = UploadToNewList(unitInformationList);
            return View(lstUnitInfoList);
        }

        public async Task<IActionResult> ViewUnitInformationByCC(int id)
        {
            var objUnitInformation = await _context.UnitInformationList.FindAsync(id);
            return View(objUnitInformation);
        }

        [HttpGet]
        public async Task<IActionResult> EditUnitInformationByCC(int id)
        {
            var objUnitInformation = await _context.UnitInformationList.FindAsync(id);
            return View(objUnitInformation);
        }

        [HttpPost]
        public async Task<IActionResult> EditUnitInformationByCC(UnitInformationModel model)
        {
            if (ModelState.IsValid)
            {
                model.UpdatedBy = User.Identity.Name;
                model.UpdatedDate = DateTime.Now;
                model.Remarks = model.UnitCode + " - " + model.UnitTitle + " has been updated by CC- " + GetNameByEmail(model.AssignedCourseCoordinator);
                model.OrderByDate = DateTime.Now;
                _context.Update(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("UnitInfoListCC");
            }
            return View(model);
        }

        public async Task<IActionResult> ReturnCCToUC(int id)
        {
            var objUnitInformation = await _context.UnitInformationList.FindAsync(id);
            objUnitInformation.AssignedTo = objUnitInformation.UnitCoordinator;
            objUnitInformation.AssignedBy = User.Identity.Name;
            objUnitInformation.AssignedDate = DateTime.Now;
            objUnitInformation.CurrentPosition = "UC";
            objUnitInformation.Remarks = "CC- " + GetNameByEmail(objUnitInformation.AssignedCourseCoordinator) + " has returned the Unit- " + objUnitInformation.UnitCode + " " + objUnitInformation.UnitTitle + " to UC- " + GetNameByEmail(objUnitInformation.UnitCoordinator);
            objUnitInformation.AssignedCourseCoordinator = null;
            objUnitInformation.OrderByDate = DateTime.Now;
            _context.Update(objUnitInformation);
            await _context.SaveChangesAsync();
            return RedirectToAction("DashBoard", "Home");
        }

        public async Task<IActionResult> AssignToAdmin(int id)
        {
            var objUnitInformation = await _context.UnitInformationList.FindAsync(id);
            objUnitInformation.AssignedTo = objUnitInformation.Admin;
            objUnitInformation.AssignedBy = User.Identity.Name;
            objUnitInformation.AssignedDate = DateTime.Now;
            objUnitInformation.CurrentPosition = "Admin";
            objUnitInformation.Status = "Pending";
            objUnitInformation.AssignedAdmin = objUnitInformation.Admin;
            objUnitInformation.Remarks = objUnitInformation.UnitCode + " - " + objUnitInformation.UnitTitle + " has been assigned to Admin- " + GetNameByEmail(objUnitInformation.AssignedAdmin);
            objUnitInformation.OrderByDate = DateTime.Now;
            _context.Update(objUnitInformation);
            await _context.SaveChangesAsync();
            return RedirectToAction("DashBoard", "Home");
        }







        /// <summary>
        /// Admin
        /// </summary>
        /// <returns></returns>
        public IActionResult UnitInfoListAdmin()
        {
            var unitInformationList = _context.UnitInformationList.OrderByDescending(a => a.OrderByDate).Where(a => a.Status == "Pending" && a.CurrentPosition == "Admin").ToList().GroupBy(a => a.UnitCode);
            List<UnitInformationModel> lstUnitInfoList = UploadToNewList(unitInformationList);
            return View(lstUnitInfoList);
        }

        public async Task<IActionResult> AssignToReviewer(int id)
        {
            var objUnitInformation = await _context.UnitInformationList.FindAsync(id);
            objUnitInformation.AssignedTo = objUnitInformation.Reviewer1;
            objUnitInformation.AssignedBy = User.Identity.Name;
            objUnitInformation.AssignedDate = DateTime.Now;

            objUnitInformation.UpdatedDate = DateTime.Now;
            objUnitInformation.UpdatedBy = User.Identity.Name;

            objUnitInformation.AssignedReviewer1 = objUnitInformation.Reviewer1;
            objUnitInformation.IsReviewedByReviewer1 = false;
            objUnitInformation.AssignedReviewer2 = objUnitInformation.Reviewer2;
            objUnitInformation.IsReviewedByReviewer2 = false;

            objUnitInformation.CurrentPosition = "Reviewer";
            objUnitInformation.Remarks = objUnitInformation.UnitCode + " - " + objUnitInformation.UnitTitle + " has been assigned to Reviewer 1 - " + GetNameByEmail(objUnitInformation.AssignedReviewer1) + " and Reviewer2 - " + GetNameByEmail(objUnitInformation.AssignedReviewer2);

            objUnitInformation.OrderByDate = DateTime.Now;
            _context.Update(objUnitInformation);
            await _context.SaveChangesAsync();
            return RedirectToAction("DashBoard", "Home");
        }

        public async Task<IActionResult> ViewUnitInformationByAdmin(int id)
        {
            var objUnitInformation = await _context.UnitInformationList.FindAsync(id);
            return View(objUnitInformation);
        }

        [HttpPost]
        public async Task<IActionResult> ViewUnitInformationByAdmin(UnitInformationModel model)
        {
            if (ModelState.IsValid)
            {
                model.UpdatedBy = User.Identity.Name;
                model.UpdatedDate = DateTime.Now;
                model.Remarks = "Admin - " + GetNameByEmail(model.AssignedAdmin) + " has reviewed Unit- " + model.UnitCode + model.UnitTitle;
                model.OrderByDate = DateTime.Now;
                _context.Update(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("UnitInfoListAdmin");
            }
            return View(model);
        }

        public async Task<IActionResult> EditUnitInformationByAdmin(int id)
        {
            var objUnitInformation = await _context.UnitInformationList.FindAsync(id);
            return View(objUnitInformation);
        }
        [HttpPost]
        public async Task<IActionResult> EditUnitInformationByAdmin(UnitInformationModel model)
        {
            if (ModelState.IsValid)
            {
                model.UpdatedBy = User.Identity.Name;
                model.UpdatedDate = DateTime.Now;
                model.Remarks = model.UnitCode + " - " + model.UnitTitle + " has been updated by Admin- " + GetNameByEmail(model.AssignedAdmin);
                model.OrderByDate = DateTime.Now;
                _context.Update(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("UnitInfoListAdmin");
            }
            return View(model);
        }

        /// <summary>
        /// Reviewer
        /// </summary>
        /// <returns></returns>
        public IActionResult UnitInfoListReviewer()
        {
            var unitInformationList = _context.UnitInformationList.OrderByDescending(a => a.OrderByDate).Where(a => a.Status == "Pending" && a.CurrentPosition == "Reviewer").ToList().GroupBy(a => a.UnitCode);
            List<UnitInformationModel> lstUnitInfoList = UploadToNewList(unitInformationList);
            return View(lstUnitInfoList);
        }

        public async Task<IActionResult> ViewUnitInformationByReviewer(int id)
        {
            var objUnitInformation = await _context.UnitInformationList.FindAsync(id);
            return View(objUnitInformation);
        }

        [HttpPost]
        public async Task<IActionResult> ViewUnitInformationByReviewer(UnitInformationModel model)
        {
            if (ModelState.IsValid)
            {
                if (User.Identity.Name == model.AssignedReviewer1)
                {
                    model.Approver = "stefanija@gmail.com";
                    model.UpdatedBy = User.Identity.Name;
                    model.UpdatedDate = DateTime.Now;
                    model.Remarks = "Reviewer1 - " + GetNameByEmail(model.AssignedReviewer1) + " reviewed unit- " + model.UnitCode + " " + model.UnitTitle;
                    model.IsReviewedByReviewer1 = true;
                    model.Status = "Pending";
                    model.OrderByDate = DateTime.Now;
                }
                if (User.Identity.Name == model.AssignedReviewer2)
                {
                    model.Approver = "stefanija@gmail.com";
                    model.UpdatedBy = User.Identity.Name;
                    model.UpdatedDate = DateTime.Now;
                    model.Remarks = "Reviewer2 - " + GetNameByEmail(model.AssignedReviewer2) + " reviewed unit- " + model.UnitCode + " " + model.UnitTitle;
                    model.IsReviewedByReviewer2 = true;
                    model.Status = "Pending";
                    model.OrderByDate = DateTime.Now;
                }
                if (model.IsReviewedByReviewer1 == true && model.IsReviewedByReviewer2 == true)
                {
                    model.Remarks = "Reviewer1 - " + GetNameByEmail(model.AssignedReviewer1) + " and " + "Reviewer2 - " + GetNameByEmail(model.AssignedReviewer2) + " reviewed unit-" + model.UnitCode + " " + model.UnitTitle;
                    model.OrderByDate = DateTime.Now;
                }

                _context.Update(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("UnitInfoListReviewer");
            }
            return View(model);
        }

        public async Task<IActionResult> EditUnitInformationByReviewer(int id)
        {
            var objUnitInformation = await _context.UnitInformationList.FindAsync(id);
            return View(objUnitInformation);
        }

        [HttpPost]
        public async Task<IActionResult> EditUnitInformationByReviewer(UnitInformationModel model)
        {
            if (ModelState.IsValid)
            {
                if (User.Identity.Name == model.AssignedReviewer1)
                {
                    model.Approver = "stefanija@gmail.com";
                    model.UpdatedBy = User.Identity.Name;
                    model.UpdatedDate = DateTime.Now;
                    model.Remarks = model.UnitCode + " - " + model.UnitTitle + " has been reviewed by Reviewer1 - " + GetNameByEmail(model.AssignedReviewer1);
                    model.IsReviewedByReviewer1 = true;
                    model.Status = "Pending";
                    model.OrderByDate = DateTime.Now;
                }
                if (User.Identity.Name == model.AssignedReviewer2)
                {
                    model.Approver = "stefanija@gmail.com";
                    model.UpdatedBy = User.Identity.Name;
                    model.UpdatedDate = DateTime.Now;
                    model.Remarks = model.UnitCode + " - " + model.UnitTitle + " has been reviewed by Reviewer2 - " + GetNameByEmail(model.AssignedReviewer2);
                    model.IsReviewedByReviewer2 = true;
                    model.Status = "Pending";
                    model.OrderByDate = DateTime.Now;
                }
                if (model.IsReviewedByReviewer1 == true && model.IsReviewedByReviewer2 == true)
                {
                    model.Remarks = model.UnitCode + " - " + model.UnitTitle + " has been reviewed by Reviewer1 - " + GetNameByEmail(model.AssignedReviewer1) + " and Reviewer2 -" + GetNameByEmail(model.AssignedReviewer2);
                    model.OrderByDate = DateTime.Now;
                }

                _context.Update(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("UnitInfoListReviewer");
            }
            return View(model);
        }


        public async Task<IActionResult> AssignToApprover(int id)
        {
            var objUnitInformation = await _context.UnitInformationList.FindAsync(id);
            objUnitInformation.AssignedTo = objUnitInformation.Approver;
            objUnitInformation.AssignedBy = User.Identity.Name;
            objUnitInformation.AssignedDate = DateTime.Now;
            objUnitInformation.UpdatedBy = User.Identity.Name;
            objUnitInformation.UpdatedDate = DateTime.Now;
            objUnitInformation.CurrentPosition = "Approver";
            objUnitInformation.AssignedApprover = objUnitInformation.Approver;
            objUnitInformation.Remarks = objUnitInformation.UnitCode + " - " + objUnitInformation.UnitTitle + " has been assigned to Approver - " + GetNameByEmail(objUnitInformation.AssignedApprover);
            objUnitInformation.OrderByDate = DateTime.Now;
            _context.Update(objUnitInformation);
            await _context.SaveChangesAsync();
            return RedirectToAction("DashBoard", "Home");
        }

        /// <summary>
        /// Approver
        /// </summary>
        /// <returns></returns>
        public IActionResult UnitInfoListApprover()
        {
            var unitInformationList = _context.UnitInformationList.OrderByDescending(a => a.OrderByDate).Where(a => a.Status == "Pending" && a.CurrentPosition == "Approver").ToList().GroupBy(a => a.UnitCode);
            List<UnitInformationModel> lstUnitInfoList = UploadToNewList(unitInformationList);
            return View(lstUnitInfoList);
        }

        public async Task<IActionResult> RejectWithMinorChangeFromApprover(int id)
        {
            var objUnitInformation = await _context.UnitInformationList.FindAsync(id);
            objUnitInformation.AssignedTo = objUnitInformation.UnitCoordinator;
            objUnitInformation.AssignedBy = objUnitInformation.AssignedApprover;
            objUnitInformation.AssignedDate = DateTime.Now;
            objUnitInformation.UpdatedBy = objUnitInformation.AssignedApprover;
            objUnitInformation.UpdatedDate = DateTime.Now;
            objUnitInformation.CurrentPosition = "UC";
            objUnitInformation.Remarks = "Approver- " + GetNameByEmail(objUnitInformation.AssignedApprover) + " rejected the unit -" + objUnitInformation.UnitCode + objUnitInformation.UnitTitle + " with minor changes.";
            objUnitInformation.Status = "Reject(Minor)";
            objUnitInformation.OrderByDate = DateTime.Now;
            _context.Update(objUnitInformation);
            await _context.SaveChangesAsync();

            return RedirectToAction("DashBoard", "Home");
        }

        public async Task<IActionResult> RejectWithMajorChangeFromApprover(int id)
        {
            var objUnitInformation = await _context.UnitInformationList.FindAsync(id);
            objUnitInformation.AssignedTo = objUnitInformation.UnitCoordinator;
            objUnitInformation.AssignedBy = objUnitInformation.AssignedApprover;
            objUnitInformation.AssignedDate = DateTime.Now;
            objUnitInformation.UpdatedBy = objUnitInformation.AssignedApprover;
            objUnitInformation.UpdatedDate = DateTime.Now;
            objUnitInformation.CurrentPosition = "UC";
            objUnitInformation.Remarks = "Approver - " + GetNameByEmail(objUnitInformation.AssignedApprover) + " rejected the unit -" + objUnitInformation.UnitCode + " " + objUnitInformation.UnitTitle + " with major changes.";
            objUnitInformation.AssignedApprover = null;
            objUnitInformation.AssignedReviewer1 = null;
            objUnitInformation.AssignedReviewer2 = null;
            objUnitInformation.AssignedAdmin = null;
            objUnitInformation.AssignedCourseCoordinator = null;
            objUnitInformation.Status = "Reject(Major)";
            objUnitInformation.OrderByDate = DateTime.Now;
            _context.Update(objUnitInformation);
            await _context.SaveChangesAsync();

            return RedirectToAction("DashBoard", "Home");
        }

        public async Task<IActionResult> Approve(int id)
        {
            var objUnitInformation = await _context.UnitInformationList.FindAsync(id);
            objUnitInformation.CurrentPosition = "UC";
            objUnitInformation.Status = "Approved";
            objUnitInformation.Remarks = "Approver - " + GetNameByEmail(objUnitInformation.AssignedApprover) + " approved the unit - " + objUnitInformation.UnitCode + " " + objUnitInformation.UnitTitle;
            objUnitInformation.OrderByDate = DateTime.Now;
            _context.Update(objUnitInformation);
            await _context.SaveChangesAsync();
            return RedirectToAction("DashBoard", "Home");
        }

        public async Task<IActionResult> ViewUnitInformationByApprover(int id)
        {
            var objUnitInformation = await _context.UnitInformationList.FindAsync(id);
            return View(objUnitInformation);
        }

        [HttpPost]
        public async Task<IActionResult> ViewUnitInformationByApprover(UnitInformationModel model)
        {
            if (ModelState.IsValid)
            {
                model.UpdatedBy = User.Identity.Name;
                model.UpdatedDate = DateTime.Now;
                model.Remarks = "Approver - " + GetNameByEmail(model.AssignedApprover) + " reviewed unit- " + model.UnitCode + " " + model.UnitTitle;
                model.OrderByDate = DateTime.Now;
                _context.Update(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("UnitInfoListApprover");
            }
            return View(model);
        }


    }
}