using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LineItemQtySum
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [Column(TypeName = "decimal(38, 4)")]
    public decimal? lineItemQtySum { get; set; }
}
