using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_taxPostView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(100)]
    public string? name { get; set; }

    [StringLength(15)]
    public string? journalType { get; set; }

    public int taxType { get; set; }

    [Column(TypeName = "money")]
    public decimal taxAmount { get; set; }

    [StringLength(26)]
    public string jdCode { get; set; } = null!;

    [StringLength(26)]
    public string jvCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime jvdate { get; set; }

    [Column(TypeName = "money")]
    public decimal jvGrandTotal { get; set; }

    [StringLength(26)]
    public string jvPeriod { get; set; } = null!;

    [StringLength(26)]
    public string account { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal debit { get; set; }

    [Column(TypeName = "money")]
    public decimal credit { get; set; }

    [Column(TypeName = "money")]
    public decimal jvTotal { get; set; }

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [StringLength(26)]
    public string jvType { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal difference { get; set; }
}
