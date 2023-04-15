using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("LineItemReference", Schema = "common")]
public partial class LineItemReference
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string lineItem { get; set; } = null!;

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    public int referingVouDfn { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal value { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("lineItem")]
    [InverseProperty("LineItemReferencelineItemNavigations")]
    public virtual LineItem lineItemNavigation { get; set; } = null!;

    [ForeignKey("referenced")]
    [InverseProperty("LineItemReferencereferencedNavigations")]
    public virtual LineItem referencedNavigation { get; set; } = null!;

    [ForeignKey("referingVouDfn")]
    [InverseProperty("LineItemReferences")]
    public virtual VoucherDefinition referingVouDfnNavigation { get; set; } = null!;
}
