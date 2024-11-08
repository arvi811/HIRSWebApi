using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HRISbackend.Models;

public partial class Hris2024Context : DbContext
{
    public Hris2024Context(DbContextOptions<Hris2024Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Application> Application { get; set; }

    public virtual DbSet<Attachment> Attachment { get; set; }

    public virtual DbSet<Banner> Banner { get; set; }

    public virtual DbSet<Comment> Comment { get; set; }

    public virtual DbSet<EmailRecipient> EmailRecipient { get; set; }

    public virtual DbSet<Employee> Employee { get; set; }

    public virtual DbSet<InformationChangeShift> InformationChangeShift { get; set; }

    public virtual DbSet<InformationInfraction> InformationInfraction { get; set; }

    public virtual DbSet<InformationLate> InformationLate { get; set; }

    public virtual DbSet<InformationLeave> InformationLeave { get; set; }

    public virtual DbSet<InformationLeaveDateList> InformationLeaveDateList { get; set; }

    public virtual DbSet<InformationOverTime> InformationOverTime { get; set; }

    public virtual DbSet<SubTypeInfraction> SubTypeInfraction { get; set; }

    public virtual DbSet<TblUserLogin> TblUserLogin { get; set; }

    public virtual DbSet<TblUserLoginLog> TblUserLoginLog { get; set; }

    public virtual DbSet<TypeChangeShift> TypeChangeShift { get; set; }

    public virtual DbSet<TypeInfraction> TypeInfraction { get; set; }

    public virtual DbSet<TypeLeave> TypeLeave { get; set; }

    public virtual DbSet<TypeOverTime> TypeOverTime { get; set; }

    public virtual DbSet<ViewApplicationRecord> ViewApplicationRecord { get; set; }

    public virtual DbSet<ViewApplicationWithCombinedRequests> ViewApplicationWithCombinedRequests { get; set; }

    public virtual DbSet<ViewCombinedRequestsPerId> ViewCombinedRequestsPerId { get; set; }

    public virtual DbSet<ViewLeaveReport> ViewLeaveReport { get; set; }

    public virtual DbSet<ViewMyApplication> ViewMyApplication { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Application>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LeaveApplication");

            entity.Property(e => e.Applicant).HasMaxLength(50);
            entity.Property(e => e.ApplicationDate).HasPrecision(0);
            entity.Property(e => e.ApplicationId)
                .HasMaxLength(40)
                .HasColumnName("ApplicationID");
            entity.Property(e => e.ApplicationType).HasMaxLength(40);
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.HeadApprovedBy).HasMaxLength(50);
            entity.Property(e => e.HrapprovedBy)
                .HasMaxLength(50)
                .HasColumnName("HRApprovedBy");
            entity.Property(e => e.HrapprovedDate)
                .HasPrecision(0)
                .HasColumnName("HRApprovedDate");
            entity.Property(e => e.IsCancelled).HasColumnName("isCancelled");
            entity.Property(e => e.IsDirectToHr).HasColumnName("isDirectToHR");
            entity.Property(e => e.IsLeader).HasColumnName("isLeader");
            entity.Property(e => e.IsManager).HasColumnName("isManager");
            entity.Property(e => e.IsRead).HasColumnName("isRead");
            entity.Property(e => e.LeaderApprovedBy).HasMaxLength(50);
            entity.Property(e => e.LeaderApprovedDate).HasPrecision(0);
            entity.Property(e => e.Position).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(40);
            entity.Property(e => e.UpdateTime).HasPrecision(0);
        });

        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LeaveAttachment");

            entity.Property(e => e.ApplicationId)
                .HasMaxLength(40)
                .HasColumnName("ApplicationID");
            entity.Property(e => e.FileExtension).HasMaxLength(10);
            entity.Property(e => e.FileName).HasMaxLength(50);
            entity.Property(e => e.UploadedBy).HasMaxLength(50);
            entity.Property(e => e.UploadedDate).HasPrecision(0);
        });

        modelBuilder.Entity<Banner>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Imgfile).HasColumnName("imgfile");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LeaveComments");

            entity.Property(e => e.ApplicationId)
                .HasMaxLength(40)
                .HasColumnName("ApplicationID");
            entity.Property(e => e.Comment1).HasColumnName("Comment");
            entity.Property(e => e.Commentor).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(40);
        });

        modelBuilder.Entity<EmailRecipient>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.EmployeeName).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Position).HasMaxLength(20);
            entity.Property(e => e.Team).HasMaxLength(20);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC071F2F3308");

            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Position).HasMaxLength(50);
        });

        modelBuilder.Entity<InformationChangeShift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ChangeShiftInformation");

            entity.ToTable("Information_ChangeShift");

            entity.Property(e => e.ApplicationId)
                .HasMaxLength(40)
                .HasColumnName("ApplicationID");
            entity.Property(e => e.NewSchedule).HasMaxLength(40);
            entity.Property(e => e.OriginalSchedule).HasMaxLength(40);
            entity.Property(e => e.RequestId)
                .HasMaxLength(40)
                .HasColumnName("RequestID");
            entity.Property(e => e.RequestType).HasMaxLength(30);
        });

        modelBuilder.Entity<InformationInfraction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Informat__3214EC07B53CFF1C");

            entity.ToTable("Information_Infraction");

            entity.Property(e => e.ApplicationId)
                .HasMaxLength(40)
                .HasColumnName("ApplicationID");
            entity.Property(e => e.Issues).HasMaxLength(50);
            entity.Property(e => e.RequestId)
                .HasMaxLength(40)
                .HasColumnName("RequestID");
            entity.Property(e => e.RequestType).HasMaxLength(50);
        });

        modelBuilder.Entity<InformationLate>(entity =>
        {
            entity.ToTable("Information_Late");

            entity.Property(e => e.ApplicationId)
                .HasMaxLength(40)
                .HasColumnName("ApplicationID");
            entity.Property(e => e.IsExcusedHr)
                .HasMaxLength(15)
                .HasColumnName("isExcused_HR");
            entity.Property(e => e.IsExcusedLeader)
                .HasMaxLength(15)
                .HasColumnName("isExcused_Leader");
            entity.Property(e => e.IsExcusedManager)
                .HasMaxLength(15)
                .HasColumnName("isExcused_Manager");
            entity.Property(e => e.RequestId)
                .HasMaxLength(40)
                .HasColumnName("RequestID");
            entity.Property(e => e.TotalLateTime).HasPrecision(0);
        });

        modelBuilder.Entity<InformationLeave>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LeaveInformation");

            entity.ToTable("Information_Leave", tb => tb.HasTrigger("trg_insert_LeaveInformation"));

            entity.Property(e => e.ApplicationId)
                .HasMaxLength(40)
                .HasColumnName("ApplicationID");
            entity.Property(e => e.RequestId)
                .HasMaxLength(40)
                .HasColumnName("RequestID");
            entity.Property(e => e.RequestType).HasMaxLength(30);
        });

        modelBuilder.Entity<InformationLeaveDateList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LeaveInformationReport");

            entity.ToTable("Information_LeaveDateList");

            entity.Property(e => e.RequestId)
                .HasMaxLength(40)
                .HasColumnName("RequestID");
        });

        modelBuilder.Entity<InformationOverTime>(entity =>
        {
            entity.ToTable("Information_OverTime");

            entity.Property(e => e.ApplicationId)
                .HasMaxLength(40)
                .HasColumnName("ApplicationID");
            entity.Property(e => e.RequestId)
                .HasMaxLength(40)
                .HasColumnName("RequestID");
            entity.Property(e => e.RequestType).HasMaxLength(40);
            entity.Property(e => e.TotalHours).HasColumnType("decimal(5, 1)");
        });

        modelBuilder.Entity<SubTypeInfraction>(entity =>
        {
            entity.ToTable("SubType_Infraction");

            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.InfractionSubType).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
        });

        modelBuilder.Entity<TblUserLogin>(entity =>
        {
            entity.ToTable("tblUserLogin");

            entity.Property(e => e.Department).HasMaxLength(30);
            entity.Property(e => e.Password).HasMaxLength(30);
            entity.Property(e => e.Type).HasMaxLength(30);
            entity.Property(e => e.Username).HasMaxLength(30);
        });

        modelBuilder.Entity<TblUserLoginLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblUserL__3214EC0790F53A6A");

            entity.ToTable("tblUserLoginLog");

            entity.Property(e => e.Activity).HasMaxLength(30);
            entity.Property(e => e.IsLoggedin).HasColumnName("isLoggedin");
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.Username).HasMaxLength(20);
            entity.Property(e => e.Version).HasMaxLength(15);
        });

        modelBuilder.Entity<TypeChangeShift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ChangeShiftType");

            entity.ToTable("Type_ChangeShift");

            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.ChangeShiftType).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
        });

        modelBuilder.Entity<TypeInfraction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_NewType_Infraction");

            entity.ToTable("Type_Infraction");

            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.InfractionType).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
        });

        modelBuilder.Entity<TypeLeave>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LeaveType");

            entity.ToTable("Type_Leave");

            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.LeaveType).HasMaxLength(50);
        });

        modelBuilder.Entity<TypeOverTime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_OverTimeType");

            entity.ToTable("Type_OverTime");

            entity.Property(e => e.AddedBy).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.OverTimeType).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewApplicationRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ApplicationRecord");

            entity.Property(e => e.Applicant).HasMaxLength(50);
            entity.Property(e => e.ApplicationDate).HasPrecision(0);
            entity.Property(e => e.ApplicationId)
                .HasMaxLength(40)
                .HasColumnName("ApplicationID");
            entity.Property(e => e.ApplicationType).HasMaxLength(40);
            entity.Property(e => e.ChangeShiftNewSchedule)
                .HasMaxLength(40)
                .HasColumnName("ChangeShift_NewSchedule");
            entity.Property(e => e.ChangeShiftOriginalSchedule)
                .HasMaxLength(40)
                .HasColumnName("ChangeShift_OriginalSchedule");
            entity.Property(e => e.ChangeShiftShiftDate).HasColumnName("ChangeShift_ShiftDate");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.HeadApprovedBy).HasMaxLength(50);
            entity.Property(e => e.HrapprovedBy)
                .HasMaxLength(50)
                .HasColumnName("HRApprovedBy");
            entity.Property(e => e.HrapprovedDate)
                .HasPrecision(0)
                .HasColumnName("HRApprovedDate");
            entity.Property(e => e.InfractionActualInOut).HasColumnName("Infraction_ActualInOut");
            entity.Property(e => e.InfractionIssues)
                .HasMaxLength(50)
                .HasColumnName("Infraction_Issues");
            entity.Property(e => e.InfractionScheduledInOut).HasColumnName("Infraction_ScheduledInOut");
            entity.Property(e => e.InfractionShiftDate).HasColumnName("Infraction_ShiftDate");
            entity.Property(e => e.InfractionSystemInOut).HasColumnName("Infraction_SystemInOut");
            entity.Property(e => e.LateActualTimeIn).HasColumnName("Late_ActualTimeIn");
            entity.Property(e => e.LateIsExcusedHr)
                .HasMaxLength(15)
                .HasColumnName("Late_isExcusedHR");
            entity.Property(e => e.LateIsExcusedLeader)
                .HasMaxLength(15)
                .HasColumnName("Late_isExcusedLeader");
            entity.Property(e => e.LateIsExcusedManager)
                .HasMaxLength(15)
                .HasColumnName("Late_isExcusedManager");
            entity.Property(e => e.LateOriginalSchedule).HasColumnName("Late_OriginalSchedule");
            entity.Property(e => e.LateTotalLateTime)
                .HasPrecision(0)
                .HasColumnName("Late_TotalLateTime");
            entity.Property(e => e.LeaderApprovedBy).HasMaxLength(50);
            entity.Property(e => e.LeaderApprovedDate).HasPrecision(0);
            entity.Property(e => e.LeaveEndDate).HasColumnName("Leave_EndDate");
            entity.Property(e => e.LeaveNoOfDays).HasColumnName("Leave_NoOfDays");
            entity.Property(e => e.LeaveStartDate).HasColumnName("Leave_StartDate");
            entity.Property(e => e.OverTimeEndTime).HasColumnName("OverTime_EndTime");
            entity.Property(e => e.OverTimeShiftDate).HasColumnName("OverTime_ShiftDate");
            entity.Property(e => e.OverTimeStartTime).HasColumnName("OverTime_StartTime");
            entity.Property(e => e.OverTimeTotalHours)
                .HasColumnType("decimal(5, 1)")
                .HasColumnName("OverTime_TotalHours");
            entity.Property(e => e.Position).HasMaxLength(50);
            entity.Property(e => e.RequestType).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(40);
            entity.Property(e => e.UpdateTime).HasPrecision(0);
        });

        modelBuilder.Entity<ViewApplicationWithCombinedRequests>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ApplicationWithCombinedRequests");

            entity.Property(e => e.Applicant).HasMaxLength(50);
            entity.Property(e => e.ApplicationDate).HasPrecision(0);
            entity.Property(e => e.ApplicationId)
                .HasMaxLength(40)
                .HasColumnName("ApplicationID");
            entity.Property(e => e.ApplicationType).HasMaxLength(40);
            entity.Property(e => e.CombinedRequests).HasMaxLength(4000);
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.HeadApprovedBy).HasMaxLength(50);
            entity.Property(e => e.IsCancelled).HasColumnName("isCancelled");
            entity.Property(e => e.LeaderApprovedBy).HasMaxLength(50);
            entity.Property(e => e.LeaderApprovedDate).HasPrecision(0);
            entity.Property(e => e.Status).HasMaxLength(40);
        });

        modelBuilder.Entity<ViewCombinedRequestsPerId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_CombinedRequestsPerId");

            entity.Property(e => e.ApplicationId)
                .HasMaxLength(40)
                .HasColumnName("ApplicationID");
            entity.Property(e => e.CombinedRequests).HasMaxLength(4000);
        });

        modelBuilder.Entity<ViewLeaveReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_LeaveReport");

            entity.Property(e => e.Applicant).HasMaxLength(50);
            entity.Property(e => e.ApplicationDate).HasPrecision(0);
            entity.Property(e => e.ApplicationId)
                .HasMaxLength(40)
                .HasColumnName("ApplicationID");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.Position).HasMaxLength(50);
            entity.Property(e => e.RequestType).HasMaxLength(30);
            entity.Property(e => e.Status).HasMaxLength(40);
        });

        modelBuilder.Entity<ViewMyApplication>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MyApplication");

            entity.Property(e => e.Applicant).HasMaxLength(50);
            entity.Property(e => e.ApplicationDate).HasPrecision(0);
            entity.Property(e => e.ApplicationId)
                .HasMaxLength(40)
                .HasColumnName("ApplicationID");
            entity.Property(e => e.ApplicationType).HasMaxLength(40);
            entity.Property(e => e.RequestType).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(40);
            entity.Property(e => e.UpdateTime).HasPrecision(0);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
