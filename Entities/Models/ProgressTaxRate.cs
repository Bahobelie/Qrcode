using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ProgressTaxRate", Schema = "common")]
public partial class ProgressTaxRate
{
    public Guid? Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? taxCode { get; set; }

    [StringLength(26)]
    public string? range { get; set; }

    [StringLength(50)]
    public string? description { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? rate { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Constant { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
