using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_latestBeginningCost
{
    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? value { get; set; }

    [Column(TypeName = "decimal(38, 7)")]
    public decimal? qty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime periodEnd { get; set; }

    public long? r { get; set; }
}
