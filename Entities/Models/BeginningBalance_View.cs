using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class BeginningBalance_View
{
    [StringLength(26)]
    public string stockCode { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(26)]
    public string store { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal quantity { get; set; }

    [StringLength(26)]
    public string stockType { get; set; } = null!;

    [StringLength(26)]
    public string periodType { get; set; } = null!;

    [StringLength(26)]
    public string period { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime start { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime end { get; set; }
}
