using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_AccrualVoucher
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

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
    public string Expr1 { get; set; } = null!;

    [StringLength(20)]
    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(26)]
    public string branchCode { get; set; } = null!;

    [StringLength(50)]
    public string branchDescription { get; set; } = null!;

    [StringLength(26)]
    public string deptCode { get; set; } = null!;

    [StringLength(50)]
    public string department { get; set; } = null!;

    public string name { get; set; } = null!;

    [StringLength(15)]
    public string Expr2 { get; set; } = null!;

    public int gslType { get; set; }
}
