using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class ViewMyApplication
{
    public string? ApplicationId { get; set; }

    public string? Applicant { get; set; }

    public DateTime? ApplicationDate { get; set; }

    public string? ApplicationType { get; set; }

    public string? RequestType { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public DateTime? UpdateTime { get; set; }
}
