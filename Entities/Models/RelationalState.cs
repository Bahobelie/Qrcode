using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RelationalState", Schema = "common")]
[Index("code", Name = "IX_RelationalState", IsUnique = true)]
public partial class RelationalState
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string relation { get; set; } = null!;

    [StringLength(26)]
    public string state { get; set; } = null!;

    [StringLength(20)]
    public string? criteria { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("relation")]
    [InverseProperty("RelationalStates")]
    public virtual Relation relationNavigation { get; set; } = null!;

    [ForeignKey("state")]
    [InverseProperty("RelationalStates")]
    public virtual ObjectState stateNavigation { get; set; } = null!;
}
