using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ActivitySecurity
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string role { get; set; } = null!;

    public bool needsPassCode { get; set; }

    [StringLength(26)]
    public string activityDefinition { get; set; } = null!;

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string? reference { get; set; }

    [StringLength(26)]
    public string actDefnLkDesc { get; set; } = null!;

    [StringLength(50)]
    public string actDefnDesc { get; set; } = null!;

    [StringLength(26)]
    public string? objectStateDefinition { get; set; }

    public byte Index { get; set; }

    public bool hasIssuingEffect { get; set; }

    public bool isManual { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string? range { get; set; }

    [StringLength(50)]
    public string? rangeDescription { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? min { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? max { get; set; }

    public int? maxRepeat { get; set; }

    public bool? sequence { get; set; }
}
