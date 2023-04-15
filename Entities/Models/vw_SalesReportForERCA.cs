using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_SalesReportForERCA
{
    public string customerName { get; set; } = null!;

    [StringLength(20)]
    public string tin { get; set; } = null!;

    public string articleName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? beforeVat { get; set; }

    [StringLength(26)]
    public string MRC { get; set; } = null!;

    [StringLength(26)]
    public string FS { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime date { get; set; }

    [StringLength(26)]
    public string docNo { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string consignee { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }
}
