using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ActivityView
{
    public Guid Id { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string activitiyDefinition { get; set; } = null!;

    public string? ActivitiyDefinition_Desc { get; set; }

    [StringLength(26)]
    public string ActivitiyDefinition_Lookup { get; set; } = null!;

    [StringLength(26)]
    public string? organizationUnitDef { get; set; }

    [StringLength(50)]
    public string? organizationUnitDefnDesc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime startTimStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endTimStamp { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    public string? DeviceName { get; set; }

    [StringLength(26)]
    public string? user { get; set; }

    [StringLength(30)]
    public string? user_name { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    public bool? isPrint { get; set; }

    public bool isManual { get; set; }
}
