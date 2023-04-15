using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class electrical_items_view
{
    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    public string articleName { get; set; } = null!;

    public int gslType { get; set; }

    [StringLength(26)]
    public string preferenceCode { get; set; } = null!;

    [StringLength(100)]
    public string preferenceDescription { get; set; } = null!;

    [StringLength(26)]
    public string itemObjectStateDefn { get; set; } = null!;

    [StringLength(50)]
    public string itemObjectStateDefnDescription { get; set; } = null!;

    [StringLength(26)]
    public string? preferenceObejectStateDefn { get; set; }

    [StringLength(50)]
    public string? preferenceOSDdesc { get; set; }

    [Column(TypeName = "money")]
    public decimal priceValue { get; set; }

    [StringLength(100)]
    public string? attachmentDescription { get; set; }

    [StringLength(256)]
    public string? attachmentURL { get; set; }

    [Column(TypeName = "decimal(18, 7)")]
    public decimal quantity { get; set; }

    [StringLength(26)]
    public string? storeCode { get; set; }

    [StringLength(50)]
    public string? storeName { get; set; }

    [StringLength(26)]
    public string? branchCode { get; set; }

    [StringLength(50)]
    public string? branchDescription { get; set; }

    [StringLength(26)]
    public string? parentPrefCode { get; set; }

    [StringLength(100)]
    public string? parentPrefDescription { get; set; }

    public string gslNote { get; set; } = null!;

    public string? organization { get; set; }
}
