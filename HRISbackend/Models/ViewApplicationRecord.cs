using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class ViewApplicationRecord
{
    public string? ApplicationId { get; set; }

    public string? Applicant { get; set; }

    public DateTime? ApplicationDate { get; set; }

    public string? Department { get; set; }

    public string? Position { get; set; }

    public string? ApplicationType { get; set; }

    public string? RequestType { get; set; }

    public DateOnly? LeaveStartDate { get; set; }

    public DateOnly? LeaveEndDate { get; set; }

    public int? LeaveNoOfDays { get; set; }

    public DateOnly? ChangeShiftShiftDate { get; set; }

    public string? ChangeShiftOriginalSchedule { get; set; }

    public string? ChangeShiftNewSchedule { get; set; }

    public DateOnly? OverTimeShiftDate { get; set; }

    public DateTime? OverTimeStartTime { get; set; }

    public DateTime? OverTimeEndTime { get; set; }

    public decimal? OverTimeTotalHours { get; set; }

    public DateTime? LateOriginalSchedule { get; set; }

    public DateTime? LateActualTimeIn { get; set; }

    public TimeOnly? LateTotalLateTime { get; set; }

    public string? LateIsExcusedLeader { get; set; }

    public string? LateIsExcusedManager { get; set; }

    public string? LateIsExcusedHr { get; set; }

    public string? InfractionIssues { get; set; }

    public DateOnly? InfractionShiftDate { get; set; }

    public DateTime? InfractionScheduledInOut { get; set; }

    public DateTime? InfractionSystemInOut { get; set; }

    public DateTime? InfractionActualInOut { get; set; }

    public string? Description { get; set; }

    public string? LeaderApprovedBy { get; set; }

    public DateTime? LeaderApprovedDate { get; set; }

    public string? HeadApprovedBy { get; set; }

    public DateTime? HeadApprovedDate { get; set; }

    public string? HrapprovedBy { get; set; }

    public DateTime? HrapprovedDate { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? Status { get; set; }
}
