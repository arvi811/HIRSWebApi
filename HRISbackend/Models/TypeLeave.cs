using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class TypeLeave
{
    public int Id { get; set; }

    public string? LeaveType { get; set; }

    public string? Description { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
