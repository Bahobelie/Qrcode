using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Schedule", Schema = "common")]
public partial class Schedule
{
    public Guid? id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string? reference { get; set; }

    [StringLength(26)]
    public string? scheduledHeader { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("reference")]
    [InverseProperty("Schedules")]
    public virtual LineItem? referenceNavigation { get; set; }

    [ForeignKey("scheduledHeader")]
    [InverseProperty("Schedules")]
    public virtual ScheduleHeader? scheduledHeaderNavigation { get; set; }
}
