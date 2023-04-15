using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class StockLevelView
{
    [StringLength(26)]
    public string orgCode { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string? parentId { get; set; }

    [StringLength(50)]
    public string? specialization { get; set; }

    [StringLength(26)]
    public string? StockLavelCode { get; set; }

    [StringLength(26)]
    public string? sbArticle { get; set; }

    [StringLength(26)]
    public string? sbStore { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal minLevel { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal maxLevel { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal leadTime { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal economicOrderQty { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
