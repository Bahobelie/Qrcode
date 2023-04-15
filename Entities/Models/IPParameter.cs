using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("IPParameter", Schema = "common")]
[Index("code", Name = "IX_IPParameter", IsUnique = true)]
public partial class IPParameter
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string device { get; set; } = null!;

    [StringLength(35)]
    public string ip { get; set; } = null!;

    [StringLength(5)]
    public string? port { get; set; }

    [StringLength(30)]
    public string? mac { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("device")]
    [InverseProperty("IPParameters")]
    public virtual Device deviceNavigation { get; set; } = null!;
}
