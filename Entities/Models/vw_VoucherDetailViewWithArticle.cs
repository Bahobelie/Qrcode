using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherDetailViewWithArticle
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public string? ArticleName { get; set; }

    public int voucherDefinition { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(64)]
    public string? name { get; set; }

    [Column(TypeName = "money")]
    public decimal? subTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? discount { get; set; }

    [Column(TypeName = "money")]
    public decimal? additionalCharge { get; set; }

    [StringLength(50)]
    public string? ObjectStateDescription { get; set; }

    [StringLength(26)]
    public string? source { get; set; }

    [StringLength(26)]
    public string? destination { get; set; }

    [StringLength(2048)]
    public string? note { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    public string? DeviceName { get; set; }

    [StringLength(26)]
    public string? user { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    [StringLength(26)]
    public string? organizationUnitDef { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    public int? tax { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? calculatedCost { get; set; }

    [StringLength(26)]
    public string? preference { get; set; }

    [StringLength(26)]
    public string? PreferenceCode { get; set; }

    [StringLength(50)]
    public string? PreferenceDescription { get; set; }

    [StringLength(26)]
    public string? parent { get; set; }

    [StringLength(50)]
    public string? parentDescription { get; set; }

    public string? artName { get; set; }
}
