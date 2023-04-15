using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ScheduleValueView
{
    [StringLength(26)]
    public string ValueCode { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string? reference { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime startDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endDate { get; set; }

    public bool isActive { get; set; }

    [StringLength(26)]
    public string? dayMonth { get; set; }

    [StringLength(26)]
    public string? startTime { get; set; }

    [StringLength(26)]
    public string? endTime { get; set; }
}
