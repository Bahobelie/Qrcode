using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class rptTransactionReference
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(62)]
    public string? consignee { get; set; }

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? To { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string referenced { get; set; } = null!;
}
