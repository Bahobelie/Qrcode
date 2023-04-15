using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_sales_noncash_transaction_view
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string nonCashTrxConsigneeCode { get; set; } = null!;

    public string? nonCashTrxConsigneeName { get; set; }

    [StringLength(26)]
    public string paymentMethod { get; set; } = null!;

    [StringLength(50)]
    public string paymentMethodDesc { get; set; } = null!;

    [StringLength(26)]
    public string? paymentProcesser { get; set; }

    public string? paymentProcessorDesc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime nonCashTrxDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? maturityDate { get; set; }

    [Column(TypeName = "money")]
    public decimal nonCashTrxAmount { get; set; }

    [StringLength(100)]
    public string? nonCashTrxRemark { get; set; }

    [StringLength(26)]
    public string? voucherConsignee { get; set; }

    public string? voucherConsigneeName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime voucherIssueDate { get; set; }

    public bool isissued { get; set; }

    public bool isvoid { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(50)]
    public string lastObjectStateDesc { get; set; } = null!;

    [StringLength(26)]
    public string? color { get; set; }

    [StringLength(26)]
    public string? lastActivity { get; set; }

    [StringLength(30)]
    public string? preparedBy { get; set; }

    public string? org { get; set; }

    [StringLength(26)]
    public string? branchCode { get; set; }

    [StringLength(50)]
    public string? branch { get; set; }

    public string? tin { get; set; }
}
