using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class AllVisualControlFunctionality
{
    public Guid id { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string visualComponent { get; set; } = null!;

    [StringLength(26)]
    public string subsystemComponent { get; set; } = null!;

    [StringLength(100)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string category { get; set; } = null!;

    [StringLength(50)]
    public string function { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }
}
