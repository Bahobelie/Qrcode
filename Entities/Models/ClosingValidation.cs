using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ClosingValidation", Schema = "common")]
public partial class ClosingValidation
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string Component { get; set; } = null!;

    [StringLength(26)]
    public string Period { get; set; } = null!;

    public short Status { get; set; }

    [StringLength(26)]
    public string? Device { get; set; }

    [StringLength(26)]
    public string? User { get; set; }

    public string? Remark { get; set; }
}
