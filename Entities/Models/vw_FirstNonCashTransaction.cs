using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_FirstNonCashTransaction
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string paymentMethodCode { get; set; } = null!;

    public string paymentMethodDescription { get; set; } = null!;

    [StringLength(26)]
    public string? paymentProcesserCode { get; set; }

    [StringLength(50)]
    public string? paymentProcesserDescription { get; set; }

    [StringLength(26)]
    public string? bankCode { get; set; }

    public string? bankName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime nonCashPaymentIssuedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? nonCashPaymentMaturityDate { get; set; }

    [StringLength(50)]
    public string nonCashPaymentNumber { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? nonCashPaymentRate { get; set; }

    [Column(TypeName = "money")]
    public decimal nonCashPaymentAmount { get; set; }

    [StringLength(26)]
    public string? nonCashPaymentCurrencyCode { get; set; }

    [StringLength(50)]
    public string? nonCashPaymentCurrencyDescription { get; set; }

    [StringLength(8)]
    public string? nonCashPaymentCurrencyAbbreviation { get; set; }

    public long? r { get; set; }
}
