using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_AllPersonView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int type { get; set; }

    [StringLength(20)]
    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [StringLength(26)]
    public string? nationality { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOB { get; set; }

    [StringLength(26)]
    public string? title { get; set; }

    [StringLength(26)]
    public string gender { get; set; } = null!;

    [StringLength(26)]
    public string? religion { get; set; }

    [StringLength(26)]
    public string? preference { get; set; }

    public bool isActive { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(50)]
    public string? Ltitle { get; set; }

    [StringLength(50)]
    public string? Lgender { get; set; }

    [StringLength(50)]
    public string? Lnationality { get; set; }
}
