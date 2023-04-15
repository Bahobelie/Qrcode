using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("AccessMatrix", Schema = "common")]
[Index("Code", Name = "IX_AccessMatrix", IsUnique = true)]
public partial class AccessMatrix
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string Code { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    /// <summary>
    /// Can Be:Lookup (common),Preference (common)
    /// </summary>
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string role { get; set; } = null!;

    [StringLength(26)]
    public string accessLevel { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("reference")]
    [InverseProperty("AccessMatrices")]
    public virtual Device reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("AccessMatrices")]
    public virtual Functionality reference2 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("AccessMatrices")]
    public virtual Report reference3 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("AccessMatrices")]
    public virtual CNETComponent referenceNavigation { get; set; } = null!;

    [ForeignKey("role")]
    [InverseProperty("AccessMatrices")]
    public virtual Preference roleNavigation { get; set; } = null!;
}
