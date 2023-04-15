using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_journalPostView
{
    [StringLength(26)]
    public string jdCode { get; set; } = null!;

    [StringLength(26)]
    public string jvCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime jvDate { get; set; }

    [Column(TypeName = "money")]
    public decimal jvGrandTotal { get; set; }

    [StringLength(26)]
    public string? jvPeriod { get; set; }

    [StringLength(26)]
    public string account { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal debit { get; set; }

    [Column(TypeName = "money")]
    public decimal credit { get; set; }

    [Column(TypeName = "money")]
    public decimal? jvTotal { get; set; }

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [StringLength(26)]
    public string jvType { get; set; } = null!;

    [StringLength(26)]
    public string controlAccount { get; set; } = null!;

    [StringLength(50)]
    public string accountDescription { get; set; } = null!;
}
