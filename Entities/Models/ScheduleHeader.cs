using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ScheduleHeader", Schema = "common")]
[Index("code", Name = "IX_TaskSetup", IsUnique = true)]
public partial class ScheduleHeader
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string cateogry { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime startDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endDate { get; set; }

    public bool isActive { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("scheduleHeaderNavigation")]
    public virtual ICollection<ProcessTaskMap> ProcessTaskMaps { get; } = new List<ProcessTaskMap>();

    [InverseProperty("scheduleHeaderNavigation")]
    public virtual ICollection<RouteSale> RouteSales { get; } = new List<RouteSale>();

    [InverseProperty("scheduledHeaderNavigation")]
    public virtual ICollection<Schedule> Schedules { get; } = new List<Schedule>();

    [ForeignKey("cateogry")]
    [InverseProperty("ScheduleHeadercateogryNavigations")]
    public virtual Lookup cateogryNavigation { get; set; } = null!;

    [ForeignKey("type")]
    [InverseProperty("ScheduleHeadertypeNavigations")]
    public virtual Lookup typeNavigation { get; set; } = null!;
}
