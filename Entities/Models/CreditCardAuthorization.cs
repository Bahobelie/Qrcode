using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("CreditCardAuthorization", Schema = "common")]
public partial class CreditCardAuthorization
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string Code { get; set; } = null!;

    [StringLength(26)]
    public string Voucher { get; set; } = null!;

    [StringLength(26)]
    public string? authorizationCode { get; set; }

    [StringLength(50)]
    public string? authorizationAmt { get; set; }

    [StringLength(50)]
    public string? suiteWith { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("Voucher")]
    [InverseProperty("CreditCardAuthorizations")]
    public virtual Voucher VoucherNavigation { get; set; } = null!;
}
