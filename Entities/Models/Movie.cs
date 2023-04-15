using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Movie", Schema = "PMS")]
public partial class Movie
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string media { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime releaseDate { get; set; }

    [StringLength(26)]
    public string duration { get; set; } = null!;

    public string director { get; set; } = null!;

    public string actors { get; set; } = null!;

    public string plot { get; set; } = null!;

    public string? writer { get; set; }

    public string? producer { get; set; }

    [StringLength(26)]
    public string? dimension { get; set; }

    [StringLength(26)]
    public string? movielanguage { get; set; }

    [StringLength(26)]
    public string? subtitlelanguage { get; set; }

    [StringLength(26)]
    public string? rating { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("media")]
    [InverseProperty("Movies")]
    public virtual CNETMedium mediaNavigation { get; set; } = null!;
}
