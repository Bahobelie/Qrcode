using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("TransactionLimit", Schema = "common")]
public partial class TransactionLimit
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string Code { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string? limitFactor { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? value { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("reference")]
    [InverseProperty("TransactionLimits")]
    public virtual Organization reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("TransactionLimits")]
    public virtual Person reference2 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("TransactionLimits")]
    public virtual Article referenceNavigation { get; set; } = null!;

    [ForeignKey("type")]
    [InverseProperty("TransactionLimits")]
    public virtual Lookup typeNavigation { get; set; } = null!;
}
