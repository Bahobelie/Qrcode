using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_TerminatedNonClearedEmployee
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    public string? fullName { get; set; }

    [StringLength(50)]
    public string title { get; set; } = null!;

    [StringLength(50)]
    public string department { get; set; } = null!;

    public bool IsIssued { get; set; }

    public string? AsOfDate { get; set; }

    [StringLength(26)]
    public string lookup { get; set; } = null!;

    [StringLength(75)]
    public string type { get; set; } = null!;

    public string description { get; set; } = null!;
}
