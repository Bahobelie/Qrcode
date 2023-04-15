using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_DiscountFactor
{
    [StringLength(26)]
    public string Article { get; set; } = null!;

    [StringLength(26)]
    public string Component { get; set; } = null!;

    [StringLength(50)]
    public string Reference { get; set; } = null!;

    [StringLength(26)]
    public string Range { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal min { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal max { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal ValueDiscount { get; set; }
}
