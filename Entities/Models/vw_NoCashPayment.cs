using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_NoCashPayment
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string paymentMethod { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? maturityDate { get; set; }

    [Column(TypeName = "money")]
    public decimal amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime issueDate { get; set; }

    [StringLength(26)]
    public string? currencyCode { get; set; }

    [StringLength(50)]
    public string? tradeName { get; set; }

    [StringLength(26)]
    public string? organizationUnitDefinition { get; set; }

    [StringLength(50)]
    public string number { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(50)]
    public string? PaymentProcessor { get; set; }

    [StringLength(50)]
    public string? Branch { get; set; }
}
