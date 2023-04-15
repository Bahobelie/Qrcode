using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_AttendanceIdentification
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string identification { get; set; } = null!;

    public string machineId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime timestamp { get; set; }

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
