using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("VoucherAccount", Schema = "common")]
[Index("code", Name = "IX_VoucherAccount", IsUnique = true)]
public partial class VoucherAccount
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string accountCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal amount { get; set; }

    [StringLength(50)]
    public string? cart { get; set; }

    public bool isDebit { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("voucher")]
    [InverseProperty("VoucherAccounts")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
