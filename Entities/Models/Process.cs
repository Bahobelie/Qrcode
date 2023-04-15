using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Process", Schema = "common")]
[Index("code", Name = "IX_Process", IsUnique = true)]
public partial class Process
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string category { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("processNavigation")]
    public virtual ICollection<ProcessTaskMap> ProcessTaskMaps { get; } = new List<ProcessTaskMap>();

    [ForeignKey("category")]
    [InverseProperty("ProcesscategoryNavigations")]
    public virtual Lookup categoryNavigation { get; set; } = null!;

    [ForeignKey("type")]
    [InverseProperty("ProcesstypeNavigations")]
    public virtual Lookup typeNavigation { get; set; } = null!;
}
