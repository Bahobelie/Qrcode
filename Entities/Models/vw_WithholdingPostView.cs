using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_WithholdingPostView
{
    [StringLength(26)]
    public string? whVoucher { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? whIssueDate { get; set; }

    [StringLength(20)]
    public string? tin { get; set; }

    [StringLength(26)]
    public string? whPeriod { get; set; }

    [Column(TypeName = "money")]
    public decimal? whGrandTotal { get; set; }

    [StringLength(26)]
    public string? whExtension { get; set; }

    [StringLength(26)]
    public string sourceVoucher { get; set; } = null!;

    public int sourceVoucherDef { get; set; }

    [StringLength(100)]
    public string? sourceVoucherDefName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime sourceIssueDate { get; set; }

    [Column(TypeName = "money")]
    public decimal sourceGrandTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal sourceWhTaxAmount { get; set; }

    [StringLength(26)]
    public string jvCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime jvDate { get; set; }

    [Column(TypeName = "money")]
    public decimal jvGrandTotal { get; set; }

    [StringLength(26)]
    public string jvPeriod { get; set; } = null!;

    [StringLength(26)]
    public string account { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal debit { get; set; }

    [Column(TypeName = "money")]
    public decimal credit { get; set; }

    [Column(TypeName = "money")]
    public decimal jvTotal { get; set; }

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [StringLength(26)]
    public string jvType { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? difference { get; set; }

    [StringLength(26)]
    public string? jdCode { get; set; }
}
