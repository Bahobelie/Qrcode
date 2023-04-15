using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RateAdjustment", Schema = "PMS")]
public partial class RateAdjustment
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string registrationNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime startDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endDate { get; set; }

    public bool isPercent { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal amount { get; set; }

    [Column(TypeName = "money")]
    public decimal value { get; set; }

    [StringLength(100)]
    public string? reason { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
