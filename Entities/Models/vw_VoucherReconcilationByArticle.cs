using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherReconcilationByArticle
{
    [StringLength(26)]
    public string VoucherCode { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(100)]
    public string? VoucherType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    public string ArticleName { get; set; } = null!;

    [StringLength(26)]
    public string ArticleCode { get; set; } = null!;

    [StringLength(64)]
    public string? ConsigneeName { get; set; }

    [StringLength(50)]
    public string UOM { get; set; } = null!;
}
