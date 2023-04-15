using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("AttendanceLog", Schema = "common")]
[Index("code", Name = "IX_Attendance", IsUnique = true)]
public partial class AttendanceLog
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string identification { get; set; } = null!;

    public string machineId { get; set; } = null!;

    public bool isSynchronized { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime timestamp { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("identification")]
    [InverseProperty("AttendanceLogs")]
    public virtual Person identificationNavigation { get; set; } = null!;
}
