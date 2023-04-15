using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Media_View
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string name { get; set; } = null!;

    public string description { get; set; } = null!;

    [StringLength(1000)]
    public string streamURL { get; set; } = null!;

    [StringLength(50)]
    public string type { get; set; } = null!;

    [StringLength(50)]
    public string category { get; set; } = null!;

    [StringLength(26)]
    public string? article { get; set; }

    [StringLength(26)]
    public string typeCode { get; set; } = null!;

    [StringLength(26)]
    public string categoryCode { get; set; } = null!;

    [StringLength(100)]
    public string? attachmentDescription { get; set; }

    [StringLength(256)]
    public string? attachmentURL { get; set; }

    public byte[]? attachment { get; set; }

    public int? index { get; set; }

    public double? latitude { get; set; }

    public double? longitude { get; set; }

    public bool? active { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
