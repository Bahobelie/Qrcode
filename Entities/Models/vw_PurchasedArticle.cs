using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_PurchasedArticle
{
    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime expiryDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime prodDate { get; set; }

    [StringLength(26)]
    public string VoucherNo { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    public int voucherDefinition { get; set; }

    public bool IsVoid { get; set; }
}
