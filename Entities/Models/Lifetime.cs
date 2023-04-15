using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Lifetime", Schema = "common")]
[Index("code", Name = "IX_Lifetime", IsUnique = true)]
public partial class Lifetime
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(26)]
    public string factor { get; set; } = null!;

    public int value { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("factor")]
    [InverseProperty("Lifetimes")]
    public virtual Lookup factorNavigation { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Lifetimes")]
    public virtual Organization reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Lifetimes")]
    public virtual Person reference2 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Lifetimes")]
    public virtual Article referenceNavigation { get; set; } = null!;
}
