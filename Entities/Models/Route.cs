using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Route", Schema = "common")]
public partial class Route
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string transportType { get; set; } = null!;

    [StringLength(26)]
    public string carrier { get; set; } = null!;

    [StringLength(26)]
    public string? state { get; set; }

    [StringLength(26)]
    public string fromCity { get; set; } = null!;

    [StringLength(26)]
    public string fromStation { get; set; } = null!;

    [StringLength(26)]
    public string toCity { get; set; } = null!;

    [StringLength(26)]
    public string toStation { get; set; } = null!;

    public double? distance { get; set; }

    public double? duration { get; set; }

    public string? remark { get; set; }
}
