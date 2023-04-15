using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ActivityDefination_view
{
    public Guid id { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string? reference { get; set; }

    [StringLength(26)]
    public string description { get; set; } = null!;

    public byte Index { get; set; }

    public bool hasIssuingEffect { get; set; }

    public bool isManual { get; set; }

    [StringLength(26)]
    public string? timeFactor { get; set; }

    public int? requiredTime { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    public int? maxRepeat { get; set; }

    public bool? sequence { get; set; }

    public bool? isPrint { get; set; }

    public string DefinationDesc { get; set; } = null!;

    [StringLength(26)]
    public string objectstateCode { get; set; } = null!;

    [StringLength(50)]
    public string objectstate { get; set; } = null!;
}
