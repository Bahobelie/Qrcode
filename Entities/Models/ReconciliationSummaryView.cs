using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ReconciliationSummaryView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string name { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string comparision { get; set; } = null!;

    [StringLength(26)]
    public string comparisionType { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(50)]
    public string? comparisiond { get; set; }

    [StringLength(50)]
    public string? comparisionTyped { get; set; }
}
