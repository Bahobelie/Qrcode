using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Career", Schema = "hrms")]
public partial class Career
{
    public Guid id { get; set; }

    [Key]
    [StringLength(50)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string type { get; set; } = null!;

    [StringLength(50)]
    public string person { get; set; } = null!;

    public int index { get; set; }

    [StringLength(50)]
    public string organization { get; set; } = null!;

    [StringLength(50)]
    public string level { get; set; } = null!;

    [StringLength(50)]
    public string field { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime startDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endDate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal duration { get; set; }

    public string? award { get; set; }

    public string? note { get; set; }

    [StringLength(50)]
    public string? status { get; set; }

    public string? remark { get; set; }
}
