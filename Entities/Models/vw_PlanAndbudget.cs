using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_PlanAndbudget
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string cart { get; set; } = null!;

    [StringLength(26)]
    public string? article { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    [StringLength(26)]
    public string? accountCode { get; set; }

    [Column(TypeName = "money")]
    public decimal? amount { get; set; }

    [StringLength(100)]
    public string? Type { get; set; }

    [StringLength(26)]
    public string? organizationUnitDefinition { get; set; }

    [StringLength(26)]
    public string? lineitemcode { get; set; }

    [StringLength(26)]
    public string? voucheraccountcode { get; set; }

    [StringLength(26)]
    public string? lifespancode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? prodDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? expiryDate { get; set; }
}
