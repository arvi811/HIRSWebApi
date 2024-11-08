using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class InformationLate
{
    public int Id { get; set; }

    public string? ApplicationId { get; set; }

    public string? RequestId { get; set; }

    public DateOnly? ShiftDate { get; set; }

    public DateTime? OriginalSchedule { get; set; }

    public DateTime? ActualTimeIn { get; set; }

    public TimeOnly? TotalLateTime { get; set; }

    public string? Reason { get; set; }

    public string? IsExcusedLeader { get; set; }

    public string? IsExcusedManager { get; set; }

    public string? IsExcusedHr { get; set; }
}
