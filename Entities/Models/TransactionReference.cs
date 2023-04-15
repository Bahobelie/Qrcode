using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("TransactionReference", Schema = "common")]
[Index("code", Name = "IX_TransactionReference", IsUnique = true)]
public partial class TransactionReference
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string referening { get; set; } = null!;

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? value { get; set; }

    [StringLength(50)]
    public string? relationType { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("referenced")]
    [InverseProperty("TransactionReferencereferencedNavigations")]
    public virtual Voucher referencedNavigation { get; set; } = null!;

    [ForeignKey("referening")]
    [InverseProperty("TransactionReferencerefereningNavigations")]
    public virtual Voucher refereningNavigation { get; set; } = null!;
}
