using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("LanguageOfInterest", Schema = "common")]
[Index("code", Name = "IX_LanguageOfInterest", IsUnique = true)]
public partial class LanguageOfInterest
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string person { get; set; } = null!;

    [StringLength(26)]
    public string language { get; set; } = null!;

    [StringLength(26)]
    public string? proficiency { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("language")]
    [InverseProperty("LanguageOfInterests")]
    public virtual Language languageNavigation { get; set; } = null!;

    [ForeignKey("person")]
    [InverseProperty("LanguageOfInterests")]
    public virtual Person personNavigation { get; set; } = null!;
}
