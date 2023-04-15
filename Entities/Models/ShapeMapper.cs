using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ShapeMapper", Schema = "common")]
public partial class ShapeMapper
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string componenet { get; set; } = null!;

    [StringLength(26)]
    public string refrence { get; set; } = null!;

    [StringLength(36)]
    public string shapeid { get; set; } = null!;

    [StringLength(50)]
    public string? remark { get; set; }
}
