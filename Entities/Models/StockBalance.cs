using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("StockBalance", Schema = "common")]
[Index("code", Name = "IX_StockBalance", IsUnique = true)]
public partial class StockBalance
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(26)]
    public string store { get; set; } = null!;

    [StringLength(100)]
    public string? batch { get; set; }

    [Column(TypeName = "decimal(18, 7)")]
    public decimal quantity { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("article")]
    [InverseProperty("StockBalances")]
    public virtual Article articleNavigation { get; set; } = null!;

    [ForeignKey("period")]
    [InverseProperty("StockBalances")]
    public virtual Period? periodNavigation { get; set; }

    [ForeignKey("store")]
    [InverseProperty("StockBalances")]
    public virtual OrganizationUnitDefinition storeNavigation { get; set; } = null!;
}
