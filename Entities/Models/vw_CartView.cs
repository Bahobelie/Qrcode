using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_CartView
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string account { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal debit { get; set; }

    [Column(TypeName = "money")]
    public decimal credit { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(2048)]
    public string? note { get; set; }

    [StringLength(26)]
    public string cart { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? value { get; set; }
}
