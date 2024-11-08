using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class InformationLeave
{
    public int Id { get; set; }

    public string? ApplicationId { get; set; }

    public string? RequestId { get; set; }

    public string? RequestType { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? NoOfDays { get; set; }

    public string? LeaveDescription { get; set; }
}
