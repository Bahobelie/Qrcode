using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Subtitle", Schema = "PMS")]
public partial class Subtitle
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string media { get; set; } = null!;

    [StringLength(26)]
    public string language { get; set; } = null!;

    [StringLength(40)]
    public string url { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("language")]
    [InverseProperty("Subtitles")]
    public virtual Language languageNavigation { get; set; } = null!;

    [ForeignKey("media")]
    [InverseProperty("Subtitles")]
    public virtual CNETMedium mediaNavigation { get; set; } = null!;
}
