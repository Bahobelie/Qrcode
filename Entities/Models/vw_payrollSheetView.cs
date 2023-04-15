using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_payrollSheetView
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? consigneeCode { get; set; }

    public string? fullName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? periodCode { get; set; }

    public string periodName { get; set; } = null!;

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    public string articleName { get; set; } = null!;

    [StringLength(26)]
    public string category { get; set; } = null!;

    [StringLength(26)]
    public string lineItemCode { get; set; } = null!;

    [StringLength(26)]
    public string? branchCode { get; set; }

    [StringLength(50)]
    public string? branchDescription { get; set; }

    [StringLength(26)]
    public string? deptCode { get; set; }

    [StringLength(50)]
    public string? department { get; set; }

    [Column(TypeName = "money")]
    public decimal activeWage { get; set; }

    [Column(TypeName = "money")]
    public decimal actualWage { get; set; }

    [StringLength(26)]
    public string? UOM { get; set; }

    [StringLength(100)]
    public string categoryDesc { get; set; } = null!;
}
