using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_NonCashTransactionView
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? maturityDate { get; set; }

    [StringLength(26)]
    public string? PaymentProcessor { get; set; }

    [StringLength(50)]
    public string number { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime issueDate { get; set; }

    [StringLength(26)]
    public string? parentId { get; set; }

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(50)]
    public string Branch { get; set; } = null!;

    public string tradeName { get; set; } = null!;

    public string description { get; set; } = null!;
}
