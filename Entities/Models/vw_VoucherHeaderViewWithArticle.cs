using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherHeaderViewWithArticle
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(64)]
    public string? name { get; set; }

    [StringLength(26)]
    public string consignee { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    [StringLength(26)]
    public string? user { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    [StringLength(50)]
    public string? orgUintDefDescription { get; set; }

    [StringLength(26)]
    public string? organizationUnitDef { get; set; }

    [Column(TypeName = "money")]
    public decimal? subTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? discount { get; set; }

    [Column(TypeName = "money")]
    public decimal? additionalCharge { get; set; }

    [StringLength(50)]
    public string? ObjectStateDescription { get; set; }

    [StringLength(26)]
    public string? color { get; set; }

    [StringLength(26)]
    public string? font { get; set; }

    [StringLength(26)]
    public string? source { get; set; }

    [StringLength(26)]
    public string? destination { get; set; }

    [StringLength(2048)]
    public string? note { get; set; }

    [Column(TypeName = "money")]
    public decimal? Tax { get; set; }

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string? ObjectStateDefCode { get; set; }

    public string? DeviceName { get; set; }

    [StringLength(50)]
    public string? sourceName { get; set; }

    [StringLength(50)]
    public string? destinationName { get; set; }

    [StringLength(26)]
    public string? periodName { get; set; }

    [StringLength(50)]
    public string? typeDescription { get; set; }

    public string? ArticleName { get; set; }
}
