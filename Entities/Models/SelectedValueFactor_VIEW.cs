using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class SelectedValueFactor_VIEW
{
    [StringLength(26)]
    public string DefCode { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(50)]
    public string valueFDefDescription { get; set; } = null!;

    public bool isPercent { get; set; }

    public double value { get; set; }

    [StringLength(26)]
    public string valueFCode { get; set; } = null!;

    [StringLength(50)]
    public string? valueFDescription { get; set; }

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }
}
