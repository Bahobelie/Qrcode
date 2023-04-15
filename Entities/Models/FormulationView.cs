using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class FormulationView
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public int year { get; set; }

    public int month { get; set; }

    public int date { get; set; }

    public bool IsVoid { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(100)]
    public string? voucherRemark { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string LineItemCode { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    public string articleDescription { get; set; } = null!;

    [StringLength(50)]
    public string? UnitOfM { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? totalAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal taxableAmount { get; set; }

    public int? tax { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? calculatedCost { get; set; }

    [StringLength(100)]
    public string? LineItemRemark { get; set; }
}
