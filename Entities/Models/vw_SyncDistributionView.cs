﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_SyncDistributionView
{
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string? abbriviation { get; set; }

    [StringLength(26)]
    public string? distributionCode { get; set; }

    [StringLength(26)]
    public string? gslType { get; set; }

    [StringLength(26)]
    public string? distributionType { get; set; }

    public bool? use { get; set; }
}
