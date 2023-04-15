using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("CartTransaction", Schema = "common")]
[Index("code", Name = "IX_CartTransaction", IsUnique = true)]
public partial class CartTransaction
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string cart { get; set; } = null!;

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    [Column(TypeName = "money")]
    public decimal value { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("cart")]
    [InverseProperty("CartTransactions")]
    public virtual Preference cartNavigation { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("CartTransactions")]
    public virtual Voucher referenceNavigation { get; set; } = null!;
}
