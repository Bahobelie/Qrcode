using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LedgerTransactionsView
{
    public int voucherDefnition { get; set; }

    public bool isDebit { get; set; }

    [StringLength(26)]
    public string VoucherCode { get; set; } = null!;

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(100)]
    public string? VoucherdefDescription { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(50)]
    public string RecSumName { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string lineItemCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? calculatedCost { get; set; }
}
