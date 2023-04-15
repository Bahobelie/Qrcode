using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("EffortConsumption", Schema = "Production")]
public partial class EffortConsumption
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string activity { get; set; } = null!;

    [StringLength(50)]
    public string batch { get; set; } = null!;

    [StringLength(26)]
    public string effortType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? end { get; set; }

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("activity")]
    [InverseProperty("EffortConsumptions")]
    public virtual Activity activityNavigation { get; set; } = null!;

    [ForeignKey("effortType")]
    [InverseProperty("EffortConsumptions")]
    public virtual Lookup effortTypeNavigation { get; set; } = null!;
}
