using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Translation", Schema = "common")]
[Index("code", Name = "IX_Translation", IsUnique = true)]
public partial class Translation
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(45)]
    public string script { get; set; } = null!;

    [StringLength(26)]
    public string? parameter { get; set; }

    [StringLength(26)]
    public string font { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("reference")]
    [InverseProperty("Translations")]
    public virtual Organization reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Translations")]
    public virtual Person reference2 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Translations")]
    public virtual Article referenceNavigation { get; set; } = null!;
}
