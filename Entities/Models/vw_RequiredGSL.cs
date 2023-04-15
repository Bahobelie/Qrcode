using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_RequiredGSL
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefn { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    public byte Index { get; set; }

    [StringLength(50)]
    public string description { get; set; } = null!;

    public bool IsMandatory { get; set; }

    public byte reqGSLDetailIndex { get; set; }

    public int? gslType { get; set; }

    [StringLength(50)]
    public string GSLTypeListDesc { get; set; } = null!;

    [StringLength(26)]
    public string category { get; set; } = null!;

    public bool? isActive { get; set; }

    [StringLength(26)]
    public string objectState { get; set; } = null!;
}
