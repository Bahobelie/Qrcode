using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ScheduleDetail", Schema = "common")]
[Index("code", Name = "IX_ScheduleTime", IsUnique = true)]
public partial class ScheduleDetail
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string Seheduleheader { get; set; } = null!;

    [StringLength(26)]
    public string? dayMonth { get; set; }

    [StringLength(26)]
    public string? startTime { get; set; }

    [StringLength(26)]
    public string? endTime { get; set; }

    public byte? dayOfMonth { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
