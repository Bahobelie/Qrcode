using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_OrgaUnitDevice
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    public string name { get; set; } = null!;

    [StringLength(26)]
    public string connectionType { get; set; } = null!;

    [StringLength(50)]
    public string conTypeDescription { get; set; } = null!;

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(50)]
    public string? deviceType { get; set; }

    [StringLength(26)]
    public string? host { get; set; }

    public string? hostName { get; set; }

    [StringLength(40)]
    public string? deviceValue { get; set; }

    public bool isActive { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string organizationUnitDefinition { get; set; } = null!;
}
