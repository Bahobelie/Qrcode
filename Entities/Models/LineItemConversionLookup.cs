using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class LineItemConversionLookup
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string lineItem { get; set; } = null!;

    [StringLength(26)]
    public string uom { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    public double quantity { get; set; }

    public double unitAmount { get; set; }
}
