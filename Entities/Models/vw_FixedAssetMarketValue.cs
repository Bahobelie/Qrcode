using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_FixedAssetMarketValue
{
    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    [Column(TypeName = "money")]
    public decimal marketValue { get; set; }
}
