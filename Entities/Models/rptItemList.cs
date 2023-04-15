using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class rptItemList
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(40)]
    public string name { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(50)]
    public string cCategory { get; set; } = null!;

    [StringLength(50)]
    public string pCategory { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? priceValue { get; set; }

    public bool isActive { get; set; }

    public int? count { get; set; }
}
