using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_dailyPackageDetail
{
    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    [StringLength(26)]
    public string regCode { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }
}
