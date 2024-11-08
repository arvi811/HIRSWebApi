using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class Comment
{
    public int Id { get; set; }

    public string? ApplicationId { get; set; }

    public string? Commentor { get; set; }

    public string? Comment1 { get; set; }

    public string? Status { get; set; }

    public DateTime? AddedDate { get; set; }
}
