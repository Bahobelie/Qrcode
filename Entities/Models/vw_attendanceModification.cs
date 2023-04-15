using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_attendanceModification
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string? user { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime startTimStamp { get; set; }

    public TimeSpan inTime { get; set; }

    [StringLength(26)]
    public string inStatus { get; set; } = null!;

    public TimeSpan outTime { get; set; }

    [StringLength(26)]
    public string outStatus { get; set; } = null!;

    [StringLength(26)]
    public string person { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime shiftDate { get; set; }
}
