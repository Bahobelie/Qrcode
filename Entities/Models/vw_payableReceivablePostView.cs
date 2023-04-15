using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_payableReceivablePostView
{
    [StringLength(26)]
    public string sourceVoucherCode { get; set; } = null!;

    public int sourceVdef { get; set; }

    [StringLength(100)]
    public string? sourceVdefName { get; set; }

    [StringLength(26)]
    public string? consigneeCode { get; set; }

    public int? consigneeGsl { get; set; }

    public string? consigneeName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime sourceIssueDate { get; set; }

    [StringLength(26)]
    public string? sourcePeriod { get; set; }

    [Column(TypeName = "money")]
    public decimal sourceGrandTotal { get; set; }

    [StringLength(26)]
    public string? jdCode { get; set; }

    [StringLength(26)]
    public string? jvCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? jvDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? jvGrandTotal { get; set; }

    [StringLength(26)]
    public string? jvPeriod { get; set; }

    [StringLength(26)]
    public string? account { get; set; }

    [Column(TypeName = "money")]
    public decimal? debit { get; set; }

    [Column(TypeName = "money")]
    public decimal? credit { get; set; }

    [Column(TypeName = "money")]
    public decimal? jvTotal { get; set; }

    [StringLength(26)]
    public string? referenced { get; set; }

    [StringLength(26)]
    public string? jvType { get; set; }

    [StringLength(50)]
    public string accountName { get; set; } = null!;

    [StringLength(26)]
    public string controlAccount { get; set; } = null!;

    public bool isDebit { get; set; }

    [StringLength(26)]
    public string? reconCode { get; set; }

    [StringLength(50)]
    public string? reconName { get; set; }
}
