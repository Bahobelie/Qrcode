using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class MovieDTO{
    public int Id { get; set; }
    public int Media { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Duration { get; set; } = null!;
    public string Director { get; set; } = null!;
    public string Actors { get; set; } = null!;
    public string Plot { get; set; } = null!;
    public string? Writer { get; set; }
    public string? Producer { get; set; }
    public int? Dimension { get; set; }
    public string? Movielanguage { get; set; }
    public string? Subtitlelanguage { get; set; }
    public string? Rating { get; set; }
    public string? Remark { get; set; }
}
