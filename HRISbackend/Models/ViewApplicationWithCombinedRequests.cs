using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class ViewApplicationWithCombinedRequests
{
    public string? ApplicationId { get; set; }

    public string? Applicant { get; set; }

    public string? Department { get; set; }

    public string? ApplicationType { get; set; }

    public string? CombinedRequests { get; set; }

    public DateTime? ApplicationDate { get; set; }

    public string? LeaderApprovedBy { get; set; }

    public DateTime? LeaderApprovedDate { get; set; }

    public string? HeadApprovedBy { get; set; }

    public DateTime? HeadApprovedDate { get; set; }

    public string? Status { get; set; }

    public bool? IsCancelled { get; set; }
}
