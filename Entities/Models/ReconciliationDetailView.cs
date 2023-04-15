using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ReconciliationDetailView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string reconSum { get; set; } = null!;

    public int voucherDefnition { get; set; }

    public bool isDebit { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(50)]
    public string name { get; set; } = null!;

    [StringLength(100)]
    public string? named { get; set; }
}
