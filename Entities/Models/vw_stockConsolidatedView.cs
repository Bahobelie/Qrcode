using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_stockConsolidatedView
{
    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    public string articleName { get; set; } = null!;

    [StringLength(26)]
    public string storeCode { get; set; } = null!;

    [StringLength(50)]
    public string storeName { get; set; } = null!;

    [StringLength(26)]
    public string? balanceDate { get; set; }

    [Column(TypeName = "decimal(18, 7)")]
    public decimal balance { get; set; }

    public string? distributer { get; set; }
}
