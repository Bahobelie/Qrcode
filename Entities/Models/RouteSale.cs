using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RouteSales", Schema = "common")]
public partial class RouteSale
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? description { get; set; }

    [StringLength(26)]
    public string orgUnit { get; set; } = null!;

    [StringLength(26)]
    public string space { get; set; } = null!;

    [StringLength(26)]
    public string scheduleHeader { get; set; } = null!;

    public string? remark { get; set; }

    [ForeignKey("orgUnit")]
    [InverseProperty("RouteSales")]
    public virtual OrganizationUnitDefinition orgUnitNavigation { get; set; } = null!;

    [ForeignKey("scheduleHeader")]
    [InverseProperty("RouteSales")]
    public virtual ScheduleHeader scheduleHeaderNavigation { get; set; } = null!;

    [ForeignKey("space")]
    [InverseProperty("RouteSales")]
    public virtual Space spaceNavigation { get; set; } = null!;
}
