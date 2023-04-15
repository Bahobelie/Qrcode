using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_MovieScheduleCountView
{
    [StringLength(26)]
    public string movie { get; set; } = null!;

    public int? days { get; set; }

    public int? SCHEDULES { get; set; }
}
