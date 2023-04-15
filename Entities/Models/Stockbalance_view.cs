using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Stockbalance_view
{
    [StringLength(26)]
    public string Vouchercode { get; set; } = null!;

    public int voucherDefinition { get; set; }

    public bool hasEffet { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "decimal(18, 0)")]
    public decimal quantity { get; set; }

    [StringLength(26)]
    public string lineitemCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? destination { get; set; }

    [StringLength(26)]
    public string? source { get; set; }
}
