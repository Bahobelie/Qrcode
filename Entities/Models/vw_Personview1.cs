using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_Personview1
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int type { get; set; }

    public string? Title { get; set; }

    [StringLength(20)]
    public string firstName { get; set; } = null!;

    [StringLength(20)]
    public string? middleName { get; set; }

    [StringLength(20)]
    public string? lastName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOB { get; set; }

    public string? Gender { get; set; }

    [StringLength(50)]
    public string? nationality { get; set; }
}
