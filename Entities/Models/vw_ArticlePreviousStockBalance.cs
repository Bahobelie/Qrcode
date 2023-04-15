﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ArticlePreviousStockBalance
{
    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(26)]
    public string store { get; set; } = null!;

    [Column(TypeName = "decimal(18, 7)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PeriodEnd { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;
}
