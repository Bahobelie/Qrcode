using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LineitemActivityRangeInMin
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public int? TotalTimeInMin { get; set; }

    [StringLength(56)]
    [Unicode(false)]
    public string? TotalTime { get; set; }
}
