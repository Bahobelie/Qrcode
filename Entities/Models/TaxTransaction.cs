using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("TaxTransaction", Schema = "common")]
[Index("code", Name = "IX_TaxTransaction", IsUnique = true)]
public partial class TaxTransaction
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public int taxType { get; set; }

    [Column(TypeName = "money")]
    public decimal taxableAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal taxAmount { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("taxType")]
    [InverseProperty("TaxTransactions")]
    public virtual Tax taxTypeNavigation { get; set; } = null!;

    [ForeignKey("voucher")]
    [InverseProperty("TaxTransactions")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
