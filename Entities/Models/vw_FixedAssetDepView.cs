using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_FixedAssetDepView
{
    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    public int gslType { get; set; }

    public string articleName { get; set; } = null!;

    [StringLength(15)]
    public string uom { get; set; } = null!;

    public string uomDescription { get; set; } = null!;

    public bool isActive { get; set; }

    [StringLength(26)]
    public string preferenceCode { get; set; } = null!;

    [StringLength(100)]
    public string preferenceDescription { get; set; } = null!;

    [StringLength(26)]
    public string? parent { get; set; }

    [StringLength(100)]
    public string parentDescription { get; set; } = null!;

    [StringLength(26)]
    public string organizationCode { get; set; } = null!;

    [StringLength(100)]
    public string expenseShare { get; set; } = null!;

    [StringLength(26)]
    public string orgType { get; set; } = null!;

    [StringLength(50)]
    public string organizationName { get; set; } = null!;

    [StringLength(50)]
    public string specialization { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? bookValue { get; set; }

    [Column(TypeName = "money")]
    public decimal? acquisitionValue { get; set; }

    [Column(TypeName = "money")]
    public decimal? marketValue { get; set; }

    [Column(TypeName = "money")]
    public decimal? salvageValue { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal straightLine { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal declining { get; set; }
}
