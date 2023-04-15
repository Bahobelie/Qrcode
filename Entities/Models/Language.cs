using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Language", Schema = "common")]
[Index("code", Name = "IX_Language", IsUnique = true)]
public partial class Language
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string objectType { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("languageNavigation")]
    public virtual ICollection<Face> Faces { get; } = new List<Face>();

    [InverseProperty("languageNavigation")]
    public virtual ICollection<LanguageOfInterest> LanguageOfInterests { get; } = new List<LanguageOfInterest>();

    [InverseProperty("languageNavigation")]
    public virtual ICollection<Subtitle> Subtitles { get; } = new List<Subtitle>();

    [ForeignKey("type")]
    [InverseProperty("Languages")]
    public virtual Lookup typeNavigation { get; set; } = null!;
}
