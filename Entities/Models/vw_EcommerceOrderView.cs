using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_EcommerceOrderView
{
    [StringLength(26)]
    public string orderNumber { get; set; } = null!;

    [StringLength(26)]
    public string voucherType { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? objectState { get; set; }

    public int voucherDefinition { get; set; }

    public string? supplierName { get; set; }

    public string? tin { get; set; }
}
