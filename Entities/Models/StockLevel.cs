using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("StockLevel", Schema = "common")]
[Index("code", Name = "IX_StockLevel", IsUnique = true)]
public partial class StockLevel
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(26)]
    public string store { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? minLevel { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? maxLevel { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? leadTime { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? economicOrderQty { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("article")]
    [InverseProperty("StockLevels")]
    public virtual Article articleNavigation { get; set; } = null!;

    [ForeignKey("store")]
    [InverseProperty("StockLevels")]
    public virtual OrganizationUnitDefinition storeNavigation { get; set; } = null!;
}
