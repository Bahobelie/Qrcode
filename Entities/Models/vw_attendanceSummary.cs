using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_attendanceSummary
{
    [StringLength(26)]
    public string? code { get; set; }

    [StringLength(26)]
    public string empCode { get; set; } = null!;

    public string? fullName { get; set; }

    [StringLength(26)]
    public string sessionCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime attendanceDate { get; set; }

    public string? sessionDescription { get; set; }

    public TimeSpan inTime { get; set; }

    [StringLength(26)]
    public string inStatusCode { get; set; } = null!;

    public string inStatusDescription { get; set; } = null!;

    public TimeSpan outTime { get; set; }

    [StringLength(26)]
    public string outStatusCode { get; set; } = null!;

    public string? outStatusDescription { get; set; }

    [StringLength(26)]
    public string branchCode { get; set; } = null!;

    [StringLength(26)]
    public string deptCode { get; set; } = null!;

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? dayPortion { get; set; }

    public bool? isCrossDay { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal workHour { get; set; }

    [StringLength(26)]
    public string? type { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal duration { get; set; }

    public string lateInMinutes { get; set; } = null!;

    [Column("lock")]
    public bool? _lock { get; set; }
}
