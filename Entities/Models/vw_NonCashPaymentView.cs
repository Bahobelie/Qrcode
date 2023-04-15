using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_NonCashPaymentView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(64)]
    public string name { get; set; } = null!;

    [StringLength(26)]
    public string receiver { get; set; } = null!;

    public bool isIncoming { get; set; }

    [StringLength(26)]
    public string paymentMethod { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime issueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? maturityDate { get; set; }

    [StringLength(50)]
    public string number { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal amount { get; set; }

    public bool executed { get; set; }

    [StringLength(26)]
    public string? currencyCode { get; set; }

    [Column(TypeName = "money")]
    public decimal? rate { get; set; }

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(26)]
    public string orgCode { get; set; } = null!;

    [StringLength(50)]
    public string tradeName { get; set; } = null!;
}
