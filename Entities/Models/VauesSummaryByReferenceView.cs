using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class VauesSummaryByReferenceView
{
    [StringLength(26)]
    public string referening { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? tax { get; set; }

    [Column(TypeName = "money")]
    public decimal? subTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? discount { get; set; }

    [Column(TypeName = "money")]
    public decimal? additionalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? grandTotal { get; set; }
}
