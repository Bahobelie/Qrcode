using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class SubscriptionView
{
    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(26)]
    public string? scheduledHeader { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime expiryDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime prodDate { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    public int voucherDefinition { get; set; }
}
