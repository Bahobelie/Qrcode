using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_latestBeginningDetail
{
    [StringLength(26)]
    public string article { get; set; } = null!;

    public string name { get; set; } = null!;

    [StringLength(15)]
    public string uom { get; set; } = null!;

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(100)]
    public string preferenceDes { get; set; } = null!;

    [StringLength(26)]
    public string store { get; set; } = null!;

    [Column(TypeName = "decimal(18, 7)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime periodEnd { get; set; }

    public long? r { get; set; }
}
