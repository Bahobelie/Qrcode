using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("SeasonalMessage", Schema = "common")]
[Index("code", Name = "IX_SeasonalMessage", IsUnique = true)]
public partial class SeasonalMessage
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string message { get; set; } = null!;

    [StringLength(26)]
    public string period { get; set; } = null!;

    [StringLength(26)]
    public string? font { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("period")]
    [InverseProperty("SeasonalMessages")]
    public virtual Period periodNavigation { get; set; } = null!;
}
