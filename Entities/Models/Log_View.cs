using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Log_View
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string activity { get; set; } = null!;

    [StringLength(75)]
    public string description { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string reference { get; set; } = null!;
}
