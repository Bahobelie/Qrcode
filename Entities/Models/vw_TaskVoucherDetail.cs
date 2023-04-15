using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_TaskVoucherDetail
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    public string? name { get; set; }

    [StringLength(20)]
    public string? TIN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsVoid { get; set; }

    public bool IsIssued { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime prodDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime expiryDate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string objectStateDefinition { get; set; } = null!;

    [StringLength(26)]
    public string? childPrefCode { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string objectStateDefnDesc { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? subTotal { get; set; }

    [StringLength(26)]
    public string voucherValueCode { get; set; } = null!;

    [StringLength(26)]
    public string? referenced { get; set; }

    [StringLength(50)]
    public string? relationType { get; set; }

    [StringLength(26)]
    public string? referening { get; set; }

    [StringLength(26)]
    public string LifeSpanCode { get; set; } = null!;

    [StringLength(26)]
    public string lineItemCode { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    public string articleName { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    [StringLength(100)]
    public string? LineItemRemark { get; set; }

    [StringLength(26)]
    public string? UOM { get; set; }

    [StringLength(26)]
    public string articlePreference { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? weight { get; set; }
}
