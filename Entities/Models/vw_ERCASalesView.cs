using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ERCASalesView
{
    [StringLength(26)]
    public string vouchercode { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    public string name { get; set; } = null!;

    public string uom { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal taxableAmount { get; set; }

    public int? tax { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxrate { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? grandTotal { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    public string consigneename { get; set; } = null!;

    [StringLength(20)]
    public string idNumber { get; set; } = null!;

    public string Address { get; set; } = null!;

    [StringLength(26)]
    public string fsNo { get; set; } = null!;

    [StringLength(26)]
    public string mrcNo { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal Discount { get; set; }

    [Column(TypeName = "money")]
    public decimal AdditionalCharge { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }
}
