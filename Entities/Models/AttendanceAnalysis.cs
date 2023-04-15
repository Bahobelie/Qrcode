using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("AttendanceAnalysis", Schema = "hrms")]
public partial class AttendanceAnalysis
{
    public Guid id { get; set; }

    [Key]
    public int code { get; set; }

    [StringLength(26)]
    public string person { get; set; } = null!;

    [StringLength(26)]
    public string shift { get; set; } = null!;

    public TimeSpan inTime { get; set; }

    [StringLength(26)]
    public string inStatus { get; set; } = null!;

    public TimeSpan outTime { get; set; }

    [StringLength(26)]
    public string outStatus { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal workHour { get; set; }

    [StringLength(26)]
    public string? dayStatus { get; set; }

    [Column("lock")]
    public bool? _lock { get; set; }

    public string? remark { get; set; }

    [ForeignKey("shift")]
    [InverseProperty("AttendanceAnalyses")]
    public virtual Shift shiftNavigation { get; set; } = null!;
}
