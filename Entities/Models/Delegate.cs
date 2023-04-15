using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Delegate", Schema = "common")]
[Index("Code", Name = "IX_Delegate", IsUnique = true)]
public partial class Delegate
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string Code { get; set; } = null!;

    [StringLength(26)]
    public string Delegating { get; set; } = null!;

    [StringLength(26)]
    public string Delegated { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime startTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endTimeStamp { get; set; }

    public bool isActive { get; set; }

    [StringLength(100)]
    public string? Remark { get; set; }

    [ForeignKey("Delegated")]
    [InverseProperty("DelegateDelegatedNavigations")]
    public virtual User DelegatedNavigation { get; set; } = null!;

    [ForeignKey("Delegating")]
    [InverseProperty("DelegateDelegatingNavigations")]
    public virtual User DelegatingNavigation { get; set; } = null!;
}
