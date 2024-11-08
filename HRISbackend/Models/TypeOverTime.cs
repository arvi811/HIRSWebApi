using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class TypeOverTime
{
    public int Id { get; set; }

    public string? OverTimeType { get; set; }

    public string? Description { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
