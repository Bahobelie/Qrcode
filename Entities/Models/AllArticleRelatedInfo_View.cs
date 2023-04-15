using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class AllArticleRelatedInfo_View
{
    [StringLength(10)]
    [Unicode(false)]
    public string? SN { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    public string name { get; set; } = null!;

    public bool isActive { get; set; }

    public int gslType { get; set; }

    [StringLength(15)]
    public string uom { get; set; } = null!;

    [StringLength(26)]
    public string categoid { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    public int? tax_code { get; set; }

    [StringLength(50)]
    public string? tax_description { get; set; }

    [Column(TypeName = "money")]
    public decimal? amount { get; set; }
}
