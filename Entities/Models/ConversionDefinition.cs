using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ConversionDefinition", Schema = "common")]
public partial class ConversionDefinition
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    public int index { get; set; }

    [StringLength(50)]
    public string fromUOM { get; set; } = null!;

    public double fromQty { get; set; }

    [StringLength(50)]
    public string toUOM { get; set; } = null!;

    public double toQty { get; set; }

    public string? remark { get; set; }
}
