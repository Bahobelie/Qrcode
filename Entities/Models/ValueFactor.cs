using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ValueFactor", Schema = "common")]
[Index("code", Name = "IX_ValueFactor", IsUnique = true)]
public partial class ValueFactor
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string factorDfnRef { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("component")]
    [InverseProperty("ValueFactors")]
    public virtual CNETComponent componentNavigation { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("ValueFactors")]
    public virtual Organization reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("ValueFactors")]
    public virtual Person reference2 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("ValueFactors")]
    public virtual TermList reference3 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("ValueFactors")]
    public virtual Article referenceNavigation { get; set; } = null!;
}
