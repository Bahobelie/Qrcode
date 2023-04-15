using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Branch", Schema = "ecommerce")]
public partial class Branch
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? branchCode { get; set; }

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(50)]
    public string? specialization { get; set; }

    [StringLength(50)]
    public string? specializationDescription { get; set; }

    public double? latitude { get; set; }

    public double? longitude { get; set; }

    [StringLength(50)]
    public string? city { get; set; }

    [StringLength(50)]
    public string? phone { get; set; }

    [StringLength(50)]
    public string? tin { get; set; }
}
