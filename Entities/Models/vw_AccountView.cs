using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_AccountView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string controlAccount { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    public bool isActive { get; set; }

    [StringLength(26)]
    public string? parentAccount { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(15)]
    public string accCategory { get; set; } = null!;

    [StringLength(50)]
    public string accType { get; set; } = null!;

    [StringLength(50)]
    public string ControlAccountdescription { get; set; } = null!;

    [StringLength(15)]
    public string normalBalance { get; set; } = null!;
}
