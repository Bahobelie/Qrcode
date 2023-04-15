using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Shift", Schema = "hrms")]
public partial class Shift
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int index { get; set; }

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime date { get; set; }

    [StringLength(26)]
    public string state { get; set; } = null!;

    [StringLength(26)]
    public string session { get; set; } = null!;

    public string? remark { get; set; }

    [InverseProperty("shiftNavigation")]
    public virtual ICollection<AttendanceAnalysis> AttendanceAnalyses { get; } = new List<AttendanceAnalysis>();
}
