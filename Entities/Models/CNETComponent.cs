using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("CNETComponent", Schema = "common")]
[Index("code", Name = "IX_Component", IsUnique = true)]
public partial class CNETComponent
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string? parent { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<AccessMatrix> AccessMatrices { get; } = new List<AccessMatrix>();

    [InverseProperty("componentNavigation")]
    public virtual ICollection<Activity> Activities { get; } = new List<Activity>();

    [InverseProperty("moduleNavigation")]
    public virtual ICollection<CaseDetail> CaseDetails { get; } = new List<CaseDetail>();

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<Configuration> Configurations { get; } = new List<Configuration>();

    [InverseProperty("ComponentNavigation")]
    public virtual ICollection<DiscountFactor> DiscountFactors { get; } = new List<DiscountFactor>();

    [InverseProperty("componentNavigation")]
    public virtual ICollection<Distribution> Distributions { get; } = new List<Distribution>();

    [InverseProperty("moduleNavigation")]
    public virtual ICollection<EscalationDetail> EscalationDetails { get; } = new List<EscalationDetail>();

    [InverseProperty("subsystemComponentNavigation")]
    public virtual ICollection<Functionality> FunctionalitysubsystemComponentNavigations { get; } = new List<Functionality>();

    [InverseProperty("visualComponentNavigation")]
    public virtual ICollection<Functionality> FunctionalityvisualComponentNavigations { get; } = new List<Functionality>();

    [InverseProperty("parentNavigation")]
    public virtual ICollection<CNETComponent> InverseparentNavigation { get; } = new List<CNETComponent>();

    [InverseProperty("componentNavigation")]
    public virtual ICollection<LifeSpan> LifeSpans { get; } = new List<LifeSpan>();

    [InverseProperty("componentNavigation")]
    public virtual ICollection<MenuDesigner> MenuDesigners { get; } = new List<MenuDesigner>();

    [InverseProperty("componentNavigation")]
    public virtual ICollection<MultiOrganization> MultiOrganizations { get; } = new List<MultiOrganization>();

    [InverseProperty("componentNavigation")]
    public virtual ICollection<PostingRoutineHeader> PostingRoutineHeaders { get; } = new List<PostingRoutineHeader>();

    [InverseProperty("componentNavigation")]
    public virtual ICollection<RoomFeature> RoomFeatures { get; } = new List<RoomFeature>();

    [InverseProperty("componentNavigation")]
    public virtual ICollection<TranRoutingHeader> TranRoutingHeaders { get; } = new List<TranRoutingHeader>();

    [InverseProperty("componentNavigation")]
    public virtual ICollection<ValueFactor> ValueFactors { get; } = new List<ValueFactor>();

    [InverseProperty("componentNavigation")]
    public virtual ICollection<WeekDay> WeekDays { get; } = new List<WeekDay>();

    [ForeignKey("parent")]
    [InverseProperty("InverseparentNavigation")]
    public virtual CNETComponent? parentNavigation { get; set; }
}
