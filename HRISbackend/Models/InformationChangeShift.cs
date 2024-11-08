using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class InformationChangeShift
{
    public int Id { get; set; }

    public string? ApplicationId { get; set; }

    public string? RequestId { get; set; }

    public DateOnly? ShiftDate { get; set; }

    public string? OriginalSchedule { get; set; }

    public string? NewSchedule { get; set; }

    public string? RequestType { get; set; }

    public string? Reason { get; set; }
}
