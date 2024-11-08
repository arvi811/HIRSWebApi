using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class TypeChangeShift
{
    public int Id { get; set; }

    public string? ChangeShiftType { get; set; }

    public string? Description { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedDate { get; set; }

    public bool? IsDeleted { get; set; }
}
