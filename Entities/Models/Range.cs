using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Range", Schema = "common")]
[Index("code", Name = "IX_Range", IsUnique = true)]
public partial class Range
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string? type { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal min { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal max { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("RangeNavigation")]
    public virtual ICollection<DiscountFactor> DiscountFactors { get; } = new List<DiscountFactor>();

    [InverseProperty("stayDurationNavigation")]
    public virtual ICollection<RateCodeDetail> RateCodeDetails { get; } = new List<RateCodeDetail>();
}
