using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Log", Schema = "common")]
[Index("code", Name = "IX_Log", IsUnique = true)]
public partial class Log
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string activity { get; set; } = null!;

    [StringLength(75)]
    public string description { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("activity")]
    [InverseProperty("Logs")]
    public virtual Activity activityNavigation { get; set; } = null!;
}
