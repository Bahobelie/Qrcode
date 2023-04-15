using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class scheduleView
{
    public string? fullName { get; set; }

    public bool isActive { get; set; }

    [StringLength(26)]
    public string empCode { get; set; } = null!;

    public string description { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime date { get; set; }

    [StringLength(4000)]
    public string? Monday { get; set; }

    [StringLength(4000)]
    public string? Tuesday { get; set; }

    [StringLength(4000)]
    public string? Wednesday { get; set; }

    [StringLength(4000)]
    public string? Thursday { get; set; }

    [StringLength(4000)]
    public string? Friday { get; set; }

    [StringLength(4000)]
    public string? Saturday { get; set; }

    [StringLength(4000)]
    public string? Sunday { get; set; }
}
