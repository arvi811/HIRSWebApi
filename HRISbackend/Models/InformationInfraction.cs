using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class InformationInfraction
{
    public int Id { get; set; }

    public string? ApplicationId { get; set; }

    public string? RequestId { get; set; }

    public DateOnly? ShiftDate { get; set; }

    public string? RequestType { get; set; }

    public string? Issues { get; set; }

    public DateTime? ScheduledInOut { get; set; }

    public DateTime? SystemInOut { get; set; }

    public DateTime? ActualInout { get; set; }

    public string? Reason { get; set; }
}
