using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_CareerView
{
    [StringLength(50)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string type { get; set; } = null!;

    [StringLength(50)]
    public string typeDescription { get; set; } = null!;

    [StringLength(50)]
    public string person { get; set; } = null!;

    [StringLength(62)]
    public string? fullName { get; set; }

    public int index { get; set; }

    [StringLength(50)]
    public string organization { get; set; } = null!;

    public string? orgName { get; set; }

    [StringLength(50)]
    public string field { get; set; } = null!;

    [StringLength(50)]
    public string fieldDescription { get; set; } = null!;

    [StringLength(50)]
    public string level { get; set; } = null!;

    [StringLength(50)]
    public string levelDescription { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime startDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endDate { get; set; }

    public string? award { get; set; }

    public string? note { get; set; }

    [StringLength(50)]
    public string? status { get; set; }

    [StringLength(50)]
    public string? stateDescription { get; set; }

    public string? remark { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal duration { get; set; }
}
