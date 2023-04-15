using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherTaxTransactionReference
{
    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [StringLength(26)]
    public string referening { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public int voucherDefinition { get; set; }

    public int taxType { get; set; }

    [Column(TypeName = "money")]
    public decimal taxableAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal taxAmount { get; set; }
}
