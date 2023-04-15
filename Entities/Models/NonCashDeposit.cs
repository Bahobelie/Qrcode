using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class NonCashDeposit
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? currencyCode { get; set; }

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(100)]
    public string? depositRef { get; set; }

    [StringLength(50)]
    public string number { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal amount { get; set; }

    [StringLength(26)]
    public string? paymentProcesser { get; set; }

    public string? Bank { get; set; }

    [StringLength(50)]
    public string? branch { get; set; }
}
