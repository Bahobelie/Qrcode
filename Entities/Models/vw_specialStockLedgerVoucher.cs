using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_specialStockLedgerVoucher
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(100)]
    public string? vouDefName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [StringLength(26)]
    public string? source { get; set; }

    [StringLength(26)]
    public string? destination { get; set; }

    [StringLength(26)]
    public string lineItemCode { get; set; } = null!;
}
