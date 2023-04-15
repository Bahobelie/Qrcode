using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("SpaceDirection", Schema = "common")]
public partial class SpaceDirection
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string device { get; set; } = null!;

    [StringLength(26)]
    public string space { get; set; } = null!;

    [StringLength(26)]
    public string direction { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("device")]
    [InverseProperty("SpaceDirections")]
    public virtual Device deviceNavigation { get; set; } = null!;

    [ForeignKey("direction")]
    [InverseProperty("SpaceDirections")]
    public virtual Lookup directionNavigation { get; set; } = null!;

    [ForeignKey("space")]
    [InverseProperty("SpaceDirections")]
    public virtual Space spaceNavigation { get; set; } = null!;
}
