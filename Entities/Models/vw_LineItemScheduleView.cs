using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LineItemScheduleView
{
    [StringLength(26)]
    public string? LineItem { get; set; }

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(50)]
    public string ScheduleDescription { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime startDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endDate { get; set; }
}
