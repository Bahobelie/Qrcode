using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("DenominationDetail", Schema = "common")]
[Index("Code", Name = "IX_DenominationDetail", IsUnique = true)]
public partial class DenominationDetail
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string Code { get; set; } = null!;

    [StringLength(26)]
    public string transactionCurrencyref { get; set; } = null!;

    [StringLength(26)]
    public string Denomination { get; set; } = null!;

    public int Quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal Total { get; set; }

    [StringLength(100)]
    public string? Remark { get; set; }

    [ForeignKey("transactionCurrencyref")]
    [InverseProperty("DenominationDetails")]
    public virtual Voucher transactionCurrencyrefNavigation { get; set; } = null!;
}
