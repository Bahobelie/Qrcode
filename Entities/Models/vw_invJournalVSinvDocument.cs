using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_invJournalVSinvDocument
{
    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [StringLength(26)]
    public string referening { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string jAccount { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal jDebit { get; set; }

    [Column(TypeName = "money")]
    public decimal jCredit { get; set; }

    [StringLength(26)]
    public string srcAccount { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? srcDebit { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? srcCredit { get; set; }

    [Column(TypeName = "decimal(20, 4)")]
    public decimal? debit_diff { get; set; }

    [Column(TypeName = "decimal(20, 4)")]
    public decimal? credit_diff { get; set; }
}
