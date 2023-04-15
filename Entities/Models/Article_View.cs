using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Article_View
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int gslType { get; set; }

    public string name { get; set; } = null!;

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(50)]
    public string? preference_d { get; set; }

    [StringLength(50)]
    public string? uom_d { get; set; }

    [StringLength(15)]
    public string uom { get; set; } = null!;

    public bool isActive { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? isActive_D { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string Fast { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string IsSaleable { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string IsBatchItem { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string WAC { get; set; } = null!;

    public int? TaxCode { get; set; }

    [StringLength(50)]
    public string? Tax { get; set; }

    [StringLength(200)]
    public string? Location { get; set; }

    [StringLength(62)]
    public string? Supplier { get; set; }

    [Column(TypeName = "money")]
    public decimal? DefaultPrice { get; set; }

    [StringLength(26)]
    public string? user { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string? Object_State_Colour { get; set; }

    [StringLength(26)]
    public string? Object_State_Font { get; set; }

    [Column(TypeName = "money")]
    public decimal? tax_value { get; set; }
}
