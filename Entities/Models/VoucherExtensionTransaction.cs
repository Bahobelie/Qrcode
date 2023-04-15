using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("VoucherExtensionTransaction", Schema = "common")]
[Index("code", Name = "IX_VoucherExtensionTransaction", IsUnique = true)]
public partial class VoucherExtensionTransaction
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string voucherExtension { get; set; } = null!;

    [StringLength(26)]
    public string number { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("voucherExtension")]
    [InverseProperty("VoucherExtensionTransactions")]
    public virtual VoucherExtension voucherExtensionNavigation { get; set; } = null!;

    [ForeignKey("voucher")]
    [InverseProperty("VoucherExtensionTransactions")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
