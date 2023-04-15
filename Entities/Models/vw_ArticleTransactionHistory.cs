using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ArticleTransactionHistory
{
    public int voucherDefinition { get; set; }

    [StringLength(100)]
    public string? voucherDefinitionName { get; set; }

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string? consigneeCode { get; set; }

    public string? consigneeName { get; set; }

    public string? consigneeTelephone { get; set; }

    [StringLength(20)]
    public string? consigneeTIN { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? lineItemTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal discount { get; set; }

    [Column(TypeName = "money")]
    public decimal additionalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }
}
