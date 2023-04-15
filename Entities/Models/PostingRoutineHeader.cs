using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("PostingRoutineHeader", Schema = "common")]
public partial class PostingRoutineHeader
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(500)]
    public string description { get; set; } = null!;

    [StringLength(100)]
    public string frequency { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    public string? note { get; set; }

    [StringLength(500)]
    public string? remark { get; set; }

    [InverseProperty("postingRoutineHeaderNavigation")]
    public virtual ICollection<PostingRoutineDetail> PostingRoutineDetails { get; } = new List<PostingRoutineDetail>();

    [ForeignKey("component")]
    [InverseProperty("PostingRoutineHeaders")]
    public virtual CNETComponent componentNavigation { get; set; } = null!;
}
