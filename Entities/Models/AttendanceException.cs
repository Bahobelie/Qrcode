using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("AttendanceException", Schema = "hrms")]
public partial class AttendanceException
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime date { get; set; }

    [StringLength(26)]
    public string session { get; set; } = null!;

    public string? remark { get; set; }
}
