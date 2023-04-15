using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherArticle
{
    [StringLength(26)]
    public string ArticleCode { get; set; } = null!;

    public int gslType { get; set; }

    public string ArticleName { get; set; } = null!;

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(50)]
    public string preferenceDesc { get; set; } = null!;

    [StringLength(15)]
    public string uom { get; set; } = null!;

    [StringLength(50)]
    public string Unit { get; set; } = null!;

    public bool isActive { get; set; }

    [StringLength(26)]
    public string objectStateDefinition { get; set; } = null!;

    [StringLength(50)]
    public string objectStateDesc { get; set; } = null!;

    public int tax { get; set; }

    [StringLength(50)]
    public string TaxTypeDesc { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal TaxValue { get; set; }

    [StringLength(26)]
    public string? parent { get; set; }

    [StringLength(50)]
    public string? parentDesc { get; set; }
}
