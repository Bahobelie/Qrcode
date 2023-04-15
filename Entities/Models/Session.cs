using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Session", Schema = "hrms")]
public partial class Session
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public string description { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string state { get; set; } = null!;

    public TimeSpan inTime { get; set; }

    public bool inMandatory { get; set; }

    public TimeSpan outTime { get; set; }

    public bool outMandatory { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? duration { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? dayPortion { get; set; }

    public bool isCrossDay { get; set; }

    public string? remark { get; set; }
}
