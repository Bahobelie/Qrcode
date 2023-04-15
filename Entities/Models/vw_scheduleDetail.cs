using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_scheduleDetail
{
    [StringLength(50)]
    public string? scheduleDesc { get; set; }

    [StringLength(26)]
    public string? reference { get; set; }

    [StringLength(26)]
    public string? headerCode { get; set; }

    [StringLength(26)]
    public string? dayMonth { get; set; }

    [StringLength(26)]
    public string? startTime { get; set; }

    [StringLength(26)]
    public string? endTime { get; set; }

    public byte? dayOfMonth { get; set; }

    [StringLength(100)]
    public string? detailRemark { get; set; }

    [StringLength(50)]
    public string headerDesc { get; set; } = null!;

    [StringLength(26)]
    public string headerCategory { get; set; } = null!;

    [StringLength(26)]
    public string headerType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime startDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endDate { get; set; }

    public bool isActive { get; set; }

    [StringLength(50)]
    public string? headerTypeDesc { get; set; }

    [StringLength(26)]
    public string scheduleCode { get; set; } = null!;

    [StringLength(26)]
    public string detailCode { get; set; } = null!;
}
