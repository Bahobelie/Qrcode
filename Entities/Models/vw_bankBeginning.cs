using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_bankBeginning
{
    [StringLength(26)]
    public string OrganizationCode { get; set; } = null!;

    public string TradeName { get; set; } = null!;

    public string? BrandName { get; set; }

    [StringLength(26)]
    public string BranchCode { get; set; } = null!;

    [StringLength(50)]
    public string BranchName { get; set; } = null!;

    [StringLength(50)]
    public string? AccountDescription { get; set; }

    [StringLength(40)]
    public string AccountNo { get; set; } = null!;

    [StringLength(26)]
    public string? Period { get; set; }

    [Column(TypeName = "money")]
    public decimal Amount { get; set; }

    [StringLength(50)]
    public string? type { get; set; }

    [StringLength(26)]
    public string? PeriodDescription { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? end { get; set; }
}
