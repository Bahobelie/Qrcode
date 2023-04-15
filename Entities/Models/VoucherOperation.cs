using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class VoucherOperation
{
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime startTimStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endTimStamp { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    [StringLength(30)]
    public string userName { get; set; } = null!;
}
