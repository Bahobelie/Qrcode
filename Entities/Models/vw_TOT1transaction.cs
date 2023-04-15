using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_TOT1transaction
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public int taxType { get; set; }

    [StringLength(50)]
    public string TOT1 { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal amountPercentage { get; set; }

    [Column(TypeName = "money")]
    public decimal TOT1taxableAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal TOT1taxAmount { get; set; }
}
