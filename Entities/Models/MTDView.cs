using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class MTDView
{
    [StringLength(26)]
    public string person { get; set; } = null!;

    [Column(TypeName = "decimal(38, 4)")]
    public decimal? MTD { get; set; }
}
