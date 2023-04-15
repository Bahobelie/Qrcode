using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ArticleStockBalanceBySerialNumber
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [StringLength(26)]
    public string? source { get; set; }

    [StringLength(26)]
    public string? destination { get; set; }

    [StringLength(26)]
    public string serialDefinition { get; set; } = null!;

    public string serialDefDes { get; set; } = null!;

    public string serialNumber { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime prodDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime expiryDate { get; set; }
}
