using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class viewFunctWithAccessM
{
    [StringLength(26)]
    public string funcCode { get; set; } = null!;

    [StringLength(26)]
    public string visualComponent { get; set; } = null!;

    [StringLength(26)]
    public string subsystemComponent { get; set; } = null!;

    public string description { get; set; } = null!;

    public string category { get; set; } = null!;

    [StringLength(50)]
    public string function { get; set; } = null!;

    [StringLength(26)]
    public string? matrixCode { get; set; }

    [StringLength(26)]
    public string? role { get; set; }

    [StringLength(26)]
    public string? accessLevel { get; set; }

    [StringLength(26)]
    public string? reference { get; set; }

    public bool? access { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(50)]
    public string visuaCompDesc { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string? parent { get; set; }

    [StringLength(50)]
    public string? ParentDesc { get; set; }
}
