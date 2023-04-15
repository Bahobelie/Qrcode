using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class view_Lookup
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string message { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string period { get; set; } = null!;

    [StringLength(26)]
    public string? font { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
