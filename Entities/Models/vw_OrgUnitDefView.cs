using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_OrgUnitDefView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string? abbriviation { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string? parentId { get; set; }

    [StringLength(50)]
    public string? specialization { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string orguntCode { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(50)]
    public string? ORGtype { get; set; }

    [StringLength(50)]
    public string? ORGspecialization { get; set; }
}
