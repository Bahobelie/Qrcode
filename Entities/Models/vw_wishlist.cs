using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_wishlist
{
    public string? companyTin { get; set; }

    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    public string articleName { get; set; } = null!;

    [StringLength(26)]
    public string prefCode { get; set; } = null!;

    [StringLength(100)]
    public string prefDesc { get; set; } = null!;

    [StringLength(256)]
    public string? url { get; set; }

    [Column(TypeName = "money")]
    public decimal priceValue { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [StringLength(50)]
    public string osdDescription { get; set; } = null!;
}
