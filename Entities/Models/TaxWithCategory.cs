using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class TaxWithCategory
{
    [StringLength(26)]
    public string PCode { get; set; } = null!;

    [StringLength(50)]
    public string PDescrption { get; set; } = null!;

    public int code { get; set; }

    [StringLength(26)]
    public string category { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal amount { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
