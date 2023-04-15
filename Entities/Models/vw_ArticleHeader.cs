using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ArticleHeader
{
    [StringLength(26)]
    public string ArticleCode { get; set; } = null!;

    public string ArticleName { get; set; } = null!;

    public int gslType { get; set; }

    [StringLength(26)]
    public string preferenceCode { get; set; } = null!;

    [StringLength(100)]
    public string? preferenceDesc { get; set; }

    [StringLength(26)]
    public string? prefParentCode { get; set; }

    [StringLength(100)]
    public string? prefParentDesc { get; set; }

    public bool isActive { get; set; }

    [StringLength(15)]
    public string uomCode { get; set; } = null!;

    public string? uomDesc { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? length { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? width { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? height { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? weight { get; set; }

    [StringLength(100)]
    public string? brand { get; set; }

    [StringLength(100)]
    public string? generic { get; set; }

    [StringLength(100)]
    public string? model { get; set; }

    [StringLength(25)]
    public string? size { get; set; }

    [StringLength(50)]
    public string? productColor { get; set; }

    [StringLength(26)]
    public string? country { get; set; }

    [StringLength(100)]
    public string? countryName { get; set; }

    [StringLength(100)]
    public string? manufacturer { get; set; }

    public string? defaultPriceDescription { get; set; }

    [Column(TypeName = "money")]
    public decimal? defaultPriceValue { get; set; }

    public int? taxTypeCode { get; set; }

    [StringLength(50)]
    public string? taxTypeDesc { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxTypeValue { get; set; }

    public int? lifeTimeValue { get; set; }

    [StringLength(26)]
    public string? lifetimeFactorCode { get; set; }

    public string? lifetimeFactorDesc { get; set; }

    public string? optionCodesValue { get; set; }

    [StringLength(26)]
    public string? objectStateDefnCode { get; set; }

    public string? ObjectStateDefnDesc { get; set; }

    [StringLength(26)]
    public string? ObjectStateColor { get; set; }

    [StringLength(26)]
    public string? ObjectStateFont { get; set; }

    public string? activityDef { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? startTimStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endTimStamp { get; set; }

    [StringLength(26)]
    public string? supplierCode { get; set; }

    public string? supplierName { get; set; }

    public int? displayOrder { get; set; }
}
