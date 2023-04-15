using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class viewRoleActivitywithRange
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string role { get; set; } = null!;

    [StringLength(26)]
    public string activityDefinition { get; set; } = null!;

    [StringLength(26)]
    public string description { get; set; } = null!;

    [StringLength(50)]
    public string? Activity_Description { get; set; }

    public bool needsPassCode { get; set; }

    [StringLength(26)]
    public string? range { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string? reference { get; set; }

    [StringLength(50)]
    public string? Range_Description { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? min { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? max { get; set; }
}
