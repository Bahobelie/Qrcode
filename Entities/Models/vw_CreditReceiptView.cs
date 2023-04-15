using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_CreditReceiptView
{
    public string? employee { get; set; }

    [StringLength(26)]
    public string? preparedBy { get; set; }

    [StringLength(26)]
    public string creditVoucher { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime creditIssuedDate { get; set; }

    public string? creditConsignee { get; set; }

    [StringLength(26)]
    public string? fsNo { get; set; }

    [Column(TypeName = "money")]
    public decimal? subTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal VATtaxAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string receiptReference { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime receiptIssuedDate { get; set; }

    [StringLength(50)]
    public string checkNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? checkDate { get; set; }

    [Column(TypeName = "money")]
    public decimal amount { get; set; }

    [StringLength(50)]
    public string? store { get; set; }
}
