using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("PostingSchedule", Schema = "PMS")]
public partial class PostingSchedule
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string packageHeader { get; set; } = null!;

    public int? rhythmValue { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("packageHeader")]
    [InverseProperty("PostingSchedules")]
    public virtual PackageHeader packageHeaderNavigation { get; set; } = null!;
}
