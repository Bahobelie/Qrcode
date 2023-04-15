using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_JobCardActivityDetailRange
{
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? startTimStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endTimStamp { get; set; }

    [StringLength(68)]
    [Unicode(false)]
    public string? ElapsedTime { get; set; }

    [StringLength(26)]
    public string? userCode { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    public string? technicianName { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
