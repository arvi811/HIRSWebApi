using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class EmailRecipient
{
    public int Id { get; set; }

    public string? EmployeeName { get; set; }

    public string? Team { get; set; }

    public string? Position { get; set; }

    public string? Email { get; set; }
}
