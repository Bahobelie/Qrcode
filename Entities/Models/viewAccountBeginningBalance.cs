using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class viewAccountBeginningBalance
{
    [StringLength(26)]
    public string accountNo { get; set; } = null!;

    [StringLength(26)]
    public string? parentAccount { get; set; }

    [StringLength(26)]
    public string controlAccount { get; set; } = null!;

    public bool isActive { get; set; }

    [StringLength(50)]
    public string accountDescription { get; set; } = null!;

    [StringLength(50)]
    public string ContAccDescription { get; set; } = null!;

    [StringLength(50)]
    public string accType { get; set; } = null!;

    [StringLength(15)]
    public string normalBalance { get; set; } = null!;

    [StringLength(26)]
    public string? trialBCode { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [Column(TypeName = "money")]
    public decimal debit { get; set; }

    [Column(TypeName = "money")]
    public decimal credit { get; set; }

    [StringLength(50)]
    public string? trialBalanceType { get; set; }
}
