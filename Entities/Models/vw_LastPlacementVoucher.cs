using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LastPlacementVoucher
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? wage { get; set; }

    public string? type { get; set; }
}
