using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("GSLNote", Schema = "common")]
public partial class GSLNote
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string gslReference { get; set; } = null!;

    public string note { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }
}
