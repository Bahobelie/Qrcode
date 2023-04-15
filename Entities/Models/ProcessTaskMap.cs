using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ProcessTaskMap", Schema = "common")]
[Index("code", Name = "IX_ProcessTaskMap", IsUnique = true)]
public partial class ProcessTaskMap
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string process { get; set; } = null!;

    [StringLength(26)]
    public string scheduleHeader { get; set; } = null!;

    [StringLength(26)]
    public string alertType { get; set; } = null!;

    [StringLength(26)]
    public string alertValue { get; set; } = null!;

    [StringLength(26)]
    public string? trigger { get; set; }

    public int? responseToExpiry { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("alertType")]
    [InverseProperty("ProcessTaskMaps")]
    public virtual Lookup alertTypeNavigation { get; set; } = null!;

    [ForeignKey("process")]
    [InverseProperty("ProcessTaskMaps")]
    public virtual Process processNavigation { get; set; } = null!;

    [ForeignKey("scheduleHeader")]
    [InverseProperty("ProcessTaskMaps")]
    public virtual ScheduleHeader scheduleHeaderNavigation { get; set; } = null!;
}
