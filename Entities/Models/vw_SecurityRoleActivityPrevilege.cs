using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_SecurityRoleActivityPrevilege
{
    [StringLength(26)]
    public string? RoleParentId { get; set; }

    [StringLength(26)]
    public string RoleCode { get; set; } = null!;

    [StringLength(50)]
    public string RoleDescription { get; set; } = null!;

    [StringLength(50)]
    public string? RangeDescription { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? RangeMin { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? RangeMax { get; set; }

    [StringLength(26)]
    public string? WorkflowReference { get; set; }

    [StringLength(26)]
    public string WorkflowCode { get; set; } = null!;

    public byte WorkflowIndex { get; set; }

    public bool WorkflowIsmanual { get; set; }

    [StringLength(26)]
    public string? WorkflowTimeFactor { get; set; }

    public int? WorkflowRequiredTime { get; set; }

    public int? WorkflowMaxRepeat { get; set; }

    public bool? WorkflowSequence { get; set; }

    [StringLength(100)]
    public string? WorkflowRemark { get; set; }

    public string WorkflowDescription { get; set; } = null!;

    public bool needsPassCode { get; set; }

    [StringLength(50)]
    public string? GslReferenceDescription { get; set; }

    [StringLength(26)]
    public string? GslReferenceCategory { get; set; }

    [StringLength(26)]
    public string? VoucherRefType { get; set; }

    [StringLength(100)]
    public string? VoucherRefName { get; set; }
}
