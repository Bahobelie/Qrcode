using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class viewTransactionDenomination
{
    [StringLength(26)]
    public string denoCode { get; set; } = null!;

    [StringLength(26)]
    public string transactionCurrencyref { get; set; } = null!;

    [StringLength(26)]
    public string Denomination { get; set; } = null!;

    public int Quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal denoTotal { get; set; }

    [StringLength(100)]
    public string? denoRemark { get; set; }

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
    public decimal TransTotal { get; set; }

    [StringLength(100)]
    public string? TransRemark { get; set; }
}
