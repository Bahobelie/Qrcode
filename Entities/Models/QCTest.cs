using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("QCTest", Schema = "Production")]
public partial class QCTest
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string qcBenchmark { get; set; } = null!;

    [StringLength(50)]
    public string batch { get; set; } = null!;

    [StringLength(26)]
    public string activity { get; set; } = null!;

    [StringLength(50)]
    public string? measuredValue { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("activity")]
    [InverseProperty("QCTests")]
    public virtual Activity activityNavigation { get; set; } = null!;
}
