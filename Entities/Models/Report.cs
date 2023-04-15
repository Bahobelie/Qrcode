using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Report", Schema = "common")]
public partial class Report
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public byte Index { get; set; }

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(50)]
    public string category { get; set; } = null!;

    public string reportType { get; set; } = null!;

    [StringLength(100)]
    public string? reference { get; set; }

    [StringLength(100)]
    public string defaultName { get; set; } = null!;

    [StringLength(100)]
    public string? customName { get; set; }

    [StringLength(450)]
    public string description { get; set; } = null!;

    public bool IsActive { get; set; }

    [StringLength(256)]
    public string? url { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("reference3")]
    public virtual ICollection<AccessMatrix> AccessMatrices { get; } = new List<AccessMatrix>();
}
