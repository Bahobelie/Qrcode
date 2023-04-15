using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_EvaluationSheet
{
    [StringLength(26)]
    public string Vouchercode { get; set; } = null!;

    [StringLength(2048)]
    public string note { get; set; } = null!;

    [StringLength(26)]
    public string EvalutionSheetCode { get; set; } = null!;

    public int? index { get; set; }

    [StringLength(50)]
    public string? question { get; set; }

    [StringLength(50)]
    public string? point { get; set; }

    [StringLength(50)]
    public string? timeRequired { get; set; }

    [StringLength(50)]
    public string? isBonus { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
