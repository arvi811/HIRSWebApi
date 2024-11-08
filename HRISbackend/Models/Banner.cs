using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class Banner
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public byte[]? Imgfile { get; set; }
}
