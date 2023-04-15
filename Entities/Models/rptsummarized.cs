using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class rptsummarized
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? IssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? discount { get; set; }

    [Column(TypeName = "money")]
    public decimal? additionalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? subTotal { get; set; }

    [StringLength(62)]
    public string? consignee { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxAmount { get; set; }

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? To { get; set; }

    public bool IsVoid { get; set; }

    public bool IsIssued { get; set; }

    [StringLength(26)]
    public string? description { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    [StringLength(26)]
    public string? person { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    public string? devicename { get; set; }

    [StringLength(100)]
    public string? name { get; set; }
}
