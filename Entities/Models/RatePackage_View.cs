using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class RatePackage_View
{
    public bool packageIncluded { get; set; }

    public double quantity { get; set; }

    [StringLength(26)]
    public string packageCode { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(50)]
    public string packageDescription { get; set; } = null!;

    [StringLength(26)]
    public string? pakgGroup { get; set; }

    [StringLength(26)]
    public string? postingRhythm { get; set; }

    [StringLength(26)]
    public string? calculationRule { get; set; }

    [StringLength(26)]
    public string? formula { get; set; }

    [StringLength(26)]
    public string package { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime pkgStart { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? Price { get; set; }

    [Column(TypeName = "money")]
    public decimal? allowance { get; set; }

    [StringLength(26)]
    public string rateCodeHeader { get; set; } = null!;
}
