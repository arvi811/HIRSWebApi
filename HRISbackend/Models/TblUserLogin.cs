using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class TblUserLogin
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Department { get; set; }
}
