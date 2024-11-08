using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class ViewLeaveReport
{
    public string? ApplicationId { get; set; }

    public string? Applicant { get; set; }

    public DateTime? ApplicationDate { get; set; }

    public string? Department { get; set; }

    public string? Position { get; set; }

    public string? RequestType { get; set; }

    public DateOnly? RequestDate { get; set; }

    public string? Status { get; set; }
}
