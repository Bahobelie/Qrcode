using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("TransactionCurrency", Schema = "common")]
[Index("code", Name = "IX_TransactionCurrency", IsUnique = true)]
public partial class TransactionCurrency
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string currency { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal rate { get; set; }

    [Column(TypeName = "money")]
    public decimal amount { get; set; }

    [Column(TypeName = "money")]
    public decimal total { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("currency")]
    [InverseProperty("TransactionCurrencies")]
    public virtual Currency currencyNavigation { get; set; } = null!;

    [ForeignKey("voucher")]
    [InverseProperty("TransactionCurrencies")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
