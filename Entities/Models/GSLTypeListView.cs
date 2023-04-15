using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class GSLTypeListView
{
    public int code { get; set; }

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string category { get; set; } = null!;

    public bool? isActive { get; set; }

    [StringLength(50)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string? prcode { get; set; }
}
