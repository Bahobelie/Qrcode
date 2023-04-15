using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("PaymentSchedule", Schema = "Internal")]
public partial class PaymentSchedule
{
    public Guid ID { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucherReference { get; set; } = null!;

    public int sequence { get; set; }

    public int percent { get; set; }

    public double amount { get; set; }

    [StringLength(200)]
    public string term { get; set; } = null!;

    [StringLength(50)]
    public string? remark { get; set; }
}
