using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_AccountMapView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string accCode { get; set; } = null!;

    [StringLength(50)]
    public string accDes { get; set; } = null!;

    [StringLength(26)]
    public string? parentAccount { get; set; }

    public bool isActive { get; set; }

    [StringLength(26)]
    public string ContolAccountCode { get; set; } = null!;

    [StringLength(50)]
    public string conAccDes { get; set; } = null!;

    [StringLength(15)]
    public string normalBalance { get; set; } = null!;

    [StringLength(15)]
    public string accCategory { get; set; } = null!;

    [StringLength(50)]
    public string accType { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string AccountMapCode { get; set; } = null!;

    [StringLength(50)]
    public string? AccountMapdescription { get; set; }

    [StringLength(26)]
    public string? OrgUnitCode { get; set; }

    [StringLength(26)]
    public string? organizationUnitDefinition { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
