using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_TrialBalanceView
{
    [StringLength(26)]
    public string trialBalanceCode { get; set; } = null!;

    [StringLength(50)]
    public string contAccDes { get; set; } = null!;

    [StringLength(26)]
    public string? parentAcc { get; set; }

    [StringLength(26)]
    public string accCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal credit { get; set; }

    [Column(TypeName = "money")]
    public decimal debit { get; set; }

    [StringLength(26)]
    public string period { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? balance { get; set; }

    [StringLength(50)]
    public string accDes { get; set; } = null!;

    [StringLength(26)]
    public string periodCode { get; set; } = null!;

    public string periodName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime end { get; set; }

    [StringLength(50)]
    public string trialBalanceType { get; set; } = null!;
}
