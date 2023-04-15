using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_RMSHeldView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? table { get; set; }

    [StringLength(26)]
    public string? cover { get; set; }

    public string? waitername { get; set; }

    [StringLength(26)]
    public string? user { get; set; }

    [StringLength(26)]
    public string? organizationUnitDef { get; set; }

    [StringLength(26)]
    public string articlecode { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    public string articlename { get; set; } = null!;

    public string? DeviceName { get; set; }

    public int voucherDefinition { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? activitiyDefinition { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    [StringLength(26)]
    public string voucherType { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    public int? seat { get; set; }

    public int? orderState { get; set; }
}
