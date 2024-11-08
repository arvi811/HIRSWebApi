using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class InformationLeaveDateList
{
    public int Id { get; set; }

    public string? RequestId { get; set; }

    public DateOnly? RequestDate { get; set; }
}
