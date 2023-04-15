using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("DeviceSchedule", Schema = "common")]
[Index("Code", Name = "IX_DeviceSchedule", IsUnique = true)]
public partial class DeviceSchedule
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string Code { get; set; } = null!;

    [StringLength(50)]
    public string Description { get; set; } = null!;

    [StringLength(26)]
    public string Device { get; set; } = null!;

    [StringLength(26)]
    public string ScheduleTask { get; set; } = null!;

    [StringLength(100)]
    public string? Remark { get; set; }

    [ForeignKey("Device")]
    [InverseProperty("DeviceSchedules")]
    public virtual Device DeviceNavigation { get; set; } = null!;
}
