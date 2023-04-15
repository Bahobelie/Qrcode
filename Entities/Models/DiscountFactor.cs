using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("DiscountFactor", Schema = "common")]
public partial class DiscountFactor
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(50)]
    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    [StringLength(26)]
    public string Article { get; set; } = null!;

    [StringLength(26)]
    public string Component { get; set; } = null!;

    [StringLength(50)]
    public string Reference { get; set; } = null!;

    [StringLength(26)]
    public string Range { get; set; } = null!;

    [StringLength(26)]
    public string ValueFactorDefinition { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal Amount { get; set; }

    public bool? Category { get; set; }

    public string? Remark { get; set; }

    [ForeignKey("Article")]
    [InverseProperty("DiscountFactors")]
    public virtual Article ArticleNavigation { get; set; } = null!;

    [ForeignKey("Component")]
    [InverseProperty("DiscountFactors")]
    public virtual CNETComponent ComponentNavigation { get; set; } = null!;

    [ForeignKey("Range")]
    [InverseProperty("DiscountFactors")]
    public virtual Range RangeNavigation { get; set; } = null!;

    [ForeignKey("ValueFactorDefinition")]
    [InverseProperty("DiscountFactors")]
    public virtual ValueFactorDefinition ValueFactorDefinitionNavigation { get; set; } = null!;
}
