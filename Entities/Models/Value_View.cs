using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Value_View
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal priceValue { get; set; }

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string? reference { get; set; }

    public bool isDefault { get; set; }

    [StringLength(26)]
    public string currency { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(50)]
    public string price_description { get; set; } = null!;

    [StringLength(50)]
    public string currency_description { get; set; } = null!;

    public byte priority { get; set; }
}
