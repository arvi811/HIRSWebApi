using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class InformationOverTime
{
    public int Id { get; set; }

    public string? ApplicationId { get; set; }

    public string? RequestId { get; set; }

    public string? RequestType { get; set; }

    public DateOnly? ShiftDate { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public decimal? TotalHours { get; set; }

    public string? Reason { get; set; }
}
