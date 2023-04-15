using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ArticleViewINFO
{
    [StringLength(26)]
    public string ArticleCode { get; set; } = null!;

    [StringLength(40)]
    public string ArticleName { get; set; } = null!;

    public int gslType { get; set; }

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(50)]
    public string? PreferenceName { get; set; }

    public bool isActive { get; set; }

    [StringLength(15)]
    public string uom { get; set; } = null!;

    [StringLength(50)]
    public string? Unit { get; set; }

    public int? tax { get; set; }

    [StringLength(50)]
    public string? TaxType { get; set; }

    [Column(TypeName = "money")]
    public decimal? TaxValue { get; set; }
}
