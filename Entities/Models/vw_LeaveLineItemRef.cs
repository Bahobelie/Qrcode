using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LeaveLineItemRef
{
    [StringLength(26)]
    public string lineItem { get; set; } = null!;

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public int referingVouDfn { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal value { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime prodDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime expiryDate { get; set; }
}
