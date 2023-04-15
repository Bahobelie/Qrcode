using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class NonCashTransaction_View
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string consignee { get; set; } = null!;

    public string? consignee_description { get; set; }

    public bool isIncoming { get; set; }

    [StringLength(26)]
    public string paymentMethod { get; set; } = null!;

    public string payment_description { get; set; } = null!;

    [StringLength(26)]
    public string? paymentProcesser { get; set; }

    [StringLength(50)]
    public string? paymentProcessor_description { get; set; }

    public int index { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime issueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? maturityDate { get; set; }

    [StringLength(50)]
    public string number { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal amount { get; set; }

    public bool executed { get; set; }

    [StringLength(100)]
    public string? depositRef { get; set; }

    [StringLength(26)]
    public string? currencyCode { get; set; }

    [StringLength(50)]
    public string currency_description { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? rate { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    public bool IsVoid { get; set; }
}
