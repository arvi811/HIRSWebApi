using System;
using System.Collections.Generic;

namespace HRISbackend.Models;

public partial class Attachment
{
    public int Id { get; set; }

    public string? ApplicationId { get; set; }

    public string? FileName { get; set; }

    public string? FileExtension { get; set; }

    public byte[]? FileBytes { get; set; }

    public string? UploadedBy { get; set; }

    public DateTime? UploadedDate { get; set; }
}
