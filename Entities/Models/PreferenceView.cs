using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class PreferenceView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string? font { get; set; }

    [StringLength(26)]
    public string? parent { get; set; }

    public bool isActive { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(50)]
    public string? p_desc { get; set; }

    [StringLength(50)]
    public string? F_desc { get; set; }

    [StringLength(50)]
    public string? value { get; set; }
}
