﻿// <auto-generated />
using System;
using DMS.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DMS.Web.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DMS.Web.Models.UnitInformationModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Admin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Approver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assessment_Overview_Description_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assessment_Overview_Description_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assessment_Overview_Description_3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assessment_Overview_Description_4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assessment_Overview_Item_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assessment_Overview_Item_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assessment_Overview_Item_3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assessment_Overview_Item_4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assessment_Overview_Learning_Outcome_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assessment_Overview_Learning_Outcome_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assessment_Overview_Learning_Outcome_3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assessment_Overview_Learning_Outcome_4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assessment_Overview_Value_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assessment_Overview_Value_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assessment_Overview_Value_3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assessment_Overview_Value_4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignedAdmin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignedApprover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignedCourseCoordinator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AssignedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AssignedReviewer1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignedReviewer2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignedTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChangeRequest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseCoordinator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreditPoints")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeedbackByApprover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeedbackByCC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeedbackByReviewer1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeedbackByReviewer2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsReviewedByReviewer1")
                        .HasColumnType("bit");

                    b.Property<bool>("IsReviewedByReviewer2")
                        .HasColumnType("bit");

                    b.Property<string>("LearningMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningOutComes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Assessments_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Assessments_10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Assessments_11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Assessments_12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Assessments_13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Assessments_14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Assessments_15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Assessments_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Assessments_3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Assessments_4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Assessments_5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Assessments_6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Assessments_7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Assessments_8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Assessments_9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Topic_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Topic_10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Topic_11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Topic_12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Topic_13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Topic_14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Topic_15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Topic_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Topic_3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Topic_4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Topic_5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Topic_6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Topic_7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Topic_8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Topic_9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Tutorial_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Tutorial_10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Tutorial_11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Tutorial_12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Tutorial_13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Tutorial_14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Tutorial_15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Tutorial_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Tutorial_3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Tutorial_4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Tutorial_5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Tutorial_6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Tutorial_7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Tutorial_8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Tutorial_9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Week_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Week_10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Week_11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Week_12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Week_13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Week_14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Week_15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Week_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Week_3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Week_4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Week_5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Week_6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Week_7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Week_8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningSchedule_Week_9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prerequisites")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resources_AdditionalResources")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resources_Learnline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resources_RequiredTextbooks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resources_eReserveCourseReadings")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reviewer1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reviewer2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Semester")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeachingAndLearningApproach")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeachingAndLearningApproach_HowUnitRun")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeachingAndLearningApproach_LecturerRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeachingAndLearningApproach_StudentParticipation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitCoordinator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DMS_UNIT_INFO");
                });

            modelBuilder.Entity("DMS.Web.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("UserType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VerficationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WrongAttempt")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DMS_USERS");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
