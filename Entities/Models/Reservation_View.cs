using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Reservation_View
{
    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(26)]
    public string? requiredGSL { get; set; }

    [StringLength(26)]
    public string voucherExtension { get; set; } = null!;

    [StringLength(26)]
    public string? paymentMethod { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? maturityDate { get; set; }

    [StringLength(50)]
    public string? NonCashTransactionNumber { get; set; }

    [StringLength(26)]
    public string VoucherExtensionTransactionNumber { get; set; } = null!;

    [StringLength(2048)]
    public string? note { get; set; }

    [StringLength(26)]
    public string? VoucherCode { get; set; }

    [StringLength(26)]
    public string? currencyCode { get; set; }
}
