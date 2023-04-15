using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("LineItemValueFactor", Schema = "common")]
public partial class LineItemValueFactor
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string lineItem { get; set; } = null!;

    [StringLength(26)]
    public string? valueFactorReference { get; set; }

    public bool isDiscount { get; set; }

    [Column(TypeName = "money")]
    public decimal amount { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("lineItem")]
    [InverseProperty("LineItemValueFactors")]
    public virtual LineItem lineItemNavigation { get; set; } = null!;
}
