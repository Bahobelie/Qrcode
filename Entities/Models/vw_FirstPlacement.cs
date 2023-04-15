using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_FirstPlacement
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public string? value { get; set; }

    [StringLength(26)]
    public string? firstVoucherTermConsignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? period { get; set; }
}
