using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Relation", Schema = "common")]
[Index("code", Name = "IX_Relation", IsUnique = true)]
public partial class Relation
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string relationType { get; set; } = null!;

    [StringLength(26)]
    public string referenceObject { get; set; } = null!;

    [StringLength(26)]
    public string referringObject { get; set; } = null!;

    [StringLength(25)]
    public string? relationLevel { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("relationNavigation")]
    public virtual ICollection<RelationDetail> RelationDetails { get; } = new List<RelationDetail>();

    [InverseProperty("relationNavigation")]
    public virtual ICollection<RelationalState> RelationalStates { get; } = new List<RelationalState>();

    [ForeignKey("referenceObject")]
    [InverseProperty("Relations")]
    public virtual Organization referenceObject1 { get; set; } = null!;

    [ForeignKey("referenceObject")]
    [InverseProperty("Relations")]
    public virtual Person referenceObject2 { get; set; } = null!;

    [ForeignKey("referenceObject")]
    [InverseProperty("Relations")]
    public virtual Voucher referenceObject3 { get; set; } = null!;

    [ForeignKey("referenceObject")]
    [InverseProperty("Relations")]
    public virtual Article referenceObjectNavigation { get; set; } = null!;
}
