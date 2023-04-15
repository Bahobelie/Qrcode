using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ArticleActivity
{
    [StringLength(26)]
    public string ArticleCode { get; set; } = null!;

    public string ArticleName { get; set; } = null!;

    public int gslType { get; set; }

    public bool isActive { get; set; }

    [StringLength(15)]
    public string uom { get; set; } = null!;

    public string? Unit { get; set; }

    [StringLength(100)]
    public string? brand { get; set; }

    [StringLength(100)]
    public string? generic { get; set; }

    [StringLength(100)]
    public string? model { get; set; }

    [StringLength(25)]
    public string? size { get; set; }

    [StringLength(50)]
    public string? ProductColor { get; set; }

    [StringLength(26)]
    public string? country { get; set; }

    [StringLength(100)]
    public string? countryName { get; set; }

    [StringLength(100)]
    public string? manufacturer { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? length { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? width { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? height { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? weight { get; set; }

    [StringLength(50)]
    public string? ValueDescription { get; set; }

    public string? ValueDes { get; set; }

    [Column(TypeName = "money")]
    public decimal? priceValue { get; set; }

    public bool? PriceDefault { get; set; }

    [StringLength(50)]
    public string? LifeTimeDescription { get; set; }

    public string? LifeTimeD { get; set; }

    [StringLength(26)]
    public string? factor { get; set; }

    public string? LifeTimeFactor { get; set; }

    public int? LifeTimeValue { get; set; }

    [StringLength(50)]
    public string? optionalCodeValue { get; set; }

    [StringLength(50)]
    public string? OptionalCodeDescription { get; set; }

    [StringLength(26)]
    public string preferenceCode { get; set; } = null!;

    [StringLength(100)]
    public string? preferenceDesc { get; set; }

    [StringLength(26)]
    public string? prefParentCode { get; set; }

    [StringLength(100)]
    public string? prefParentDesc { get; set; }

    public int? TaxTypeCode { get; set; }

    [StringLength(50)]
    public string? TaxTypeDesc { get; set; }

    [Column(TypeName = "money")]
    public decimal? TaxValue { get; set; }

    [StringLength(26)]
    public string? objectStateDefnCode { get; set; }

    [StringLength(50)]
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
}
