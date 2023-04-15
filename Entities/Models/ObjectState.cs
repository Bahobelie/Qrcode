using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ObjectState", Schema = "common")]
[Index("code", Name = "IX_ObjectState", IsUnique = true)]
[Index("reference", "objectStateDefinition", Name = "_dta_index_ObjectState_5_1883869778__K3_K4")]
public partial class ObjectState
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string objectStateDefinition { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("stateNavigation")]
    public virtual ICollection<RelationalState> RelationalStates { get; } = new List<RelationalState>();

    [ForeignKey("reference")]
    [InverseProperty("ObjectStates")]
    public virtual Organization reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("ObjectStates")]
    public virtual Person reference2 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("ObjectStates")]
    public virtual Voucher reference3 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("ObjectStates")]
    public virtual Article referenceNavigation { get; set; } = null!;
}
