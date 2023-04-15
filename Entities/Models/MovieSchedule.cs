using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("MovieSchedule", Schema = "cinema")]
public partial class MovieSchedule
{
    public string id { get; set; } = null!;

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string orgUnit { get; set; } = null!;

    [StringLength(26)]
    public string movie { get; set; } = null!;

    [StringLength(26)]
    public string space { get; set; } = null!;

    [StringLength(26)]
    public string scheduleHeader { get; set; } = null!;

    [StringLength(50)]
    public string? dimension { get; set; }

    [Column(TypeName = "money")]
    public decimal value { get; set; }

    public string? remark { get; set; }
}
