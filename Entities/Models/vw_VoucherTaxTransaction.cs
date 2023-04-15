using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherTaxTransaction
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? IssuedDate { get; set; }

    public int? voucherDefinition { get; set; }

    public int TaxCode { get; set; }

    [StringLength(50)]
    public string TaxDescription { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal TaxPercent { get; set; }

    [Column(TypeName = "money")]
    public decimal taxableAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal taxAmount { get; set; }

    public bool? IsIssued { get; set; }

    public bool? IsVoid { get; set; }
}
