﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherReferenceView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(102)]
    public string? name { get; set; }

    [Column(TypeName = "money")]
    public decimal? subTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? discount { get; set; }

    [Column(TypeName = "money")]
    public decimal? additionalCharge { get; set; }

    [StringLength(50)]
    public string? ObjectStateDescription { get; set; }

    [StringLength(26)]
    public string? source { get; set; }

    [StringLength(26)]
    public string? destination { get; set; }

    [StringLength(2048)]
    public string? note { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    [StringLength(26)]
    public string? user { get; set; }

    [StringLength(26)]
    public string? organizationUnitDef { get; set; }

    [StringLength(26)]
    public string referening { get; set; } = null!;

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? value { get; set; }

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string consignee { get; set; } = null!;
}
