using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ReportHistory", Schema = "PMS")]
public partial class ReportHistory
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(50)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string report { get; set; } = null!;

    public string description { get; set; } = null!;

    [StringLength(1000)]
    public string? reference { get; set; }

    [StringLength(50)]
    public string? period { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date { get; set; }

    [StringLength(50)]
    public string reportValue { get; set; } = null!;

    [StringLength(50)]
    public string? mtd { get; set; }

    [StringLength(50)]
    public string? ytd { get; set; }

    public string? remark { get; set; }
}
