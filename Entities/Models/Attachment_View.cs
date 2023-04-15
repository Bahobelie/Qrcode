using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Attachment_View
{
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(100)]
    public string? description { get; set; }

    [StringLength(256)]
    public string url { get; set; } = null!;

    public byte[]? file { get; set; }

    public byte? index { get; set; }

    [StringLength(4000)]
    public string? remark { get; set; }

    [StringLength(50)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string typeCode { get; set; } = null!;
}
