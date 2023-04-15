using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RoomDetail", Schema = "PMS")]
public partial class RoomDetail
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? space { get; set; }

    [StringLength(50)]
    public string? description { get; set; }

    public int? maxOccupancy { get; set; }

    [StringLength(26)]
    public string roomType { get; set; } = null!;

    [StringLength(26)]
    public string? phoneNumber { get; set; }

    [StringLength(26)]
    public string? area { get; set; }

    public bool? isActive { get; set; }

    [StringLength(50)]
    public string? lastState { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("roomDetailNavigation")]
    public virtual ICollection<Discrepancy> Discrepancies { get; } = new List<Discrepancy>();

    [InverseProperty("roomDetailNavigation")]
    public virtual ICollection<HKAssignment> HKAssignments { get; } = new List<HKAssignment>();

    [InverseProperty("roomDetailNavigation")]
    public virtual ICollection<KeyOption> KeyOptions { get; } = new List<KeyOption>();

    [InverseProperty("roomNavigation")]
    public virtual ICollection<ResidentSummary> ResidentSummaries { get; } = new List<ResidentSummary>();

    [InverseProperty("roomDetailNavigation")]
    public virtual ICollection<TurnDown> TurnDowns { get; } = new List<TurnDown>();

    [ForeignKey("roomType")]
    [InverseProperty("RoomDetails")]
    public virtual RoomType roomTypeNavigation { get; set; } = null!;

    [ForeignKey("space")]
    [InverseProperty("RoomDetails")]
    public virtual Space? spaceNavigation { get; set; }
}
