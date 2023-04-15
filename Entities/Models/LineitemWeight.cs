using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("LineitemWeight", Schema = "common")]
public partial class LineitemWeight
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? lineitem { get; set; }

    public int index { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? timeStamp { get; set; }

    public double? startWt { get; set; }

    public double? endWt { get; set; }

    public double? netWt { get; set; }

    public double? articleWt { get; set; }

    public double? variation { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("lineitem")]
    [InverseProperty("LineitemWeights")]
    public virtual LineItem? lineitemNavigation { get; set; }
}
