using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Font", Schema = "common")]
[Index("code", Name = "IX_Font", IsUnique = true)]
public partial class Font
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string face { get; set; } = null!;

    [StringLength(50)]
    public string color { get; set; } = null!;

    [StringLength(26)]
    public string style { get; set; } = null!;

    public byte size { get; set; }

    public bool isDefault { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("face")]
    [InverseProperty("Fonts")]
    public virtual Face faceNavigation { get; set; } = null!;
}
