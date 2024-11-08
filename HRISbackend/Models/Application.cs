using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class Application
{
    public int Id { get; set; }

    public string? ApplicationId { get; set; }

    public string? Applicant { get; set; }

    public string? Department { get; set; }

    public string? Position { get; set; }

    public string? ApplicationType { get; set; }

    public DateTime? ApplicationDate { get; set; }

    public int? TotalNoOfDays { get; set; }

    public string? LeaderApprovedBy { get; set; }

    public DateTime? LeaderApprovedDate { get; set; }

    public string? HeadApprovedBy { get; set; }

    public DateTime? HeadApprovedDate { get; set; }

    public string? Status { get; set; }

    public string? HrapprovedBy { get; set; }

    public DateTime? HrapprovedDate { get; set; }

    public bool? IsDirectToHr { get; set; }

    public bool? IsLeader { get; set; }

    public bool? IsManager { get; set; }

    public bool? IsCancelled { get; set; }

    public DateTime? UpdateTime { get; set; }

    public bool? IsRead { get; set; }
}
