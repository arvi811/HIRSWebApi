using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class TblUserLoginLog
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Name { get; set; }

    public bool? IsLoggedin { get; set; }

    public string? Activity { get; set; }

    public string? Version { get; set; }

    public DateTime? LoggedDate { get; set; }
}
