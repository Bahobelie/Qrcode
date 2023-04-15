using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Face", Schema = "common")]
[Index("code", Name = "IX_Face", IsUnique = true)]
public partial class Face
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string language { get; set; } = null!;

    [Column("face")]
    [StringLength(40)]
    public string face1 { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("faceNavigation")]
    public virtual ICollection<Font> Fonts { get; } = new List<Font>();

    [ForeignKey("language")]
    [InverseProperty("Faces")]
    public virtual Language languageNavigation { get; set; } = null!;
}
