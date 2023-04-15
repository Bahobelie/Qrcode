using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_placementView
{
    [StringLength(26)]
    public string lineItemCode { get; set; } = null!;

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(50)]
    public string placementType { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(62)]
    public string? fullName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(50)]
    public string? placementStatus { get; set; }

    [StringLength(26)]
    public string? lastActivity { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    public string? employmentDate { get; set; }

    public string? lastPlacementDate { get; set; }

    [StringLength(26)]
    public string? branchCode { get; set; }

    [StringLength(50)]
    public string? branchDescription { get; set; }

    [StringLength(26)]
    public string? departmentCode { get; set; }

    [StringLength(50)]
    public string? deptDescription { get; set; }

    [StringLength(26)]
    public string? roleCode { get; set; }

    [StringLength(50)]
    public string? roleDescription { get; set; }

    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    public string articleName { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [StringLength(26)]
    public string? UOM { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal taxableAmount { get; set; }

    public int? tax { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxAmount { get; set; }

    [StringLength(26)]
    public string preference { get; set; } = null!;
}
