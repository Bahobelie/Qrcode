using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class View_ArticlePrice
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(50)]
    public string? Pricedescription { get; set; }

    [StringLength(26)]
    public string? reference { get; set; }

    [StringLength(62)]
    public string? RefDescription { get; set; }

    [Column(TypeName = "money")]
    public decimal priceValue { get; set; }

    public bool isDefault { get; set; }

    [StringLength(26)]
    public string currency { get; set; } = null!;

    public byte priority { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
