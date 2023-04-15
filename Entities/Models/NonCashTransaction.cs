using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("NonCashTransaction", Schema = "common")]
[Index("code", Name = "IX_NonCashTransaction", IsUnique = true)]
public partial class NonCashTransaction
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string consignee { get; set; } = null!;

    public bool isIncoming { get; set; }

    [StringLength(26)]
    public string paymentMethod { get; set; } = null!;

    [StringLength(26)]
    public string? paymentProcesser { get; set; }

    public int index { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime issueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? maturityDate { get; set; }

    [StringLength(50)]
    public string number { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? rate { get; set; }

    [Column(TypeName = "money")]
    public decimal amount { get; set; }

    public bool executed { get; set; }

    [StringLength(26)]
    public string? currencyCode { get; set; }

    [StringLength(100)]
    public string? depositRef { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("consignee")]
    [InverseProperty("NonCashTransactions")]
    public virtual OrganizationUnit consignee1 { get; set; } = null!;

    [ForeignKey("consignee")]
    [InverseProperty("NonCashTransactions")]
    public virtual Person consignee2 { get; set; } = null!;

    [ForeignKey("consignee")]
    [InverseProperty("NonCashTransactionconsigneeNavigations")]
    public virtual Organization consigneeNavigation { get; set; } = null!;

    [ForeignKey("currencyCode")]
    [InverseProperty("NonCashTransactions")]
    public virtual Currency? currencyCodeNavigation { get; set; }

    [ForeignKey("paymentMethod")]
    [InverseProperty("NonCashTransactions")]
    public virtual Lookup paymentMethodNavigation { get; set; } = null!;

    [ForeignKey("paymentProcesser")]
    [InverseProperty("NonCashTransactionpaymentProcesserNavigations")]
    public virtual Organization? paymentProcesserNavigation { get; set; }

    [ForeignKey("voucher")]
    [InverseProperty("NonCashTransactions")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
