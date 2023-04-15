using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_CurrentArticleStockBalance
{
    [StringLength(26)]
    public string article { get; set; } = null!;

    public string articleName { get; set; } = null!;

    [StringLength(26)]
    public string? storeCode { get; set; }

    [Column(TypeName = "decimal(38, 4)")]
    public decimal currentBalance { get; set; }
}
