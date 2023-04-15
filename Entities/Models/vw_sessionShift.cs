using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_sessionShift
{
    [StringLength(26)]
    public string sessionCode { get; set; } = null!;

    public string sessionDescription { get; set; } = null!;

    [StringLength(26)]
    public string sessionType { get; set; } = null!;

    [StringLength(26)]
    public string sessionState { get; set; } = null!;

    public TimeSpan inTime { get; set; }

    public bool inMandatory { get; set; }

    public TimeSpan outTime { get; set; }

    public bool outMandatory { get; set; }

    public bool isCrossDay { get; set; }

    public int shiftIndex { get; set; }

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime shiftDate { get; set; }

    [StringLength(26)]
    public string shiftState { get; set; } = null!;

    [StringLength(26)]
    public string shiftCode { get; set; } = null!;

    [Column(TypeName = "decimal(5, 2)")]
    public decimal duration { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? dayPortion { get; set; }
}
