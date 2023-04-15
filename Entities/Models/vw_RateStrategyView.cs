using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_RateStrategyView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(150)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string condition { get; set; } = null!;

    [StringLength(26)]
    public string restrictionType { get; set; } = null!;

    public bool isPercent { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal value { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? startDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? controlBegin { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? controlEnd { get; set; }

    public int? priority { get; set; }

    public bool isActive { get; set; }

    [StringLength(50)]
    public string rateHeaderDesc { get; set; } = null!;

    [StringLength(50)]
    public string conditionDesc { get; set; } = null!;

    [StringLength(50)]
    public string restrictionDesc { get; set; } = null!;

    [StringLength(26)]
    public string rateHeaderCode { get; set; } = null!;
}
