using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_chartOfAccountDetail
{
    [StringLength(26)]
    public string accountCode { get; set; } = null!;

    [StringLength(26)]
    public string controlAccount { get; set; } = null!;

    [StringLength(50)]
    public string accountDescription { get; set; } = null!;

    [StringLength(26)]
    public string? parentAccount { get; set; }

    public bool isActive { get; set; }

    [StringLength(26)]
    public string ContolAccountCode { get; set; } = null!;

    [StringLength(50)]
    public string controlAccountDescription { get; set; } = null!;

    [StringLength(15)]
    public string normalBalance { get; set; } = null!;

    [StringLength(15)]
    public string accountCategory { get; set; } = null!;

    [StringLength(50)]
    public string accountType { get; set; } = null!;

    [StringLength(26)]
    public string? AccountMapCode { get; set; }

    [StringLength(50)]
    public string? AccountMapdescription { get; set; }

    [StringLength(26)]
    public string? reference { get; set; }

    [StringLength(26)]
    public string? OrgUnitCode { get; set; }

    [StringLength(26)]
    public string? branchCode { get; set; }

    [StringLength(50)]
    public string? branchDescription { get; set; }

    [StringLength(100)]
    public string? preferenceDescription { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
