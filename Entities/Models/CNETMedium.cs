using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("CNETMedia", Schema = "PMS")]
public partial class CNETMedium
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string name { get; set; } = null!;

    public string description { get; set; } = null!;

    [StringLength(1000)]
    public string streamURL { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string category { get; set; } = null!;

    [StringLength(26)]
    public string? article { get; set; }

    public int? index { get; set; }

    public bool? active { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("mediaNavigation")]
    public virtual ICollection<Movie> Movies { get; } = new List<Movie>();

    [InverseProperty("mediaNavigation")]
    public virtual ICollection<Subtitle> Subtitles { get; } = new List<Subtitle>();

    [ForeignKey("article")]
    [InverseProperty("CNETMedia")]
    public virtual Article? articleNavigation { get; set; }

    [ForeignKey("category")]
    [InverseProperty("CNETMediumcategoryNavigations")]
    public virtual Lookup categoryNavigation { get; set; } = null!;

    [ForeignKey("type")]
    [InverseProperty("CNETMediumtypeNavigations")]
    public virtual Lookup typeNavigation { get; set; } = null!;
}
