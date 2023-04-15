using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("StoreTransaction", Schema = "common")]
[Index("code", Name = "IX_StoreTransaction", IsUnique = true)]
public partial class StoreTransaction
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string? source { get; set; }

    [StringLength(26)]
    public string? destination { get; set; }

    public bool hasEffet { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("destination")]
    [InverseProperty("StoreTransactiondestinationNavigations")]
    public virtual OrganizationUnitDefinition? destinationNavigation { get; set; }

    [ForeignKey("source")]
    [InverseProperty("StoreTransactionsourceNavigations")]
    public virtual OrganizationUnitDefinition? sourceNavigation { get; set; }

    [ForeignKey("voucher")]
    [InverseProperty("StoreTransactions")]
    public virtual Voucher voucherNavigation { get; set; } = null!;
}
