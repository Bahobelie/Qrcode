using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_MovieView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string mediacode { get; set; } = null!;

    [StringLength(50)]
    public string moviename { get; set; } = null!;

    public string description { get; set; } = null!;

    [StringLength(50)]
    public string moviecategory { get; set; } = null!;

    [StringLength(26)]
    public string? article { get; set; }

    public bool? active { get; set; }

    [Column(TypeName = "date")]
    public DateTime releaseDate { get; set; }

    [StringLength(26)]
    public string duration { get; set; } = null!;

    public string director { get; set; } = null!;

    public string actors { get; set; } = null!;

    public string? writer { get; set; }

    public string? producer { get; set; }

    [StringLength(50)]
    public string? dimension { get; set; }

    [StringLength(50)]
    public string? rating { get; set; }

    public string plot { get; set; } = null!;

    [StringLength(26)]
    public string? movielanguage { get; set; }

    [StringLength(26)]
    public string? subtitlelanguage { get; set; }

    [StringLength(26)]
    public string movieCategoryCode { get; set; } = null!;
}
