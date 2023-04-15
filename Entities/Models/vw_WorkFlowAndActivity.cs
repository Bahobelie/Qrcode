using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_WorkFlowAndActivity
{
    public Guid id { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    public string? DescriptionName { get; set; }

    [StringLength(26)]
    public string? user { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    [StringLength(26)]
    public string? person { get; set; }

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

    [StringLength(26)]
    public string objectStateDefinition { get; set; } = null!;

    [StringLength(50)]
    public string? OSDDescription { get; set; }

    [StringLength(26)]
    public string? VoucherRef { get; set; }

    public int? maxRepeat { get; set; }

    public bool? sequence { get; set; }

    public bool? isPrint { get; set; }
}
