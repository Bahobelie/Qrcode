using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("HKAssignment", Schema = "PMS")]
public partial class HKAssignment
{
    public Guid? id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? roomDetail { get; set; }

    [StringLength(26)]
    public string? employee { get; set; }

    [Column(TypeName = "date")]
    public DateTime? date { get; set; }

    [StringLength(26)]
    public string? task { get; set; }

    public double? credit { get; set; }

    [StringLength(26)]
    public string? organizationunitdef { get; set; }

    [StringLength(26)]
    public string? remark { get; set; }

    [ForeignKey("roomDetail")]
    [InverseProperty("HKAssignments")]
    public virtual RoomDetail? roomDetailNavigation { get; set; }
}
